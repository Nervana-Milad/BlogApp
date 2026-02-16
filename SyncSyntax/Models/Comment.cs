using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The User Name is require")]
        [MaxLength(100, ErrorMessage = "The User Name can not exceed 100 characters")]

        public string UserName { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        // Relationships
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
