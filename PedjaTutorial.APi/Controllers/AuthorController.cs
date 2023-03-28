using Microsoft.AspNetCore.Mvc;
using PedjaTutorial.Models;
using PedjaTutorial.Services;

namespace PedjaTutorial.APi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {

        private AuthorService _authorService;
        public AuthorController()
        {
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            
            return _authorService.GetAll();
        }
    }
}