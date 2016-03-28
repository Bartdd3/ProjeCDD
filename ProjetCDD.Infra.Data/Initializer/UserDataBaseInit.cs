using ProjetCDD.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCDD.Infra.Data.Initializer
{
    public class UserDataBaseInit
    {
        public static List<ModulosDeAcesso> GetModulosDeAcesso()
        {

            var modulos = new List<ModulosDeAcesso>
            {

                new ModulosDeAcesso
                {
                    IdModulo = 1,
                    Ativo =  true,
                    NomeMenuAcesso = "Adminstração",
                    NomeModulo = "Admin",
                    UrlMenu="#",
                    DataCadastro = DateTime.Now
                },
                 new ModulosDeAcesso
                {
                    IdModulo = 2,
                    Ativo =  true,
                    NomeMenuAcesso = "Cadastro",
                    NomeModulo = "Admin",
                    UrlMenu="#",
                    IdModuloPai = 1,
                    DataCadastro = DateTime.Now
                },
                  new ModulosDeAcesso
                {
                    IdModulo = 3,
                    Ativo =  true,
                    NomeMenuAcesso = "Perfil de ususário",
                    NomeModulo = "Admin",
                    UrlMenu="#",
                    IdModuloPai = 2,
                    DataCadastro = DateTime.Now
                }

            };
            return modulos;
        }

        public static List<PerfilUsuario> GetPerfilUsusario()
        {

            var perfilUsuario = new List<PerfilUsuario>
            {
                new PerfilUsuario
                {
                    IdPerfilUsuario = 1,
                    Datacriacao = DateTime.Now,
                    FlAdminMaster = true,
                    NomePerfil = "Adminisrtador Master",
                    ModulosDeAcesso = GetModulosDeAcesso(),
                    
                }

            };
            return perfilUsuario;
        }
    }
}
