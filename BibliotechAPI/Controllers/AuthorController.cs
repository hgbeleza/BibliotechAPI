using AutoMapper;
using BibliotechAPI.Data;
using BibliotechAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotechAPI.Controllers;

[Controller]
[Route("author/api")]
public class AuthorController : ControllerBase
{
    private readonly BibliotechContext _context;
    private IMapper _mapper;

    public AuthorController(BibliotechContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateAuthorDto authorDto)
    {
        var author = _mapper.Map<Author>(authorDto);
        _context.Add(author);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Create), new { id = author.Id }, author);
    }

    [HttpGet]
    public IEnumerable<Author> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 15)
    {
        return _context.Authors.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public ActionResult<Author> GetById(int id)
    {
        var author = _context.Authors.FirstOrDefault(data => data.Id == id);
        if (author == null) return NotFound();
        return author;
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] UpdateAuthorDto authorDto)
    {
        var author = _context.Authors.FirstOrDefault(data => data.Id == id);
        if (author == null) return NotFound();
        _mapper.Map(authorDto, author);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var author = _context.Authors.FirstOrDefault(data => data.Id == id);
        if (author != null)
        {
            _context.Remove(author);
            _context.SaveChanges();
            return NoContent();
        }
        return NotFound();
    }
}