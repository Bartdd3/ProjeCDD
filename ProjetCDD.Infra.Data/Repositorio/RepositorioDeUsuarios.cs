using ProjetCDD.Domain.Entidades;
using ProjetCDD.Domain.Interface.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCDD.Infra.Data.Repositorio
{
    public class RepositorioDeUsuarios : RepositorioBase<Usuario>, IRepositorioDeUsuarios
    {
        public Usuario LogarUsusario(string email, string senha)
        {
            var usuario = _Contexto.Ususarios.Where(u => u.Email == email).FirstOrDefault();
            if (usuario == null)
            
                return null;

                   }

        public Usuario RecuperarUsuarioPoremail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
