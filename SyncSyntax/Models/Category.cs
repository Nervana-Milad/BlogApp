using System.ComponentModel.DataAnnotations;

namespace SyncSyntax.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Category Name is require")]
        [MaxLength(100, ErrorMessage = "The Category Name can not exceed 100 characters")]
        public string Name { get; set; }

        public string? Description { get; set; }


        //Relationships
        public ICollection<Post>? Posts { get; set; }
    }
}
