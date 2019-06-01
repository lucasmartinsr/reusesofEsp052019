using Strategy.Entidades;
using Strategy.Enums;
using Strategy.Fabricas.Interfaces;

namespace Strategy.Fabricas
{
    public class FabricaAssinatura: IFabricaDeAssinatura
    {
        public Assinatura Crie(EnumPlano plano)
        {
            switch (plano)
            {
                case EnumPlano.Basico:
                    IFabricaAbstrataPlano fabricaPlanoBasico = new FabricaDePlanoBasico();
                    var preco = fabricaPlanoBasico.ObtenhaPreco();
                    var tramissoes = fabricaPlanoBasico.ObtenhaTransmissao();
                    var qualidade = fabricaPlanoBasico.ObtenhaConteudoQualidade();
                    return new Assinatura(preco,tramissoes, qualidade);
                case EnumPlano.Padrao:
                    IFabricaAbstrataPlano fabricaPlanoPadrao = new FabricaDePlanoPadrao();
                    var precoPadrao = fabricaPlanoPadrao.ObtenhaPreco();
                    var tramissoesPadrao = fabricaPlanoPadrao.ObtenhaTransmissao();
                    var qualidadePadrao = fabricaPlanoPadrao.ObtenhaConteudoQualidade();
                    return new Assinatura(precoPadrao, tramissoesPadrao, qualidadePadrao);
                case EnumPlano.Premium:
                    IFabricaAbstrataPlano fabricaPlanoPremium = new FabricaDePlanoPremium();
                    var precoPremium = fabricaPlanoPremium.ObtenhaPreco();
                    var tramissoesPremium = fabricaPlanoPremium.ObtenhaTransmissao();
                    var qualidadePremium = fabricaPlanoPremium.ObtenhaConteudoQualidade();
                    return new Assinatura(precoPremium, tramissoesPremium, qualidadePremium);
                default:
                    return null;
            }
        }
    }
}
