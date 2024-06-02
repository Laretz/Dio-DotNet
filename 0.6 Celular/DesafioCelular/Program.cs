using DesafioPOO.Models;

Console.WriteLine("Celular Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Xd1", imei: "1123123123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("STEAM");

nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Facebook");
nokia.InstalarAplicativo("Instagram");

nokia.ExibirApps();

Console.WriteLine("//////////////////////////////////");
Smartphone iphone = new Iphone("123456", "Xd1",  "1123123123", 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Facebook");
iphone.ExibirApps();