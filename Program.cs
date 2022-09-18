using DesafioPOO.Models;

Nokia nokia = new Nokia(numero: "(11)98765-4321", modelo: "KIA", imei: "001970-01-010000-0", memoria: 16);

nokia.Numero = "(11)98765-0123";

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");


Iphone iphone = new Iphone(numero: "(11)91234-5678", modelo: "iPhone 12", imei: "001970-01-010000-0", memoria: 128);

iphone.Numero = "(11)91234-5678";

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Zap");