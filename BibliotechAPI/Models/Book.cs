using System.ComponentModel.DataAnnotations;

namespace BibliotechAPI.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Title { get; set; }
    [Required]
    [StringLength(100)]
    public string Description { get; set; }
    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }
}
