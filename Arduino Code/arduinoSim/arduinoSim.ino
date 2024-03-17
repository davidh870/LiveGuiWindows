// Declare variables
int photoResValueA0 = 0;
int photoResValueA1 = 0;





void setup() {
  // put your setup code here, to run once:
  pinMode(A0, INPUT);
  pinMode(A1, INPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  // Read value from photo resistor
  photoResValueA0 = analogRead(A0);
  photoResValueA1 = analogRead(A1);

  // Print value of photoresistor
  Serial.println("P0 " + String(photoResValueA0));
  Serial.println("P1 " + String(photoResValueA1));
  
}
