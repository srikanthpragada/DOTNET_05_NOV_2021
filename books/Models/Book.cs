using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace books.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Author")]
        public string Author { get; set; }

        [Column("NoPages")]
        public int NoPages { get; set; }

        [Column("Rating")]
        public int Rating { get; set; }

    }
}