using Strategy.Interfaces;

namespace Strategy.Entidades.Transmissao
{
    public class TransmissaoQuadrupla : IPreparadorNumeroTransmissoes
    {
        public int PrepareAmbienteParaTransmissoesSimultaneas()
        {
            return 4;
        }
    }
}
