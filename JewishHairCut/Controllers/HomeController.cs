using JewishHairCut.DAL;
using JewishHairCut.Models;
using JewishHairCut.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading;

namespace JewishHairCut.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            VMCreate vMCreate = new();
            return View(vMCreate);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Create(VMCreate vMCreate)
        {
            if(vMCreate != null)
            {
                if(vMCreate.IsBarber)
                {
                    Barber barber = new Barber(vMCreate.Name,vMCreate.PhoneNumber,vMCreate.IsManager);
                    Data.Get.Barbers.Add(barber);
                }
                else
                {
                    User user = new User(vMCreate.Name, vMCreate.PhoneNumber, vMCreate.IsManager);
                    Data.Get.Users.Add(user);
                }
                Data.Get.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult ShowBarbers()
        {
            List<Barber> barbers = Data.Get.GetAllBarbersActs;
            return View(barbers);
        }
        public IActionResult DetailsOnBarber(int userID)
        {
        Barber barber = Data.Get.GetAllBarbersActs.FirstOrDefault(b => b.ID == userID, Data.Get.GetAllBarbersActs.First());
        return View(barber); 
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult OccupieAct(int ActID)
        {
            Act act = Data.Get.Acts.First(c => c.ID == ActID);
            act.IsOccupied = true;
            Data.Get.SaveChanges();
            return RedirectToAction("ShowBarbers");
        }
    }
}
