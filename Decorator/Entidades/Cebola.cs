using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Entidades
{
    public class Cebola : Adicional
    {
        private const double valor = 1.00;
        private readonly Prato _pratoDecorado;
        public Cebola(Prato pratoDecorado) : base(pratoDecorado)
        {
            _pratoDecorado = pratoDecorado;
        }

        public override double GetPreco => valor + _pratoDecorado.GetPreco;
    }
}
