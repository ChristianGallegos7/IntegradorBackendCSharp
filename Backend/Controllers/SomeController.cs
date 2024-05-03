using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        [HttpGet("sync")]
        public IActionResult GetSync()
        {

            Thread.Sleep(1000);
            Console.WriteLine("Conexion to database ok");

            Thread.Sleep(5000);
            Console.WriteLine("Email enviado");
            return Ok();
        }
    }
}
