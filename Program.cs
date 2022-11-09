using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11996542312", modelo: "N95", iMEI: "9012345", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "21993827282", modelo: "Iphone 13", iMEI: "32123455", memoria: 4);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");