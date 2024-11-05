using Microsoft.EntityFrameworkCore;
using Origen2024.BD.DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origen2024.BD.DATA
{
    public class Context : DbContext
    {
        public DbSet<CDocumento> CDocumentos { get; set; }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Registro> Registros { get; set; }

        public DbSet<Cita> Citas { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                         .SelectMany(t => t.GetForeignKeys())
                                         .Where(fk => !fk.IsOwnership
                                                      && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }



            base.OnModelCreating(modelBuilder);
        }
    }

}
