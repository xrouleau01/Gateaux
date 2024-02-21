using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GateauController : Controller
    {
        private MemGateauRep _mesGateaux;

        public GateauController(MemGateauRep mesGateaux)
        {
            _mesGateaux = mesGateaux;
        }
        public IActionResult Index()
        {
            return View(_mesGateaux.collectionGateau);
        }

        public IActionResult Cherche(int id)
        {
            Gateau gateau = _mesGateaux.ChercheGateau(id);
            if (gateau == null)
            {
                return Content("Pas de gateau!");
            }
            else
            {
                return View(gateau);
            }
        }
    }
}
