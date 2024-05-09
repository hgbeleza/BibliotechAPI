using System.ComponentModel.DataAnnotations;

namespace BibliotechAPI.Models;

public class CreateAuthorDto
{
    [Required]
    [StringLength(100)]
    public string AuthorName { get; set; }
}
