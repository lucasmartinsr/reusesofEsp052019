using Strategy.Entidades;
using Strategy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Fabricas.Interfaces
{
    public interface IFabricaDeAssinatura
    {
        Assinatura Crie(EnumPlano plano);
    }
}
