using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetClient02.Data;
using PetClient02.Models;

namespace PetClient02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        private readonly ClientsApiDbContext dbContext;
        public ClientsController(ClientsApiDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }
        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
           return Ok(await dbContext.Clients.ToListAsync());
            
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(AddClientRequest addClientRequest)
        {
            var client = new Client()
            {
                Id = Guid.NewGuid(),
                Breed = addClientRequest.Breed,
                Email = addClientRequest.Email,
                PetBirthday = addClientRequest.PetBirthday,
                PetName = addClientRequest.PetName,
                Phone = addClientRequest.Phone,
                FullName = addClientRequest.FullName,
                Species = addClientRequest.Species,
            };

           await dbContext.Clients.AddAsync(client);
            await dbContext.SaveChangesAsync();
            return Ok(client);
        }
    }
}
