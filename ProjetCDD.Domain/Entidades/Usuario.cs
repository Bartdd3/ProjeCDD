using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCDD.Domain.Entidades
{
    public partial  class Usuario
    {
        public int IdUsuario  { get; set; }
        public int IdPerfilUsuario { get; set; }

        public string Email  { get; set; }

        public string Senha  { get; set; }
        public string senhakey { get; set; }

        public DateTime DataCadastro { get; set; }

        public virtual PerfilUsuario PerfilUsuarios { get; set; }

        

       
    }
}
