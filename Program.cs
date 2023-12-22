using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo 5s", imei: "785463", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("Ifood");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12322", modelo: "Modelo 15 pro max", imei: "12344", memoria: "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");
