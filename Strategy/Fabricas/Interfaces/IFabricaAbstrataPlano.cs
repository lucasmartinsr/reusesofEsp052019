using Strategy.Entidades.Conteudo;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Fabricas.Interfaces
{
    public interface IFabricaAbstrataPlano
    {
        IPreco ObtenhaPreco();
        IContentTransformer ObtenhaConteudoQualidade();
        IPreparadorNumeroTransmissoes ObtenhaTransmissao();
    }
}
