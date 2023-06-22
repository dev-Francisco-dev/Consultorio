using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Context
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options) { }

        DbSet<Agendamento> Agendamentos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
       
    }


}
