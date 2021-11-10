//Kauê de Jesus Livio CB3005461
//Pedro Paulo dos Reis Faria CB3007278

using System;
using System.Collections.Generic;
using System.Text;

namespace Trab2
{
    class Contato
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Profissao { get; set; }

        public string Pais { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
