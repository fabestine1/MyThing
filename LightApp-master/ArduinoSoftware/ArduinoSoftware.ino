#include "EtherShield.h"
#include <NewRemoteTransmitter.h>
#include <OneWire.h>
#include <DallasTemperature.h>

#define MYWWWPORT 80
#define BUFFER_SIZE 550

NewRemoteTransmitter transmitter(8786506, 2, 260, 3);
OneWire oneWire(3);
DallasTemperature sensors(&oneWire);
DeviceAddress insideThermometer;
EtherShield es = EtherShield();

static uint8_t mymac[6] = {0x54,0x55,0x58,0x10,0x00,0x25}; 
static uint8_t myip[4] = {192,168,0,177};
static uint8_t buf[BUFFER_SIZE+1];

boolean lightState[16] = {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};


uint16_t print_data_xml(uint8_t *buf) {
  uint16_t plen;

  char buffer[5];
  String s = dtostrf(getTemp(),2,1,buffer);
  char temper[4];
  s.toCharArray(temper,5);

  plen=es.ES_fill_tcp_data_p(buf,0,PSTR("HTTP/1.0 200 OK\r\nContent-Type: text/xml\r\nPragma: no-cache\r\n\r\n"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<data>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<temp>"));
  plen=es.ES_fill_tcp_data(buf,plen,temper);
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</temp>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light0>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(0));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light0>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light1>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(1));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light1>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light2>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(2));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light2>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light3>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(3));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light3>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light4>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(4));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light4>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light5>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(5));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light5>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light6>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(6));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light6>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light7>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(7));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light7>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light8>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(8));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light8>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light9>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(9));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light9>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light10>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(10));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light10>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light11>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(11));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light11>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light12>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(12));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light12>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light13>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(13));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light13>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light14>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(14));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light14>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("<light15>"));
  plen=es.ES_fill_tcp_data(buf,plen,getLightState(15));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light15>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</light>"));
  plen=es.ES_fill_tcp_data_p(buf,plen,PSTR("</data>"));

  return(plen);
}

char* getLightState(int channel) {
  char state[2] = "0";
  if(lightState[channel] == true)
  {
    state[0] = char(0x31);
  }
  else
  {
    state[0] = char(0x30);
  }
  return state;
}

void sendTCP(uint16_t dat_p) {
  es.ES_www_server_reply(buf,dat_p);
}

float getTemp() {
  sensors.requestTemperatures();
  float tempC = sensors.getTempC(insideThermometer);
  return tempC;
}

void switchLight(int channel, boolean switchStatus) {
  transmitter.sendUnit(channel, switchStatus);
  lightState[channel] = switchStatus;
}

void checkCommand(uint16_t plen, uint16_t dat_p) {

  String light = "";
  String state = "";
  
  String data = (char *)&(buf[dat_p]);
  
  if(data.startsWith("GET /")) {    
    data = data.substring(5,data.length());
    int pos = data.indexOf("/");
    light = data.substring(0,pos);   
    state = data.substring(pos+1,pos+2);
  }
  
  if(light == "0" || light == "1" || light == "2" || light == "3"|| light == "4"|| light == "5"|| light == "6"|| light == "7"|| light == "8"|| light == "9"|| light == "10"|| light == "11"|| light == "12"|| light == "13"|| light == "14"|| light == "15"){
     if(state == "0" || state == "1") {
      char charBuf[light.length()];
      light.toCharArray(charBuf, light.length());
      int n = atoi(charBuf);
      boolean s = false;
      if(state = "1") {
        s = true;
      }
      
      switchLight(n, s);
      
      dat_p=print_data_xml(buf);
      sendTCP(dat_p);
      
      Serial.println("OK!");
     }
     Serial.println("NO STATE!");
  }
  Serial.println("NO LIGHT!");
  
  if (strncmp("/ ",(char *)&(buf[dat_p+4]),2)==0) {
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  }/*
  else if (strncmp("/10 ",(char *)&(buf[dat_p+4]),4)==0) {
    switchLight(12,LOW);
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  }
  else if (strncmp("/11 ",(char *)&(buf[dat_p+4]),4)==0) {
    switchLight(12,HIGH);
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  } 
  else if (strncmp("/20 ",(char *)&(buf[dat_p+4]),4)==0) {
    switchLight(13,LOW);
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  }
  else if (strncmp("/21 ",(char *)&(buf[dat_p+4]),4)==0) {
    switchLight(13,HIGH);
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  }
  else if (strncmp("/30 ",(char *)&(buf[dat_p+4]),4)==0) {
    switchLight(14,LOW);
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  }
  else if (strncmp("/31 ",(char *)&(buf[dat_p+4]),4)==0) {
    switchLight(14,HIGH);
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  } 
  else if (strncmp("/r ",(char *)&(buf[dat_p+4]),3)==0) {
    dat_p=print_data_xml(buf);
    sendTCP(dat_p);
  } */
  else {
    dat_p=es.ES_fill_tcp_data_p(buf,0,PSTR("HTTP/1.0 401 Unauthorized\r\nContent-Type: text/html\r\n\r\n<h1>401 Unauthorized</h1>"));
    sendTCP(dat_p);
  }
}

void setup(){
  Serial.begin(9600);
  
  sensors.begin();
  sensors.getAddress(insideThermometer, 0);
  sensors.setResolution(insideThermometer, 9);

  // Initialise SPI interface
  es.ES_enc28j60SpiInit();
  // initialize enc28j60
  es.ES_enc28j60Init(mymac);
  // init the ethernet/ip layer:
  es.ES_init_ip_arp_udp_tcp(mymac,myip, MYWWWPORT);
}

void loop(){
  uint16_t plen, dat_p;

  while(1) {
    getTemp();
    // read packet, handle ping and wait for a tcp packet:
    dat_p=es.ES_packetloop_icmp_tcp(buf,es.ES_enc28j60PacketReceive(BUFFER_SIZE, buf));

    /* dat_p will be unequal to zero if there is a valid 
     * http get */
    if(dat_p==0){
      // no http request
      continue;
    }
    checkCommand(plen, dat_p);
  }

}











