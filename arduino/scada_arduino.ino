const int in3=3;
const int in4=4;
const int in5=5;
const int in6=6;
int su_kazan1, su_kuyu1;
String metin;

void setup() {
  pinMode(in3,OUTPUT);
  pinMode(in4,OUTPUT);
  pinMode(in5,OUTPUT);
  pinMode(in6,OUTPUT);
  pinMode(13,OUTPUT);
  digitalWrite(13,HIGH);
  Serial.begin(9600);
}


void loop() 
{
  if(Serial.available())
  {
    char c = Serial.read();
    if(c == '0')
    {
    digitalWrite(in5,LOW);
    digitalWrite(in6,LOW);
    durumKazan1 = 0;
    }
    else if(c == '1')
    {
    digitalWrite(in5,HIGH);
    digitalWrite(in6,LOW);
    durumKazan1 = 1;
    }
    else if(c == '2')
    {
    digitalWrite(in3,LOW);
    digitalWrite(in4,LOW);
    durumKuyu1 = 0;
    }
    else if(c == '3')
    {
    digitalWrite(in3,HIGH);
    digitalWrite(in4,LOW);
    durumKuyu1 = 1;
    }

  }
  delay(125);
  su_kazan1 = analogRead(A0);
  metin = "KAZAN1=" + String(su_kazan1);
  Serial.println(metin);
  su_kuyu1 = analogRead(A1);
  metin = "KUYU1=" + String(su_kuyu1);
  Serial.println(metin);
  delay(125);
}
