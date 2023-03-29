using Microsoft.AspNetCore.Mvc;

namespace WebAppTarde.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
