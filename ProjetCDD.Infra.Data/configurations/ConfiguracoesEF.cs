using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCDD.Domain.Entidades;

namespace ProjetCDD.Infra.Data.Configuration
{
    public class ModulosDeAcessoMap : EntityTypeConfiguration<ModulosDeAcesso>
    {

        public  ModulosDeAcessoMap()
        {
            this.HasKey(p => p.IdModulo);

            this.Property(p =>p.NomeModulo)
                .IsRequired()
                .HasMaxLength(200);

           this.Property(p =>p.NomeMenuAcesso)
                 .IsRequired()
                .HasMaxLength(200);

            this.Property(p => p.UrlMenu)
                 .IsRequired()
                .HasMaxLength(300);

            this.ToTable("ModulosAcesso", "dbo");
            this.HasMany(p => p.PerfilUsuarios)
                .WithMany(p => p.ModulosDeAcesso)
                .Map(p =>
                {
                    p.ToTable("PerfilUsuario", "dbo");
                    p.MapLeftKey("IdModulo");
                    p.MapRightKey("IdPerfilUsuario");


                }

                );
        }
        public class PerfilUsuarioMap : EntityTypeConfiguration<PerfilUsuario>
        {
            public PerfilUsuarioMap()
            {
                this.HasKey(p => p.IdPerfilUsuario);

                this.Property(p =>p.NomePerfil)
                    .IsRequired()                    
                     .HasMaxLength(200);

                this.ToTable("PerfilUsuario", "dbo");

            }    
        }

        public class UsuarioMap : EntityTypeConfiguration<Usuario>
        {
            public UsuarioMap()
            {
                this.HasKey(p => p.IdUsuario);

                this.Property(p => p.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_loginname",1) {IsUnique = true}));
                this.Property(p => p.Senha)
                    .IsRequired()
                    .HasMaxLength(2048);
                this.Property(p => p.DataCadastro).HasColumnType("datetime2");

                this.HasRequired(p => p.PerfilUsuarios)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(p => p.IdPerfilUsuario);



            }
        }
    }
}
