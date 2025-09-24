using System;

namespace MyApp
{
    internal class Carro
    {
        public string Chassis { get; set; }
        public string LicensePlate { get; set; }
        public string Cor { get; set; }
        public string Motor { get; set; }

        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            Chassis = chassis;
            LicensePlate = licensePlate;
            Cor = cor;
            Motor = motor;
        }

        public void Ligar() => Console.WriteLine("O carro esta ligado vrum vrum!");

        public override string ToString()
            => $"Detalhes do carro: Chassis: {Chassis}  Placa: {LicensePlate}  Cor: {Cor}  Motor: {Motor}";
    }
}
