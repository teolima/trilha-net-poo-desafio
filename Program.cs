using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "222222", memoria: 65 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

Smartphone iphone = new Iphone(numero: "34567", modelo: "Modelo 2", imei: "111111", memoria: 85);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");