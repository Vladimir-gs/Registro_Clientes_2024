using Microsoft.EntityFrameworkCore;
using Registro_Clientes_2024.Models;

namespace Registro_Clientes_2024.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options) { }

    }
}
