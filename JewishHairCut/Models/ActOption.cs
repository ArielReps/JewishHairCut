using System.ComponentModel.DataAnnotations;

namespace JewishHairCut.Models
{
    public class ActOption
    {
        [Key] public int ID { get; set; }
        [Display(Name = "פעולה")] public string Name { get; set; }
        public ActOption(string name) { Name = name; }
        public ActOption() { }
    }
}
