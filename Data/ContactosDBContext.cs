using GestorDeContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorDeContactos.Data
{
    public class ContactosDBContext : DbContext
    {
        public ContactosDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; }

    }
}