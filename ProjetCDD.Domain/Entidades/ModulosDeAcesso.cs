using System;
using System.Collections.Generic;



namespace ProjetCDD.Domain.Entidades
{
    public partial class ModulosDeAcesso
    {
        public ModulosDeAcesso()
        {
            this.PerfilUsuarios = new List<PerfilUsuario>();
        }
        
        public int IdModulo { get; set; }
        public string NomeModulo { get; set; }
        public string NomeMenuAcesso { get; set; }
        public string UrlMenu { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        // inicio um auto relaconamento de menus abaixo
        public int? IdModuloPai  { get; set; }

        public virtual ModulosDeAcesso ModulosDeAcessos { get; set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuarios { get; set; }




    }
}