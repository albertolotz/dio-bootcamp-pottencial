using DesafioPOO.Models;

Iphone iphone = new Iphone(numero: "119999-8888", modelo: "14 Plus", imei: "1111-9999","128GB");
Nokia nokia = new Nokia(numero: "169999-1111", modelo: "NK-1000", imei: "1111-8812", "8GB");

Console.WriteLine("************ IPHONE *************");
iphone.Ligar();
iphone.InstalarAplicativo("Coral Vizualizer");
iphone.ReceberLigacao();


Console.WriteLine("************ NOKIA *************");
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");
nokia.ReceberLigacao();

