using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal class Cliente : Pessoa
    {
        public string CpfCnpj { get; set; }
        public int PontosFidelidade { get; set; }

        public Cliente(long id, string nome, string endereco, string cpfcnpj) : base(id, nome, endereco, cpfcnpj)
        {
            PontosFidelidade = 0;
        }

        public override bool validarIdentidade()
        {
            if (CpfCnpj.Length == 14)
            {
                return CpfCnpj.Length == 14;
            } else if (CpfCnpj.Length == 11)
            {
                return CpfCnpj.Length == 11;
            } else
            {
                return false;
            }
        }

        // Caso for informado o nome, deve ser chamado a função AdicionaPontos
        public void AdicionaPontosFidelidade(int pontos)
        {
            PontosFidelidade += pontos;
            Console.WriteLine($"Pontos de fidelidade: {PontosFidelidade}");
        }
    }
}
