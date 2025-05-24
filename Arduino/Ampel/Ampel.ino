/*
 * Ampel-Beispiel
 * Kippschalter and D2 mit Pull-Down (hoher Widerstand) auf Ground
 * LEDs mit 68 Ohm Vorwiderstand
*/

//letzter Schalterzustand
int lastState = 0;

// the setup function runs once when you press reset or power the board
void setup() {
  Serial.begin(9600);
  pinMode(2, INPUT);   //schalter
  pinMode(3, OUTPUT);  //grün
  pinMode(4, OUTPUT);  //gelb
  pinMode(5, OUTPUT);  //rot

  //je nach intitaler Schalterposition rot oder grün an schalten
  lastState = digitalRead(2);
  if(lastState = 1)
  {
    digitalWrite(3, HIGH);
  }
  else
  {
    digitalWrite(5, HIGH);
  }
  
}

// the loop function runs over and over again forever
void loop() {
  if (digitalRead(2) == HIGH)
  {
    if (lastState == 1)
    {
      //nichts zu tun
    }
    else
    {
      //schalte von rot zu grün
      digitalWrite(4, HIGH);
      delay(2000);
      digitalWrite(4, LOW);
      digitalWrite(5, LOW);
      digitalWrite(3, HIGH);
      lastState = 1;
    }
  }
  else
  {
    if (lastState == 0)
    {
      //nichts zu tun
    }
    else
    {
      //schalte von grün zu rot
      digitalWrite(4, HIGH);
      delay(2000);

      digitalWrite(4, LOW);
      digitalWrite(3, LOW);
      digitalWrite(5, HIGH);
      lastState = 0;
    }
  }
}
