using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal interface IRepositorio<T, t>
    {
        T Salvar(T item);
        bool Alterar(t id, T item);
        void Excluir(T item);
        IEnumerable<T> Consultar();
        T Consultar(t item);
    }
}
