using Key_Custodian.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Key_Custodian.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext() : base("Key_Custodian")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Vault> Vaults { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<VaultAccessLog> VaultAccessLogs { get; set; }
        public DbSet<LockerAccess> LockerAccesses { get; set; }
        public DbSet<KeyTransfer> KeyTransfers { get; set; }

        //public DbSet< Incident> Incidents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}