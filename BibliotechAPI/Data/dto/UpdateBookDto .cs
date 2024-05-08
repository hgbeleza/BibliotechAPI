using System.ComponentModel.DataAnnotations;

namespace BibliotechAPI.Data.Dto;

public class UpdateBookDto
{
    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [Required]
    [StringLength(100)]
    public string Description { get; set; }
}