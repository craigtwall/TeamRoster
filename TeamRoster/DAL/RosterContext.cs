using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TeamRoster.Models;

namespace TeamRoster.DAL
{
    public class RosterContext : DbContext
    {
        public RosterContext() : base("RosterContext")
        {

        }

        // This DbContext is for the models that are part 
        // of TeamRoster, not ContosoUniversity

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}