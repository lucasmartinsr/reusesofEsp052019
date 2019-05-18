using System;
using System.Collections.Generic;
using System.Text;
using factoryMethod.Enums;

namespace factoryMethod.Entidades
{
    public class Besta : Veiculo
    {
        public Besta(EnumTipoDeCombustivel tipoDeCombustivel, EnumCategoriaVeiculo categoriaVeiculo) : base(tipoDeCombustivel, categoriaVeiculo)
        {
        }
    }
}
