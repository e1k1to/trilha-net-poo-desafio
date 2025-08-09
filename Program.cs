using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456789", 128);
Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654321", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

nokia.Ligar(); 
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.ReadKey();