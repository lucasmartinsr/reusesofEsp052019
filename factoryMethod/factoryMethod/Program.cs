using factoryMethod.Enums;
using factoryMethod.Extensoes;
using factoryMethod.Fabricas;
using factoryMethod.Interfaces;
using System;

namespace factoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IVeiculoFactory veiculoFactory = new VeiculoComCriseFactory();
            var veiculo = veiculoFactory.Crie(EnumCondicaoMeteologica.Sol, 3, 200);
            Console.WriteLine($"Veículo: {veiculo.GetType().Name}");
            Console.WriteLine($"Tipo de combustível: {veiculo.TipoDeCombustivel.ObtenhaDescricao()}");
            Console.ReadKey();
        }
    }
}
