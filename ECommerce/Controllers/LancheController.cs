using Microsoft.AspNetCore.Mvc;
using ECommerce.Repositories;

namespace ECommerce.Controllers
{
    public class LancheController : Controller
    {
        private readonly LancheRepository _lancheRepository;

        public LancheController(LancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
