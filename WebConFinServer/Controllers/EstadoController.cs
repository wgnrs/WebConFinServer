using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebConFinServer.Model;

namespace WebConFinServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private static string[] Estados = new string[]
        {
            "São paulo", "Guatemala", "Pirituba"
        };

        [HttpGet]
        public IEnumerable<Estado> Get()
        {
            return Enumerable.Range(1, 3).Select(i => new Estado 
            { 
                Id = i,
                Nome = Estados[i-1]
            });
        }
    }
}
