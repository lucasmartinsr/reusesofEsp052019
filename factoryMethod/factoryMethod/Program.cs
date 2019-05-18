using factoryMethod.Enums;
using factoryMethod.Fabricas;
using factoryMethod.Interfaces;
using System;

namespace factoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IVeiculoFactory veiculoFactory = new VeiculoFactory();
            var veiculo = veiculoFactory.Create(EnumCondicaoMeteologica.Sol, 3, 200);
            Console.WriteLine($"Veículo: {veiculo.GetType().Name}");
            Console.ReadKey();
        }
    }
}
