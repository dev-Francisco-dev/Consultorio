using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Context
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options) { }

        DbSet<Agendamento> Agendamentos { get; set; }

        // FluenteAPI  Modelbuider.ApplyConfiguration<Cliente>(new ClienteConfiguration());
    }


}
