using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader
{
    class ContaCorrente
    {
      
            public int Agencia { get; set; }
            public int Numero { get; set; }
            public double Saldo { get; set; }
            public string Nome { get; set; }

            public ContaCorrente(int agencia, int numero, double saldo, string nome)
            {
                Agencia = agencia;
                Numero = numero;
                Saldo = saldo;
                Nome = nome;
                
            }

    }
}
