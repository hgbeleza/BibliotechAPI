using AutoMapper;
using BibliotechAPI.Data;
using BibliotechAPI.Data.Dto;
using BibliotechAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotechAPI.Controllers;

[Controller]
[Route("book/api")]
public class BookController: ControllerBase
{
    private readonly BibliotechContext _context;
    private IMapper _mapper;

    public BookController(BibliotechContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateBookDto bookDto)
    {
        var book = _mapper.Map<Book>(bookDto);
        _context.Add(book);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Create), new { id = book.Id }, book);
    }

    [HttpGet]
    public IEnumerable<Book> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 15)
    {
        return _context.Books.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetById(int id)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound();
        return book;
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] UpdateBookDto bookDto)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound();
        _mapper.Map(bookDto, book);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id) 
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == id);
        if (book != null) 
        {
            _context.Remove(book);
            _context.SaveChanges();
            return NoContent();
        }
        return NotFound();
    }
}
