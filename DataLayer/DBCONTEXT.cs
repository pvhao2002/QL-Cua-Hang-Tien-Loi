using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataLayer
{
    public partial class DBCONTEXT : DbContext
    {
        public DBCONTEXT()
            : base("data source=.;initial catalog=QLCuaHangTienLoi;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<order_item> order_item { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<user_account> user_account { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<order>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<user_account>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user_account>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user_account>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}
