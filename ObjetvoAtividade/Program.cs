using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro[] carList = new Carro[]
            {
                new Carro("Sedan",      "ABC1A23", "Vermelho",   "V6"),
                new Carro("SUV",        "XYZ4B56", "Azul",       "Elétrico"),
                new Carro("Hatchback",  "JKL7C89", "Preto",      "1.0 Turbo"),
                new Carro("Pickup",     "MNO0D12", "Branco",     "V8"),
                new Carro("Coupé",      "PQR3E45", "Prata",      "V6 Biturbo"),
                new Carro("Conversível","STU6F78", "Amarelo",    "2.0"),
                new Carro("Minivan",    "VWX9G01", "Verde",      "V6 Híbrido"),
                new Carro("Sedan",      "AAA1H11", "Bordô",      "1.6"),
                new Carro("SUV",        "BBB2I22", "Grafite",    "Híbrido"),
                new Carro("Hatchback",  "CCC3J33", "Azul-claro", "Elétrico")
            };

            foreach (var carro in carList)
                Console.WriteLine(carro);

            Console.WriteLine();
            carList[0].Ligar();
        }
    }
}
