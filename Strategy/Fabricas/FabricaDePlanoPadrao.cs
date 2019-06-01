using Strategy.Entidades;
using Strategy.Entidades.Conteudo;
using Strategy.Entidades.Transmissao;
using Strategy.Fabricas.Interfaces;
using Strategy.Interfaces;

namespace Strategy.Fabricas
{
    public class FabricaDePlanoPadrao : IFabricaAbstrataPlano
    {
        public IContentTransformer ObtenhaConteudoQualidade()
        {
            return new HD();
        }

        public IPreco ObtenhaPreco()
        {
            return new Preco();
        }

        public IPreparadorNumeroTransmissoes ObtenhaTransmissao()
        {
            return new TransmissaoDupla();
        }
    }
}
