using MVCBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCBlog.Models.ORM.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-MGSPLLO;Database=OnlineBlog; UID=sqldev; PWD=Armagedon001; ";
        }

        // AdminUser clasını AdminUsers yapar o nedenle bu method eklendi.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SiteMenu> SiteMenus { get; set; }
    }
}