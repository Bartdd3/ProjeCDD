using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCDD.Domain.Entidades
{
    public partial class PerfilUsuario
    {
        public PerfilUsuario()
        {
            this.Usuarios = new List<Usuario>();
            this.ModulosDeAcesso = new List<ModulosDeAcesso>();
        }
        
        public int IdPerfilUsuario { get; set; }

        public string NomePerfil { get; set; }

        public bool FlAdminMaster {get; set; }
        public bool FlAtivio { get; set; }

        public DateTime Datacriacao { get; set; }

        public virtual ICollection<Usuario>Usuarios  { get; set; }

        public virtual ICollection<ModulosDeAcesso> ModulosDeAcesso { get; set; }
    }
}
