using System.ComponentModel.DataAnnotations;

namespace BibliotechAPI.Models;

public class UpdateAuthorDto
{
    [Required]
    [StringLength(100)]
    public string AuthorName { get; set; }
}
