using JewishHairCut.DAL;
using JewishHairCut.Models;

namespace JewishHairCut.ViewModel
{
    public class VMActOptionBarber
    {
        public VMActOptionBarber() { barbers = Data.Get.GetAllBarbersActs; actOptions = Data.Get.ActOptions.ToList(); }
        public List<Barber> barbers { get; set; }
        public List<ActOption> actOptions {  get; set; }
    }
}
