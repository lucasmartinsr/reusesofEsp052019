using System;
using System.Collections.Generic;
using System.Text;
using factoryMethod.Enums;

namespace factoryMethod.Entidades
{
    public class Escort : Veiculo
    {
        public Escort(EnumTipoDeCombustivel tipoDeCombustivel, EnumCategoriaVeiculo categoriaVeiculo) : base(tipoDeCombustivel, categoriaVeiculo)
        {
        }
    }
}
