﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal class ReposiorioCliente : IRepositorio<Cliente, long>
    {
        public bool Alterar(long id, Cliente item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Consultar()
        {
            throw new NotImplementedException();
        }

        public Cliente Consultar(long item)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cliente item)
        {
            throw new NotImplementedException();
        }

        public Cliente Salvar(Cliente item)
        {
            throw new NotImplementedException();
        }
    }
}
