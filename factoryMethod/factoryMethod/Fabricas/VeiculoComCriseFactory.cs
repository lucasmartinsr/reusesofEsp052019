using factoryMethod.Entidades;
using factoryMethod.Enums;
using factoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod.Fabricas
{
    public class VeiculoComCriseFactory : IVeiculoFactory
    {
        public Veiculo Crie(EnumCondicaoMeteologica condicaoMeterologica, int quantidadeDePessoas,EnumTipoDeCombustivel tipoDeCombustivel, int quantidadeKM)
        {
            throw new NotImplementedException();
        }
    }
}
