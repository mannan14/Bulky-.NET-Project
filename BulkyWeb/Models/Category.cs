using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key] //Makes Id the primary key, even if not used fields like Id/CategoryId are automatically set as PRIMARY KEY
        public int Id { get; set; }
        [Required] //Makes the field "Name" NOT NULL in the data base.
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage="Display order must be between 1-100")]
        public int DisplayOrder { get; set; } 
    }
}
