using Microsoft.AspNetCore.Mvc;
using PetClient02.Data;

namespace PetClient02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        private readonly ClientsApiDbContext dbContext;
        public ClientsController(ClientsApiDbContext dbContext)
        {

        }
        [HttpGet]
        public IActionResult GetClients()
        {
           return Ok(dbContext.Clients.ToList());
            
        }
    }
}
