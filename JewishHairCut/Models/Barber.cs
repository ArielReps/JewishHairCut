using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewishHairCut.Models
{
    public class Barber : User
    {
        public List<Act> Acts { get; set; }

        public Barber()
        {
            Acts = new List<Act>();
        }
        public Barber(string name, string phoneNumber = "05", bool isManager = false)
           : base(name, phoneNumber, isManager)
        {
            Acts = new List<Act>();
        }

        public void AddAct(ActOption actOption, DateTime start, DateTime end, decimal price)
        {
            Acts.Add(new Act(actOption, start, end, price));
        }

        public void AddAct(Act act)
        {
            Acts.Add(act);
        }
    }
}
