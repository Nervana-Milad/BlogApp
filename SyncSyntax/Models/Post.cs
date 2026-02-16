using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="The Title is require")]
        [MaxLength(400, ErrorMessage ="The Title can not exceed 400 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Content is require")]
        public string Content { get; set; }

        [Required(ErrorMessage = "The Author is require")]
        [MaxLength(100, ErrorMessage = "The Author can not exceed 100 characters")]
        public string Author { get; set; }
        [ValidateNever]
        public string FeatureImagePath { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        // Relationships
        [ForeignKey("Category")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        public ICollection<Comment>? Comments { get; set; } 

    }
}
