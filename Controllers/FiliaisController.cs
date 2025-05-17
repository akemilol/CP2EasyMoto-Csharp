using Microsoft.AspNetCore.Mvc;
using EasyMoto.Infrastructure.Context;
using EasyMoto.Domain.Entities;
using AutoMapper;
using EasyMoto.Application.DTOs.Request;
using EasyMoto.Application.DTOs.Response;

namespace EasyMoto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FiliaisController : ControllerBase
    {
        private readonly EasyMotoDbContext _context;
        private readonly IMapper _mapper;

        public FiliaisController(EasyMotoDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var filiais = _context.Filiais.ToList();
            var response = _mapper.Map<List<CreatedFilialResponse>>(filiais);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var filial = _context.Filiais.FirstOrDefault(f => f.Id == id);
            if (filial == null) return NotFound();
            var response = _mapper.Map<CreatedFilialResponse>(filial);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateFilialRequest dto)
        {
            var filial = new Filial { Nome = dto.Nome };
            _context.Filiais.Add(filial);
            _context.SaveChanges();
            var response = _mapper.Map<CreatedFilialResponse>(filial);
            return CreatedAtAction(nameof(GetById), new { id = filial.Id }, response);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CreateFilialRequest dto)
        {
            var filial = _context.Filiais.FirstOrDefault(f => f.Id == id);
            if (filial == null) return NotFound();
            filial.Nome = dto.Nome;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var filial = _context.Filiais.FirstOrDefault(f => f.Id == id);
            if (filial == null) return NotFound();
            _context.Filiais.Remove(filial);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
