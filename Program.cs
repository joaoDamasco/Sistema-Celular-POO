using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Iphone: \n");
Smartphone iphone = new Iphone("159881", "Modelo 16", "5555", 128);
iphone.DadosSmartPhone();
iphone.InstalarAplicativo("Youtube");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine("\n");

Console.WriteLine("Celular Nokia: \n");
Smartphone nokia = new Nokia("123456", "Modelo 1.8", "6262", 240);
nokia.DadosSmartPhone();
nokia.InstalarAplicativo("Youtube");
nokia.Ligar();
nokia.ReceberLigacao();
