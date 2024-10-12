using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCustomers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new Customer { Id=1, Name = "Nombre del cliente"});
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
