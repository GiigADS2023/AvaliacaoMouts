using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal class Cliente : Pessoa
    {
        public string CPFCNPJ { get; set; }
        public int PontoFidelidade { get; set; }

        public Cliente(long id, string nome, string endereco, string cpfcnpj) : base(id, nome, endereco, cpfcnpj)
        {
            PontoFidelidade = 0;
        }
        public override bool validarIdentidade()
        {
            if (CPFCNPJ.Length == 14)
            {
                return CPFCNPJ.Length == 14;
            } else if (CPFCNPJ.Length == 11)
            {
                return CPFCNPJ.Length == 11;
            } else
            {
                return false;
            }
        }
    }
}
