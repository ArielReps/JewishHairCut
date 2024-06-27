using System.ComponentModel.DataAnnotations;

namespace JewishHairCut.Models
{
    public class Act
    {
        [Key] public int ID { get; set; }
        [Display(Name = "פעולה")] public string Name { get; set; }
        [Display(Name ="תאריך התחלה")] public DateTime Start { get; set; }
        [Display(Name = "תאריך סוף")] public DateTime End { get; set; }
        [Display(Name = "האם תפוס")] public bool IsOccupied { get; set; }
        [Display(Name = "מחיר")] public decimal Price { get; set; }
        public Act() { }
        public Act(ActOption actOption, DateTime start, DateTime end, decimal price, bool isOccupied = false)
        {
            Name = actOption.Name;
            Start = start;
            End = end;
            Price = price;
            IsOccupied = isOccupied;
        }
    }
}