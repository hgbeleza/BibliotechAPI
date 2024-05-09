using System.ComponentModel.DataAnnotations;

namespace BibliotechAPI.Data.Dto;

public class CreateBookDto
{
    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [Required]
    [StringLength(100)]
    public string Description { get; set; }
    public int AuthorId { get; set; }
}