#define DEBUG true
#define CHARSFORINT 4

#include <SoftwareSerial.h>

// Settings
typedef struct Settings {
	int boozeTime;
};

// Function prototypes
void ReadSerial(Settings*);
int SerialGetValue(char*, short);