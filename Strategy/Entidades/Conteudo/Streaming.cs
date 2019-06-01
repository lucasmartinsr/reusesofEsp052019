using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entidades.Conteudo
{
    public class Streaming
    {
        public string Tipo { get; set; }

        public Streaming(string tipo)
        {
            Tipo = tipo;
        }
    }
}
