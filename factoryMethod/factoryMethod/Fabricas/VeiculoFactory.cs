using factoryMethod.Entidades;
using factoryMethod.Enums;
using factoryMethod.Interfaces;

namespace factoryMethod.Fabricas
{
    public class VeiculoFactory : IVeiculoFactory
    {
        public Veiculo Crie(EnumCondicaoMeteologica condicaoMeterologica, int quantidadeDePessoas, int distanciaEmKM)
        {
            if(distanciaEmKM <= 500)
            {
                if (quantidadeDePessoas <= 2)
                {
                    return new Tesla(EnumTipoDeCombustivel.Eletricidade,EnumCategoriaVeiculo.Convencional);
                }
                else if (quantidadeDePessoas <= 5 && condicaoMeterologica.Equals(EnumCondicaoMeteologica.Sol))
                {
                    return new Escort(EnumTipoDeCombustivel.Alcool, EnumCategoriaVeiculo.Conversivel);
                }
                else if (quantidadeDePessoas <= 5 && condicaoMeterologica.Equals(EnumCondicaoMeteologica.Chuva))
                {
                    return new Opala(EnumTipoDeCombustivel.Gasolina, EnumCategoriaVeiculo.Convencional);
                }
                else if (quantidadeDePessoas >= 5 && quantidadeDePessoas <= 20)
                {
                    return new Besta(EnumTipoDeCombustivel.Flex, EnumCategoriaVeiculo.Van);
                }
            }

            return null;
        }
    }
}
