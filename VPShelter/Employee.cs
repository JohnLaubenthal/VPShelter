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

        }

        public Employee(int employeeID)
        {
            this.EmployeeID = employeeID;
        }

        // abstract methods
        public abstract void Hunger();
        public abstract void Thirst();
        public abstract void Boredom();
        public abstract void Tiredness();

    }
}
