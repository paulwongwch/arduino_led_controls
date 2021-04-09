const int led1Pin = 7;
const int led2Pin = 5;
const int led3Pin = 3;

String inputString = "";        // a String to hold incoming data
bool stringComplete = false;    // whether the string is complete

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(led1Pin, OUTPUT);
  pinMode(led2Pin, OUTPUT);
  pinMode(led3Pin, OUTPUT);
}

void loop() {
  // print the string when a newline arrives:
  if (stringComplete) {
    if (inputString.equals("START")) {
      
    } else if (inputString.equals("STOP")) {
      digitalWrite(led1Pin,LOW);
      digitalWrite(led2Pin,LOW);
      digitalWrite(led3Pin,LOW);
    } else if (inputString.equals("LED1ON")) {
      digitalWrite(led1Pin,HIGH);
    } else if (inputString.equals("LED1OFF")) {
      digitalWrite(led1Pin,LOW);
    } else if (inputString.equals("LED2ON")) {
      digitalWrite(led2Pin,HIGH);
    } else if (inputString.equals("LED2OFF")) {
      digitalWrite(led2Pin,LOW);
    } else if (inputString.equals("LED3ON")) {
      digitalWrite(led3Pin,HIGH);
    } else if (inputString.equals("LED3OFF")) {
      digitalWrite(led3Pin,LOW);
    }
    
    // clear the string:
    inputString = "";
    stringComplete = false;
  }
}

/*
  SerialEvent occurs whenever a new data comes in the hardware serial RX. This
  routine is run between each time loop() runs, so using delay inside loop can
  delay response. Multiple bytes of data may be available.
*/
void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    if (inChar == '\n') {
      stringComplete = true;
      break;
    }
    inputString += inChar;
    // if the incoming character is a newline, set a flag so the main loop can
    // do something about it:
  }
}
