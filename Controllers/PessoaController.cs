using System;
using System.Linq;
using AngServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngServices.Controllers
{
    [Route("api/pessoa")]
    public class PessoaController : Controller
    {
        [HttpGet]
        public ActionResult<dynamic> Get([FromServices] DataContext context)
        {
            return context.Pessoa.ToList();
        }

        [HttpPost]
        public ActionResult<dynamic> Create([FromServices] DataContext context, [FromBody] Pessoa pessoa)
        {
            context.Pessoa.Add(pessoa);
            context.SaveChanges();
            return pessoa;
        }

        [HttpPut]
        public ActionResult<dynamic> Update([FromServices] DataContext context, [FromBody] Pessoa pessoa)
        {
            context.Entry(pessoa).State = EntityState.Modified;
            context.SaveChanges();
            return pessoa;
        }

        [HttpDelete("{id}")]
        public ActionResult<dynamic> Delete([FromServices] DataContext context, int id)
        {
            var pessoa = context.Pessoa.FirstOrDefault(x => x.Id == id);
            context.Pessoa.Remove(pessoa);
            context.SaveChanges();
            return new
            {
                message = "Deletado"
            };
        }

    }
}