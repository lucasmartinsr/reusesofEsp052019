using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Entidades
{
    public class Ovo : Adicional
    {
        private const double valor = 1.50;
        private readonly Prato _pratoDecorado;
        public Ovo(Prato pratoDecorado) : base(pratoDecorado)
        {
            _pratoDecorado = pratoDecorado;
        }
        public override double GetPreco => valor + _pratoDecorado.GetPreco;
    }
}
