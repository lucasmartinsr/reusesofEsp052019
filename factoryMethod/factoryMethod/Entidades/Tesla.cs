using System;
using System.Collections.Generic;
using System.Text;
using factoryMethod.Enums;

namespace factoryMethod.Entidades
{
    public class Tesla : Veiculo
    {
        public Tesla(EnumTipoDeCombustivel tipoDeCombustivel, EnumCategoriaVeiculo categoriaVeiculo) : base(tipoDeCombustivel, categoriaVeiculo)
        {
        }
    }
}
