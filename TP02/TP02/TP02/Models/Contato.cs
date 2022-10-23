using System;
using System.Collections.Generic;
using System.Text;

namespace TP02.Models
{
    class Contato
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Profissao { get; set; }

        public string Pais { get; set; }

        public Contato(string nome, int idade, string profissao, string pais)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;
            Pais = pais;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
