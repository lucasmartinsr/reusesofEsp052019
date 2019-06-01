using Strategy.Interfaces;

namespace Strategy.Entidades.Conteudo
{
    public class HD : IContentTransformer
    {
        public Streaming ConvertaQualidade()
        {
            return new Streaming("HD");
        }
    }
}
