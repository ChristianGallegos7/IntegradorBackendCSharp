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

        [HttpGet("sync")]
        public async Task<IActionResult> GetAsync()
        {
            var taks1 = new Task( () =>
            {

                Thread.Sleep(1000);
                Console.WriteLine("Conexion to database ok");

            });

            taks1.Start();

            await taks1;
        }
    }
}
