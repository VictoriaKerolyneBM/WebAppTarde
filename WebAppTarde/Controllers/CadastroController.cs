using Microsoft.AspNetCore.Mvc;

namespace WebAppTarde.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
