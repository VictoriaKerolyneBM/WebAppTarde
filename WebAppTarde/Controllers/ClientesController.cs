using Microsoft.AspNetCore.Mvc;

namespace WebAppTarde.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
