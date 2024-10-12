using Microsoft.AspNetCore.Mvc;

namespace ApiUsers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new User { Id = 1, Nombre = "Nombre de usuario" });
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
