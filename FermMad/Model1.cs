using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FermMad
{
    public partial class Model1 : DbContext
    {
        public DbSet<Ferm> Ferms { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Player> Player_Progress { get; set; }
        public Model1()
            : base("name=Model1")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
