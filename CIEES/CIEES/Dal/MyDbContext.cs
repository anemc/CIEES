using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CIEES.Models;

namespace CIEES.Dal
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MySQLMoviesConnection")
        {
            this.Configuration.ValidateOnSaveEnabled = false;
            Database.SetInitializer<MyDbContext>(new MyDbInitializer());
        }

        static MyDbContext()
        {
            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<Dates> Dates{ get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<Pdfs> Pdfs { get; set; }
        public DbSet<T111> T111 { get; set; }
        public DbSet<T112> T112 { get; set; }
        public DbSet<T113> T113 { get; set; }
        public DbSet<T114> T114 { get; set; }
        public DbSet<T115> T115 { get; set; }
        public DbSet<T121> T121 { get; set; }
        public DbSet<T122> T122 { get; set; }
        public DbSet<T123> T123 { get; set; }
        public DbSet<T124> T124 { get; set; }
        public DbSet<T125> T125 { get; set; }
        public DbSet<T126> T126 { get; set; }
        public DbSet<T127> T127 { get; set; }
        public DbSet<T231> T231 { get; set; }
        public DbSet<T232> T232 { get; set; }
        public DbSet<T233> T233 { get; set; }
        public DbSet<T234> T234 { get; set; }
        public DbSet<T235> T235 { get; set; }
        public DbSet<T241> T241 { get; set; }
        public DbSet<T242> T242 { get; set; }
        public DbSet<T243> T243 { get; set; }
        public DbSet<T351> T351 { get; set; }
        public DbSet<T352> T352 { get; set; }
        public DbSet<T353> T353 { get; set; }
        public DbSet<T354> T354 { get; set; }
        public DbSet<T361> T361 { get; set; }
        public DbSet<T362> T362 { get; set; }
        public DbSet<T363> T363 { get; set; }
        public DbSet<T364> T364 { get; set; }
        public DbSet<T365> T365 { get; set; }
        public DbSet<T371> T371 { get; set; }
        public DbSet<T372> T372 { get; set; }
        public DbSet<T373> T373 { get; set; }
        public DbSet<T374> T374 { get; set; }
        public DbSet<T375> T375 { get; set; }
        public DbSet<T381> T381 { get; set; }
        public DbSet<T382> T382 { get; set; }
        public DbSet<T383> T383 { get; set; }
        public DbSet<T384> T384 { get; set; }
        public DbSet<T385> T385 { get; set; }
        public DbSet<T386> T386 { get; set; }
        public DbSet<T4101> T4101 { get; set; }
        public DbSet<T4102> T4102 { get; set; }
        public DbSet<T4103> T4103 { get; set; }
        public DbSet<T4104> T4104 { get; set; }
        public DbSet<T4105> T4105 { get; set; }
        public DbSet<T4106> T4106 { get; set; }
        public DbSet<T4111> T4111 { get; set; }
        public DbSet<T4112> T4112 { get; set; }
        public DbSet<T4113> T4113 { get; set; }
        public DbSet<T4114> T4114 { get; set; }
        public DbSet<T4115> T4115 { get; set; }
        public DbSet<T4116> T4116 { get; set; }
        public DbSet<T4121> T4121 { get; set; }
        public DbSet<T4122> T4122 { get; set; }
        public DbSet<T4123> T4123 { get; set; }
        public DbSet<T4124> T4124 { get; set; }
        public DbSet<T4125> T4125 { get; set; }
        public DbSet<T4126> T4126 { get; set; }
        public DbSet<T491> T491 { get; set; }
        public DbSet<T492> T492 { get; set; }
        public DbSet<T493> T493 { get; set; }
        public DbSet<T494> T494 { get; set; }
        public DbSet<T495> T495 { get; set; }
        public DbSet<T496> T496 { get; set; }
        public DbSet<T497> T497 { get; set; }
        public DbSet<T498> T498 { get; set; }
        public DbSet<T499> T499 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            //modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
        }

    }
}