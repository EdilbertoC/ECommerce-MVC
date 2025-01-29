using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
