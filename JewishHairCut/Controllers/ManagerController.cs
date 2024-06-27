using JewishHairCut.DAL;
using JewishHairCut.Models;
using JewishHairCut.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JewishHairCut.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            VMActOptionBarber vMActOptionBarber = new VMActOptionBarber();
            return View(vMActOptionBarber);
        }
        public IActionResult AddOption()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddOption(ActOption option)
        {
            Data.Get.ActOptions.Add(option);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
