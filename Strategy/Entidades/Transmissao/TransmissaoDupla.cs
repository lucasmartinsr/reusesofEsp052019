using Strategy.Interfaces;

namespace Strategy.Entidades.Transmissao
{
    public class TransmissaoDupla : IPreparadorNumeroTransmissoes
    {
        public int PrepareAmbienteParaTransmissoesSimultaneas()
        {
            return 2;
        }
    }
}
