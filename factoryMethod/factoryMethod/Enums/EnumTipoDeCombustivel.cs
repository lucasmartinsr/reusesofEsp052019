using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace factoryMethod.Enums
{
    public enum EnumTipoDeCombustivel
    {
        [Description("Diesel")]
        Diesel,
        [Description("Gasolina")]
        Gasolina,
        [Description("Eletricidade")]
        Eletricidade,
        [Description("Alcool")]
        Alcool,
        [Description("Flex")]
        Flex
    }
}
