using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        public string VolunteerName { get; set; }


        public Volunteer()
    {

    }
        public Volunteer(string volunteerName)
        {
            this.VolunteerName = VolunteerName;
        }

        public override void Hunger()
        {
            Console.WriteLine("Thanks for feeding me!");
        }

        public override void Thirst()
        {
            Console.WriteLine("Thanks for the drink!");
        }

        public override void Boredom()
        {
            Console.WriteLine("Thanks for the walk!");
        }

        public override void Tiredness()
        {
            Console.WriteLine("I needed the sleep!");
        }

       
            
        
    }//class end
        
}//namespace end
