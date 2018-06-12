using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{

   public class Manager : Employee
   {
        public int Salary { get; set; }

        public override void PayRoll()
        {

        }
        public override void Utilities()
        {

        }
        public string Adoption()
        {
            return "Thanks for the new home!";
        }

    }
}
