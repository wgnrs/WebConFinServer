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

        public static List<Estado> lista = new List<Estado>();

        [HttpGet]
        public List<Estado> GetEstados()
        {
            return lista;
        }

        [HttpPost]
        public string PostEstado(Estado estado) 
        {
            lista.Add(estado);
            return "Estado cadastrado com sucesso!";
        }
    }
}
