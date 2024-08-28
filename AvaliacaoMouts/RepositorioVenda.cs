using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal class RepositorioVenda : IRepositorio<Venda, long>
    {
        public bool Alterar(long id, Venda item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venda> Consultar()
        {
            throw new NotImplementedException();
        }

        public Venda Consultar(long item)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Venda item)
        {
            throw new NotImplementedException();
        }

        public Venda Salvar(Venda item)
        {
            throw new NotImplementedException();
        }
    }
}
