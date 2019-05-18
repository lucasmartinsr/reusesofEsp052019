using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Entidades
{
    public abstract class Adicional: Prato
    {
        protected readonly Prato _prato;
        public Adicional(Prato prato)
        {
            _prato = prato;
        }
    }
}
