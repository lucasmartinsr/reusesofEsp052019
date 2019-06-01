using Observer.Entidades.Sujeito;
using System;

namespace Observer.Entidades.Observadores
{
    public class CamposUniversitarios : IObserver
    {
        private readonly Estacao _estacao;

        public CamposUniversitarios(Estacao estacao)
        {
            _estacao = estacao;
        }
        public void Update()
        {
            Console.WriteLine("\nCampos Universitarios Notificado!");
            Console.WriteLine(_estacao.ToString());
        }
    }
}
