using JewishHairCut.DAL;
using JewishHairCut.Models;
using JewishHairCut.ViewModel;
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
        public IActionResult Details(int ID)
        {
            if(ID == null) return RedirectToAction("Index");
            Barber barber = Data.Get.Barbers.FirstOrDefault(x => x.ID == ID);
            if (barber == null) return RedirectToAction("Index");
            return View(barber);
        }
        public IActionResult AddActionToBarber(int ID)
        {
            if (ID == null) return RedirectToAction("Index");
            Barber barber = Data.Get.Barbers.FirstOrDefault(x => x.ID == ID);
            if (barber == null) return RedirectToAction("Index");
            VMActionBarber vMActionBarber = new();
            vMActionBarber.ID = ID;
            vMActionBarber.Barber = barber;
            return View(vMActionBarber);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult AddActionToBarber(VMActionBarber VMactionBarber)
        {
            Barber barber = Data.Get.Barbers.FirstOrDefault(x => x.ID == VMactionBarber.ID);
            Act act = new(VMactionBarber.Name, VMactionBarber.Start, VMactionBarber.End, VMactionBarber.Price);
            if (VMactionBarber.Name != null && barber != null)
            {
                barber.Acts.Add(act);
                Data.Get.Acts.Add(act);
                Data.Get.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
