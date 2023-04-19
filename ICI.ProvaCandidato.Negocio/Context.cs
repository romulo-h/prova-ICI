using ICI.ProvaCandidato.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace ICI.ProvaCandidato.Negocio
{
	public class Context : DbContext
	{
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
        : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
		public DbSet<Noticia> Noticia { get; set; }
		public DbSet<Tag> Tag { get; set; }
		public DbSet<NoticiaTag> NoticiaTag { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
            optionsBuilder.UseSqlServer("Server=DESKTOP-BFJAFTH\\;Database=provaCandidato;Trusted_Connection=True;", b => b.MigrationsAssembly("ICI.ProvaCandidato.Web"));
		}


    }
}
