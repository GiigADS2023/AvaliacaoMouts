using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    abstract class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CpfCnpj { get; set; }

        public abstract bool validarIdentidade();

        public Pessoa(long id, string nome, string endereco, string cpfcnpj)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            CpfCnpj = cpfcnpj;
        }
    }
}
