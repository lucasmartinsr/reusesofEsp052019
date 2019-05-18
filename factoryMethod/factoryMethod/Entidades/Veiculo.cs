using factoryMethod.Enums;

namespace factoryMethod.Entidades
{
    public abstract class Veiculo
    {
        public EnumTipoDeCombustivel TipoDeCombustivel { get;private set;}

        public EnumCategoriaVeiculo CategoriaVeiculo { get;private set;}

        public Veiculo(EnumTipoDeCombustivel tipoDeCombustivel, EnumCategoriaVeiculo categoriaVeiculo)
        {
            TipoDeCombustivel = tipoDeCombustivel;
            CategoriaVeiculo = categoriaVeiculo;
        }
    }
}
