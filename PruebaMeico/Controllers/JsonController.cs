using Microsoft.AspNetCore.Mvc;
using PruebaMeico.Models;
using System.Text.Json;

namespace PruebaMeico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public JsonController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<Data> Get()
        {
            // Leer el archivo JSON
            var data = _configuration.GetSection("Json").Get<Data>();

            return data;
        }
    }
}
