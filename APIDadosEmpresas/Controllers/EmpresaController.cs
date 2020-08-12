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
    public class EmpresaController : ControllerBase
    {
        private readonly AppDBContext _context;
        public EmpresaController(AppDBContext context)
        {
            _context = context;
        }
        // GET: api/Empresa
        [HttpGet]
        public ActionResult <IEnumerable<Empresa>> GetEmpresa()
        {
            return _context.Empresas.ToList();
        }

        // GET: api/Empresa/5
        [HttpGet("{id}", Name = "GetEmpresa")]
        public ActionResult<Empresa> GetEmpresaId(int id)
        {
            var empresaId = _context.Empresas.FirstOrDefault(e => e.EmpresaId == id);
            if(empresaId == null)
            {
                return NotFound();
            }

            return empresaId;
        }

        // POST: api/Empresa
        [HttpPost]
        public void Post([FromBody] Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        // PUT: api/Empresa/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Empresa empresa)
        {
            if(id != empresa.EmpresaId)
            {
                return BadRequest();
            }
            _context.Entry(empresa).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Empresa> Delete(int id)
        {
            var empresaId = _context.Empresas.FirstOrDefault(e => e.EmpresaId == id);
            if (empresaId == null)
            {
                return NotFound();
            }
            _context.Empresas.Remove(empresaId);
            _context.SaveChanges();
            return empresaId;
        }
    }
}
