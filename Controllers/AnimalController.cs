using System.Linq;
using AngServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngServices.Controllers
{
    [Route("api/animal")]
    public class AnimalController : Controller
    {
        [HttpGet]
        public ActionResult<dynamic> Get([FromServices] DataContext context)
        {
            return context.Animal.ToList();
        }

        [HttpPost]
        public ActionResult<dynamic> Create([FromServices] DataContext context, [FromBody] Animal animal)
        {
            context.Animal.Add(animal);
            context.SaveChanges();
            return animal;
        }

        [HttpPut]
        public ActionResult<dynamic> Update([FromServices] DataContext context, [FromBody] Animal animal)
        {
            context.Entry(animal).State = EntityState.Modified;
            context.SaveChanges();
            return animal;
        }

        [HttpDelete("{id}")]
        public ActionResult<dynamic> Delete([FromServices] DataContext context, int id)
        {
            var animal = context.Animal.FirstOrDefault(x => x.Id == id);
            context.Animal.Remove(animal);
            context.SaveChanges();
            return new
            {
                message = "Deletado"
            };
        }
    }
}