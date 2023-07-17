#include <ESP8266WiFi.h>

const char* ssid = "TurkTelekomDU";
const char* password = "Umut.Deniz7471";

int ledPin = 13; // GPIO13 ucu D7 ye karsılık gelir bahsettigimiz gibi
WiFiServer server(80);
 
void setup() {
Serial.begin(115200);
pinMode(ledPin, OUTPUT);
digitalWrite(ledPin, LOW);
 
// Wifi bağlantısı
Serial.println();
Serial.println();
Serial.print("Connecting to ");
Serial.println(ssid);
 
WiFi.begin(ssid, password);                         //Modem id ve şifresi ile bağlantı sağlıyor
 
while (WiFi.status() != WL_CONNECTED) {             //Modem bağlantısı gerçekleşene kadar buradaki döngüde kalıyor 
delay(500);
Serial.print(".");
}
Serial.println("");
Serial.println("WiFi connected");
 
server.begin();                                     // server baslatılıyor
Serial.println("Server started");
 
Serial.print("Use this URL to connect: ");          // baglantı saglandıktan sonra serial monitorde ip adresini gösterecek
Serial.print("http://");
Serial.print(WiFi.localIP());                       // Local Ip adresini geri döndüren komut
Serial.println("/");
}
 
void loop() {
WiFiClient client = server.available();             // bir clien istemci bağlı olup olmadığını kontrol ediyoruz
if(!client) {return;}


Serial.println("new client");                       // client ın bir data gondermesini bekliyoruz
while(!client.available()){delay(1);}
 

String request = client.readStringUntil('\r');      // gelen istekleri okuyoruz
Serial.println(request);
client.flush();
 
int Led_Durum = LOW;                                
if (request.indexOf("/LED-ACIK") != -1) {           // Serverdan gelen veriye göre ledi yakıyor veya kapatıyor 
digitalWrite(ledPin, HIGH);
Led_Durum = HIGH;
}
if (request.indexOf("/LED-KAPALI") != -1) {
digitalWrite(ledPin, LOW);
Led_Durum = LOW;
}
 
// BU BOLUMDE HTML KODLARI İLE BASİT BİR ARAYÜZ OLUŞTURUYORUZ
 
client.println("HTTP/1.1 200 OK");
client.println("Content-Type: text/html");
client.println(""); 
client.println("<!DOCTYPE HTML>");
client.println("<html>");
client.print("Led Durum : ");
 
if(Led_Durum == HIGH) {client.print("ACIK");} 
else {client.print("KAPALI");}

client.println("");
client.println("<a href=\"/LED-ACIK\"\"><button>ledi yak </button></a>");
client.println("<a href=\"/LED-KAPALI\"\"><button>ledi sondur </button></a>"); 
client.println("</html>");
   
delay(1);
Serial.println("Client disonnected");
Serial.println("");
 
}