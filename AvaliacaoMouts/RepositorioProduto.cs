using System;
using System.Collections.Generic;

namespace AvaliacaoMouts
{
    internal class RepositorioProduto : IRepositorio<Produto, long>
    {
        private List<Produto> _produtos = new List<Produto>();

        public bool Alterar(long id, Produto item)
        {
            foreach (Produto p in _produtos)
            {
                if (p.Id == id)
                {
                    p.Nome = item.Nome;
                    p.Preco = item.Preco;
                    break;
                }
            }
            return true;
        }

        public IEnumerable<Produto> Consultar()
        {
            return _produtos;
        }

        public Produto Consultar(long id)
        {
            Produto produto = null;
            foreach (Produto p in _produtos)
            {
                if (p.Id == id)
                {
                    produto = p;
                    break;
                }
            }
            return produto;
        }

        public void Excluir(Produto item)
        {
            Produto produto = _produtos.Find(x => x.Equals(item));
            if (produto != null)
            {
                _produtos.Remove(produto);
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }
        }

        public Produto Salvar(Produto item)
        {
            _produtos.Add(item);
            return item;
        }
    }
}