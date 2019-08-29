namespace ArticlesAppSQL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Article : DbContext
    {
        public Article()
            : base("name=Article")
        {
        }

        public virtual DbSet<tblArticles> tblArticles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
