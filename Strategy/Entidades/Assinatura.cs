using Strategy.Entidades.Conteudo;
using Strategy.Interfaces;
using System;

namespace Strategy.Entidades
{
    public class Assinatura
    {
        private readonly IPreco _preco;
        private readonly IPreparadorNumeroTransmissoes _preparadorNumeroTransmissoes;
        private readonly IContentTransformer _contentTransformer;

        public Assinatura(IPreco preco, IPreparadorNumeroTransmissoes preparadorNumeroTransmissoes, 
            IContentTransformer contentTransformer)
        {
            _preco =  preco;
            _preparadorNumeroTransmissoes = preparadorNumeroTransmissoes;
            _contentTransformer = contentTransformer;
        }

        public double ObtenhaPreco()
        {
            return _preco.Calcule();
        }

        public Streaming DisponibilizeConteudo()
        {
            return _contentTransformer.ConvertaQualidade();
        }

        public void PermitirNumeroTransmissoesSimultaneas()
        {
            var numeroTransmissao = _preparadorNumeroTransmissoes.PrepareAmbienteParaTransmissoesSimultaneas();
            Console.WriteLine($"Ambiente preparado para {numeroTransmissao} transmissao");
        }

    }
}
