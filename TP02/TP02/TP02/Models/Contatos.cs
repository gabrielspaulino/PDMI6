using System;
using System.Collections.Generic;
using System.Text;

namespace TP02.Models
{
    class Contatos
    {
        private List<Contato> contatos;

        public Contatos()
        {
            contatos = new List<Contato>();
        }

        public void adicionar(Contato contato)
        {
            contatos.Add(contato);
        }
    }
}
