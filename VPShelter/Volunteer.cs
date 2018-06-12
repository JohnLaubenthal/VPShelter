using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        public string VolunteerName { get; set; }


        public Volunteer()
    {

    }
        public Volunteer(string volunteerName)
        {
            this.VolunteerName = VolunteerName;
        }

        public void Hunger()
        {
            Console.WriteLine("Thanks for feeding me!");
        }

        public void Thirst()
        {
            Console.WriteLine("Thanks for the drink!");
        }

        public void Boredom()
        {
            Console.WriteLine("Thanks for the walk!");
        }

        public void Tiredness()
        {
            Console.WriteLine("I needed the sleep!");
        }

        public override void PayRoll()
        {

        }
        public override void Utilities()
        {

        }


    }//class end
        
}//namespace end
