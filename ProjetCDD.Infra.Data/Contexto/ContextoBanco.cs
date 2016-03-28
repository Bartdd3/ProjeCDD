using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using ProjetCDD.Domain.Entidades;
using ProjetCDD.Infra.Data.Configuration;

namespace ProjetCDD.Infra.Data.Contexto
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco():base("ProjetCDD")
        {
                    
        }

        public DbSet<Usuario> Ususarios { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<ModulosDeAcesso> ModulosDeAcessos { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name+"Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar")); 
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(150));
            modelBuilder.Properties<string>().Where(p => p.Name.Contains("Descricao")).Configure(p => p.HasMaxLength(450));
            modelBuilder.Properties<string>().Where(p => p.Name.Contains("UF")).Configure(p => p.HasMaxLength(2));

            modelBuilder.Configurations.Add(new ModulosDeAcessoMap());
            modelBuilder.Configurations.Add(new ModulosDeAcessoMap.PerfilUsuarioMap());
            modelBuilder.Configurations.Add(new ModulosDeAcessoMap.UsuarioMap());
        }
    }
}
