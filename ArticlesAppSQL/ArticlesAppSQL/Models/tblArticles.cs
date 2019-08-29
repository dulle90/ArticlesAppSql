namespace ArticlesAppSQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblArticles
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Categorie { get; set; }

        [StringLength(50)]
        public string Manufacturer { get; set; }

        [StringLength(50)]
        public string Supplier { get; set; }

        [StringLength(50)]
        public string Price { get; set; }
    }
}
