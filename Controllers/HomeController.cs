using Microsoft.AspNetCore.Mvc;
using TestWebApplication1.Data;

namespace TestWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositories repositories;

        public HomeController(IRepositories repositories)
        {
            this.repositories = repositories;
        }

        public IActionResult Index(IRepositories repositories)
        {
            return this.Ok($"Connecting to: {this.repositories.GetConnectionString()}");
        }
    }
}
