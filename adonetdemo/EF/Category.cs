using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace adonetdemo.EF
{
    [Table("categories")]
    public class Category
    {
        [Column("CatCode")]
        [Key]
        public string Code { get; set; }

        [Column("CatDesc")]
        public string Description { get; set; }
    }
}