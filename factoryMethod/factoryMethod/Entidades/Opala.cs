using System;
using System.Collections.Generic;
using System.Text;
using factoryMethod.Enums;

namespace factoryMethod.Entidades
{
    public class Opala : Veiculo
    {
        public Opala(EnumTipoDeCombustivel tipoDeCombustivel, EnumCategoriaVeiculo categoriaVeiculo) : base(tipoDeCombustivel, categoriaVeiculo)
        {
        }
    }
}
