using System.Data.Entity;
using pse1.Models;

namespace pse1.Contextos
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}