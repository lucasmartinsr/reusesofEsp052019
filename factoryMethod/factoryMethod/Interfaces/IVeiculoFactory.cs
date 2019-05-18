using factoryMethod.Entidades;
using factoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod.Interfaces
{
    public interface IVeiculoFactory
    {
        Veiculo Create(EnumCondicaoMeteologica condicaoMeterologica, int quantidadeDePessoas, int quantidadeKM);
    }
}
