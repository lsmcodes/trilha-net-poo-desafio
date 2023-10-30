using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(22)2222-3333", modelo: "Nokia G60", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(33)3333-4444", modelo: "Iphone 13", imei: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");