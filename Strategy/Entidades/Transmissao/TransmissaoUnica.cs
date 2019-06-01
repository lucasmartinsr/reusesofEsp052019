using Strategy.Interfaces;

namespace Strategy.Entidades.Transmissao
{
    public class TransmissaoUnica : IPreparadorNumeroTransmissoes
    {
        public int PrepareAmbienteParaTransmissoesSimultaneas()
        {
            return 1;
        }
    }
}
