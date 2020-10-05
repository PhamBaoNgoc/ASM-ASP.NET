namespace ASM.ASP.NET.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ASM.ASP.NET.Models;

    public partial class SolutionEntitiesDbContext : DbContext
    {
        public SolutionEntitiesDbContext()
            : base("name=SolutionEntitiesDbContext")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.ContactName)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.ContactNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.GroupName)
                .IsUnicode(false);
        }
    }
}
