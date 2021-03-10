#include "DHT.h"
#include "ESP8266WiFi.h"
#include "ESP8266HTTPClient.h"

WiFiClient client;
DHT dht(2, DHT11);

char* SSID = "SSID"; // Enter SSID
char* WIFI_PASSWORD = "WIFI_PASSWORD"; // Enter Password
String serverName = "serverName"; // Enter Server name (url/ip)

int MIN_INTVL = 5; // Enter send interval (in minutes)
String ESP_ID = String(ESP.getChipId());
String API_KEY = "2r08Zz3ZyyLPUE4c3LgWb6";

boolean isDht = false;

void setup(){
   // Initiate hardware
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  dht.begin();
}

void loop(){ 

  // Make sure wifi is connected
  if(!WiFi.status() == WL_CONNECTED){
    Serial.println("Connecting to wifi");
    WiFi.begin(SSID,WIFI_PASSWORD);
    return;
  }

  // Send data to api
  HTTPClient http;
  
  String data;
  String dataType;
  if(isDht) {
    data = getDhtData();
    dataType = "DHT";
  } else {
     data = getLmData();
     dataType = "LM";
  }

  String serverPath = serverName + "?key=" + API_KEY + "&esp_id=" + ESP_ID + "&data_type=" + dataType + "&data=" + urlencode(data); 
  
  http.begin(serverPath);
      
  // Send HTTP GET request
  int httpResponseCode = http.GET();

  Serial.println(httpResponseCode);

  // End connection
  http.end();

  delay(1000 * 60 * MIN_INTVL); // Loop everything X minutes
}

// Get air humidity and temprature values
String getDhtData() {
  char humidity = (char) dht.readHumidity();
  char temprature = (char) dht.readTemperature();
  return "{\"Humidity\": \""+String(humidity)+"\",\"Temperature °C\": \""+String(temprature)+"\"}";
}

// Get soil moisture values
String getLmData() {
  float sensor0 = analogRead(0);
  float sensor0P = 100.00 - ( ( 100.00 * sensor0 ) / 1023.00 );
  int sensorInt = (int) sensor0P;
  return "{\"Humidity\": \""+String(sensor0)+"\",\"Humidity percent\": \""+String(sensorInt)+"\"}";
}

// Encode URL
String urlencode(String str)
{
    String encodedString="";
    char c;
    char code0;
    char code1;
    char code2;
    for (int i =0; i < str.length(); i++){
      c=str.charAt(i);
      if (c == ' '){
        encodedString+= '+';
      } else if (isalnum(c)){
        encodedString+=c;
      } else{
        code1=(c & 0xf)+'0';
        if ((c & 0xf) >9){
            code1=(c & 0xf) - 10 + 'A';
        }
        c=(c>>4)&0xf;
        code0=c+'0';
        if (c > 9){
            code0=c - 10 + 'A';
        }
        code2='\0';
        encodedString+='%';
        encodedString+=code0;
        encodedString+=code1;
        //encodedString+=code2;
      }
      yield();
    }
    return encodedString;
}
