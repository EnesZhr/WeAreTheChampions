using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsData.Models
{
    public class WeAreTheChamphionsDbContext: DbContext
    {
        public WeAreTheChamphionsDbContext():base ("name=WeAreTheChampionsConnection")
        {
            
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasRequired(c => c.HomeTeam).WithMany(t=> t.HomeMatches).HasForeignKey(x=>x.HomeTeamId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Match>()
                .HasRequired(c => c.AwayTeam).WithMany(t => t.AwayMatches).HasForeignKey(x => x.AwayTeamId).WillCascadeOnDelete(false);
        }
    }
}
