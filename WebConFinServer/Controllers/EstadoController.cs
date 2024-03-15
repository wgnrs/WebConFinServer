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
        [HttpGet]
        public string GetEstados()
        {
            return "Estado retornado";
        }
    }
}
