using JewishHairCut.DAL;
using JewishHairCut.Models;
using Microsoft.AspNetCore.Mvc;

namespace JewishHairCut.Controllers
{
    public class BarberController : Controller
    {
        public IActionResult Index()
        {
            List<Barber> barbers = Data.Get.GetAllBarbersActs;
            return View(barbers);
        }
    }
}
