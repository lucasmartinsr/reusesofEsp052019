using Observer.Entidades.Sujeito;
using System;

namespace Observer.Entidades.Observadores
{
    public class ClimaTempo : IObserver
    {
        private readonly Estacao _estacao;

        public ClimaTempo(Estacao estacao)
        {
            _estacao = estacao;
        }
        public void Update()
        {
            Console.WriteLine("\nClima Tempo Notificado!");
            Console.WriteLine(_estacao.ToString());
        }
    }
}
