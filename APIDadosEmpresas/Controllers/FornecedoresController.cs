using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDadosEmpresas.Context;
using APIDadosEmpresas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIDadosEmpresas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        // GET: api/Fornecedores
        private readonly AppDBContext _context;
        public FornecedoresController(AppDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Fornecedor>> GetFornecedor()
        {
            return _context.Fornecedores.ToList();
        }

        // GET: api/Fornecedores/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Fornecedor> GetFornecedorId(int id)
        {
            var fornecedorId = _context.Fornecedores.FirstOrDefault(f=> f.FornecedorId == id);
            if (fornecedorId == null)
            {
                return NotFound();
            }
            return fornecedorId;
        }

        // POST: api/Fornecedores
        [HttpPost]
        public void Post([FromBody] Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            _context.SaveChanges();
        }

        // PUT: api/Fornecedores/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Fornecedor fornecedor)
        {
            if (id != fornecedor.FornecedorId)
            {
                return BadRequest();
            }
            _context.Entry(fornecedor).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Fornecedor> Delete(int id)
        {
            var fornecedorId = _context.Fornecedores.FirstOrDefault(f => f.FornecedorId == id);
            if (fornecedorId == null)
            {
                return NotFound();
            }
            _context.Fornecedores.Remove(fornecedorId);
            _context.SaveChanges();
            return fornecedorId;
        }
    }
}
