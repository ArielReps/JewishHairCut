using JewishHairCut.DAL;
using JewishHairCut.Models;
using System.ComponentModel.DataAnnotations;

namespace JewishHairCut.ViewModel
{
    public class VMActionBarber
    {
        public VMActionBarber() { ActOptions = Data.Get.ActOptions.ToList(); }
        public Barber Barber { get; set; }
        public int ID { get; set; }
        [Display(Name = "פעולה")] public string Name { get; set; } = "";
        [Display(Name = "תאריך התחלה")] public DateTime Start { get; set; }
        [Display(Name = "תאריך סוף")] public DateTime End { get; set; }
        [Display(Name = "מחיר")] public decimal Price { get; set; }
        public List<ActOption> ActOptions { get; set; }
    }
}
