using System.ComponentModel.DataAnnotations;

namespace JewishHairCut.ViewModel
{
    public class VMCreate
    {
        public VMCreate() { }
        [Display(Name = "שם משתמש")] public string Name { get; set; }
        [Display(Name = "האם אתה ספר")] public bool IsBarber { get; set; }
        [Display(Name = "האם אתה מנהל")] public bool IsManager { get; set; }
        [Display(Name = "מספר טלפון")] public string PhoneNumber { get; set; }

    }
}
