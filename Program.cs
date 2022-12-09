using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 01", imei:111111111, memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "modelo 01", imei:111111111, memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");