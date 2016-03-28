using ProjetCDD.Domain.Entidades;
using ProjetCDD.Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCDD.Domain.Interface.Repositorio
{
    public interface IRepositorioDeUsuarios : IRepositorioBase<Usuario>
    {
        Usuario RecuperarUsuarioPoremail(string email);
        Usuario LogarUsusario(string email, string senha);
    }
}
