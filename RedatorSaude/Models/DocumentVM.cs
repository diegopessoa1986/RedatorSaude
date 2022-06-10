using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedatorSaude.Models
{
    public class DocumentVM
    {
        public int id { get; set; }
        public string Vara { get; set; }
        public string Foro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string NumeroProcesso { get; set; }
        public string Autor { get; set; }
        public string Reu { get; set; }
        public string DataCriacao { get; set; }
        public string NomePeca { get; set; }
        public string Usuario { get; set; }
    }
}
