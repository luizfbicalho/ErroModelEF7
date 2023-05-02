using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Configuracao;

namespace Model.Models
{
	public class ModelContext : IdentityDbContext<Identidade, Perfil, int>
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
            Database.SetCommandTimeout(TimeSpan.FromMinutes(5));
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Autorizacao>().HasDiscriminator();


            builder.Entity<Perfil>().ToTable("CFGPerfil");
            builder.Entity<Identidade>().ToTable("CFGIdentidade");

            builder.Entity<Perfil>().HasMany(t => t.Autorizacoes).WithMany()
                .UsingEntity<ManyToManyEntidadeAudit<Autorizacao, Perfil>>(
                    j => j.HasOne<Autorizacao>(a => a.Left).WithMany().HasForeignKey("AutorizacaoId").OnDelete(DeleteBehavior.Cascade),
                    j => j.HasOne<Perfil>(a => a.Right).WithMany().HasForeignKey("PerfilId").OnDelete(DeleteBehavior.Cascade),
                    x => x.ToTable("CFGPerfilAutorizacao"));
        }

        public DbSet<Empreendimento> Empreendimento { get; set; }
        public DbSet<Autorizacao> Autorizacao { get => Set<Autorizacao>(); }
        public DbSet<Praca> Praca { get; set; }
     
    }

    public class ManyToManyEntidadeAudit<TLeft, TRight> where TLeft : class
    where TRight : class
    {

        public virtual TLeft Left { get; set; } = null!;
        public virtual TRight Right { get; set; } = null!;

    }
}
