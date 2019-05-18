using factoryMethod.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod.Interfaces
{
    public interface IVeiculoComCriseFactory: IVeiculoFactory
    {
        Veiculo Crie(Enum tipoDeCombustivel);
    }
}
