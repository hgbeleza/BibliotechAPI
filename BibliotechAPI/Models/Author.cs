using System.ComponentModel.DataAnnotations;

namespace BibliotechAPI.Models;

public class Author
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string AuthorName { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}
