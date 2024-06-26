using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4_API.Context;
using _4_API.Entities;
using Microsoft.AspNetCore.Mvc;
namespace _4_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Método para criar um novo contato
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Contato contato)
        {
            if (contato == null)
            {
                return BadRequest("Contato cannot be null");
            }

            await _context.Contatos.AddAsync(contato);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Create), new { id = contato.Id }, contato);
        }
        [HttpGet("{id}")]
        public IActionResult ObterId(int id){ 
            var contato = _context.Contatos.Find(id);

            if (contato  == null )
            return NotFound();

            return Ok(contato);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato){
            var contatoBanco = _context.Contatos.Find(id);
            if(contatoBanco == null) 
            return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
                var contatoBanco = _context.Contatos.Find(id);
                if(contatoBanco == null) 
                    return NotFound();

                _context.Contatos.Remove(contatoBanco);
                _context.SaveChanges();
                return NoContent();
        }

        // Outros métodos conforme necessário
    }
}