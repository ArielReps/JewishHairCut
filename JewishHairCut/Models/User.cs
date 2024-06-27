using System.ComponentModel.DataAnnotations;

namespace JewishHairCut.Models
{
    public class User
    {
        [Key] public int ID { get; set; }
        [Display(Name = "שם משתמש")] public string Name { get; set; }
        [Display(Name = "מנהל")] public bool IsManager { get; set; }
        [Display(Name = "מספר טלפון")] public string PhoneNumber { get; set; }

        public User() { }

        public User(string name, string phoneNumber = "05", bool isManager = false)
        {
            Name = name;
            IsManager = isManager;
            PhoneNumber = phoneNumber;
        }
    }
}
