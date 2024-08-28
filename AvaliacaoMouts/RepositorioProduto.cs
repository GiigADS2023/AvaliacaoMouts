using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal class RepositorioProduto : IRepositorio<Produto, long>
    {
        public bool Alterar(long id, Produto item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> Consultar()
        {
            throw new NotImplementedException();
        }

        public Produto Consultar(long item)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Produto item)
        {
            throw new NotImplementedException();
        }

        public Produto Salvar(Produto item)
        {
            throw new NotImplementedException();
        }
    }
}
