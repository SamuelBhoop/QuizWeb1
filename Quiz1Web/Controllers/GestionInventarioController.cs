using Microsoft.AspNetCore.Mvc;
using Quiz1Web.Models;

namespace Quiz1Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GestionInventarioController : Controller
    {
        private static List<Libros> libros = new List<Libros>
        {
            new Libros {Id = 123,Nombre = "Cien años de soledad",Autor = "Gabriel Garcia",Precio = 30000, Stock = 3},
            new Libros {Id = 333,Nombre = "El principito",Autor = "desconocido",Precio = 40000, Stock = 4},
            new Libros {Id = 444,Nombre = "El Quijote",Autor = "desconocido",Precio = 35000, Stock = 6},
            new Libros {Id = 888,Nombre = "La vida como pelicula, comedia" +
                ", drama y ficcion",Autor = "Cancerbero",Precio = 50000, Stock = 2},
            new Libros {Id = 999,Nombre = "La metamorfosis",Autor = "Frankl Kafka",Precio = 10000, Stock = 10},

        };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            return "Funciona a punta de fe";
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var Libros = libros.FirstOrDefault(e => e.Id == id);
            if (Libros == null)
            {
                return NotFound("No tenemos el libro");
            }
            return Ok(Libros);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Libros newLibro)
        {

            newLibro.Id = libros.Max(e => e.Id) + 1;
            libros.Add(newLibro);
            return CreatedAtAction(nameof(getById),
                new { id = newLibro.Id }, newLibro);

        }

        //public IActionResult actionResult(int id) { 
           // return 
        //}
    }
}
