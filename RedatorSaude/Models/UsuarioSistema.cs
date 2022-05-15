using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedatorSaude.Models
{
    public class UsuarioSistema
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PecaCriada { get; set; }
        public DateTime DataCriada { get; set; }
    }
}
