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
        [Required]
        public string Title { get; set; }

        [Column("Author")]
        [Required]
        public string Author { get; set; }

        [Column("NoPages")]
        [Range(1, 2000, ErrorMessage = "Invalid number for No. of pages")]
        public int NoPages { get; set; }

        [Column("Rating")]
        [Range(1,5,ErrorMessage ="Valid rating is 1 to 5")]
        public int Rating { get; set; }

    }
}