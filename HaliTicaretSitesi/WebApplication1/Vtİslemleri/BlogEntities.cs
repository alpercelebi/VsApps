using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Vtİslemleri
{
    public class BlogEntities:DbContext
    {
        public BlogEntities()
            :base("BlogEntities")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<OrderPost> OrderPost { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin", "dbo");
            modelBuilder.Entity<User>().ToTable("User", "dbo");
            modelBuilder.Entity<Post>().ToTable("Post", "dbo");
            modelBuilder.Entity<OrderPost>().ToTable("OrderPost", "dbo");
            base.OnModelCreating(modelBuilder);
        }
    }
}