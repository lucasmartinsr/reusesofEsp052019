using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Interfaces
{
    public interface IFabricaDeConteudo
    {
        IContentTransformer Crie(IPlano plano);
    }
}
