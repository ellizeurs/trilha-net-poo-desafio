using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);
Smartphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Angry Birds");