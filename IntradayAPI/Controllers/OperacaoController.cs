using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IntradayAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : ControllerBase
    {
        private readonly DataContext _context;

        public OperacaoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Operacao>> GetAll()
        {
            return _context.Operacao.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Operacao> GetById(int id)
        {
            return _context.Operacao.Find(id);
        }

        [HttpPost]
        public ActionResult<Operacao> Create([FromBody] Operacao operacao)
        {
            _context.Operacao.Add(operacao);
            _context.SaveChanges();
            return operacao;
        }

        [HttpPut]
        public ActionResult<Operacao> Update([FromBody] Operacao operacao)
        {
            _context.Entry(operacao).State = EntityState.Modified;
            _context.SaveChanges();
            return operacao;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Operacao operacao = _context.Operacao.Find(id);
            _context.Operacao.Remove(operacao);
            _context.SaveChanges();
        }
    }
}