using Observer.Entidades.Sujeito;
using System;

namespace Observer.Entidades.Observadores
{
    public class Inmet : IObserver
    {
        private readonly Estacao _estacao;

        public Inmet(Estacao estacao)
        {
            _estacao = estacao;
        }
        public void Update()
        {
            Console.WriteLine("\nInmet Notificado!");
            Console.WriteLine(_estacao.ToString());
        }
    }
}
