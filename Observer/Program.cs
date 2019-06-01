using Observer.Entidades.Observadores;
using Observer.Entidades.Sujeito;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacao estacao = new Estacao();
            estacao.Attach(new ClimaTempo(estacao));
            estacao.Attach(new Inmet(estacao));
            estacao.Attach(new CamposUniversitarios(estacao));

            estacao.Temperatura = 10;
            estacao.Umidade = 80;

            Console.ReadKey();
        }
    }
}
