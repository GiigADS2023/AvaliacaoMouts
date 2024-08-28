using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal class ReposiorioCliente : IRepositorio<Cliente, long>
    {
        private List<Cliente> _cliente = new List<Cliente>();
        public bool Alterar(long id, Cliente item)
        {
            foreach (Cliente cli in _cliente)
            {
                if (cli.Id == id)
                {
                    cli.Nome = item.Nome;
                    cli.Endereco = item.Endereco;
                    cli.CpfCnpj = item.CpfCnpj;
                    cli.PontosFidelidade = item.PontosFidelidade;
                    break;
                }
            }
            return true;
        }

        public IEnumerable<Cliente> Consultar()
        {
            return _cliente;
        }

        public Cliente Consultar(long item)
        {
            Cliente cliente = null;
            foreach (Cliente cli in _cliente)
            {
                if (cli.Id == item)
                {
                    cliente = cli;
                    return cli;
                    break;
                }
            }

            throw new KeyNotFoundException($"Cliente:  {item} não encontrado.");
        }

        public void Excluir(Cliente item)
        {
            Cliente cliente = _cliente.Find(x => x.Equals(item));
            if (cliente != null)
            {
                _cliente.Remove(cliente);
            }
            else
            {
                throw new ArgumentException("Cliente não encontrada");
            }
        }

        public Cliente Salvar(Cliente item)
        {
            _cliente.Add(item);
            return item;
        }
    }
}
