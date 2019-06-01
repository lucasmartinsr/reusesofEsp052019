using Strategy.Interfaces;
using System;

namespace Strategy.Entidades.Conteudo
{
    public class Simples : IContentTransformer
    {
        public Streaming ConvertaQualidade()
        {
            return new Streaming("Simples");
        }
    }
}
