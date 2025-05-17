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
    public class MotosController : ControllerBase
    {
        private readonly EasyMotoDbContext _context;
        private readonly IMapper _mapper;

        public MotosController(EasyMotoDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var motos = _context.Motos.ToList();
            var response = _mapper.Map<List<CreatedMotoResponse>>(motos);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var moto = _context.Motos.FirstOrDefault(m => m.Id == id);
            if (moto == null) return NotFound();
            var response = _mapper.Map<CreatedMotoResponse>(moto);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateMotoRequest dto)
        {
            var moto = new Moto
            {
                Modelo = dto.Modelo,
                Placa = dto.Placa,
                Status = dto.Status,
                FilialId = dto.FilialId
            };
            _context.Motos.Add(moto);
            _context.SaveChanges();
            var response = _mapper.Map<CreatedMotoResponse>(moto);
            return CreatedAtAction(nameof(GetById), new { id = moto.Id }, response);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CreateMotoRequest dto)
        {
            var moto = _context.Motos.FirstOrDefault(m => m.Id == id);
            if (moto == null) return NotFound();

            moto.Modelo = dto.Modelo;
            moto.Placa = dto.Placa;
            moto.Status = dto.Status;
            moto.FilialId = dto.FilialId;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var moto = _context.Motos.FirstOrDefault(m => m.Id == id);
            if (moto == null) return NotFound();

            _context.Motos.Remove(moto);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
