using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Context
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options) { }

        DbSet<Consulta> _Consultas { get; set; }
        DbSet<Especialidade> Especialidades { get; set; }
        DbSet<Paciente> Pacientes { get; set; }
        DbSet<Profissional> Profissionais { get; set; }
        DbSet<ProfissionalEspecialidade> profissionalEspecialidades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }


}
