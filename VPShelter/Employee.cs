using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
  public abstract class Employee
    {
        public int EmployeeID { get; set; }
        public Employee()
        {
            //default Ctor
        }

        //methods
        public virtual string FedThePets()
        {
            return "Thanks for the grub!";

        }
        public virtual string WaterThePets()
        {
            return "Thanks for the drink!";
        }

        

        // abstract methods(2)
        public abstract void PayRoll();
        public abstract void Utilities();
        

    }
}
