using DesafioPOO.Models;

Console.WriteLine("Celular 1.");
Iphone c1 = new Iphone(numero: "12345", modelo: "Iphone", imei: "abc@def", memoria: 34);
c1.Ligar();
c1.InstalarAplicativo("YouTube");

Console.WriteLine("Celular 2.");
Nokia c2 = new Nokia(numero: "6789", modelo: "Nokia", imei: "ghi@jklm", memoria: 34);
c2.Ligar();
c2.InstalarAplicativo("YouTube");


// TODO: Realizar os testes com as classes Nokia e Iphone