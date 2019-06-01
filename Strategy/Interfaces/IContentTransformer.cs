using Strategy.Entidades.Conteudo;

namespace Strategy.Interfaces
{
    public interface IContentTransformer
    {
        Streaming ConvertaQualidade();
    }
}
