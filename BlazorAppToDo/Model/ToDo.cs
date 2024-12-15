using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppToDo.Model
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [Column("task")]
        [MaxLength(255)]
        public string Task { get; set; } = string.Empty;

        [Column("description")]
        [MaxLength(255)]
        public string? Description { get; set; }

        [Column("is_completed")]
        public bool IsCompleted { get; set; } = false;

        [Column("created_at")] 
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
