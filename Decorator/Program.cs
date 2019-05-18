using Decorator.Entidades;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pratoA = new PratoA();

            Prato pratoAComDoisAdicionaisDeOvo = new Ovo(pratoA);
            pratoAComDoisAdicionaisDeOvo = new Ovo(pratoAComDoisAdicionaisDeOvo);
            Console.WriteLine($"Prato A + 2 adicionais de ovo: {pratoAComDoisAdicionaisDeOvo.GetPreco}");

            Prato pratoAComAdicionalDeCebola = new Cebola(pratoA);
            Console.WriteLine($"Prato A + 1 adicional de cebola: {pratoAComAdicionalDeCebola.GetPreco}");

            var pratoB = new PratoB();
            Console.WriteLine($"Prato B sem adicionais: {pratoB.GetPreco}");
        }
    }
}
