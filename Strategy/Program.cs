using Strategy.Entidades;
using Strategy.Enums;
using Strategy.Fabricas;
using Strategy.Fabricas.Interfaces;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaDeAssinatura fabricaAssinatura = new FabricaAssinatura();
            var assinaturaBasica = fabricaAssinatura.Crie(EnumPlano.Basico);
            var assinaturaPadrao = fabricaAssinatura.Crie(EnumPlano.Padrao);
            var assinaturaPremium = fabricaAssinatura.Crie(EnumPlano.Premium);

            Console.WriteLine($"Plano Básico");
            Console.WriteLine($"Qualidade: {assinaturaBasica.DisponibilizeConteudo().Tipo}");
            Console.WriteLine($"Valor: {assinaturaBasica.ObtenhaPreco()}");
            assinaturaBasica.PermitirNumeroTransmissoesSimultaneas();

            Console.WriteLine($"\nPlano Padrão");
            Console.WriteLine($"Qualidade: {assinaturaPadrao.DisponibilizeConteudo().Tipo}");
            Console.WriteLine($"Valor: {assinaturaPadrao.ObtenhaPreco()}");
            assinaturaPadrao.PermitirNumeroTransmissoesSimultaneas();

            Console.WriteLine($"\nPlano Premium");
            Console.WriteLine($"Qualidade: {assinaturaPremium.DisponibilizeConteudo().Tipo}");
            Console.WriteLine($"Valor: {assinaturaPremium.ObtenhaPreco()}");
            assinaturaPremium.PermitirNumeroTransmissoesSimultaneas();

            Console.ReadKey();
        }
    }
}
