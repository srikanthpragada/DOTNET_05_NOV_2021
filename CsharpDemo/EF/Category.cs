using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsharpDemo.EF
{
    [Table("categories")]
    class Category
    {
        [Column("CatCode")]
        [Key]
        public string Code { get; set; }

        [Column("CatDesc")]
        public string Description { get; set; }
    }
}
