using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123-456-789", modelo: "Nokia 3310", imei: "001122334455667", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987-654-321", modelo: "iPhone 13", imei: "998877665544332", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");