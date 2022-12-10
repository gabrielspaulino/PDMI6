using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TPFinal.Models
{
    public class Mercadoria
    {
        [PrimaryKey, AutoIncrement]
        public string Ncm { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public string NomeProdutor { get; set; }
        public string EmailProdutor { get; set; }
    }
}
