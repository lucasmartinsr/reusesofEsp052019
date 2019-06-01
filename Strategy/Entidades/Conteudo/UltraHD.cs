using Strategy.Entidades.Conteudo;
using Strategy.Interfaces;
using System;

namespace Strategy.Entidades.Conteudo
{
    public class UltraHD : IContentTransformer
    {
        public Streaming ConvertaQualidade()
        {
            return new Streaming("Ultra HD");
        }
    }
}
