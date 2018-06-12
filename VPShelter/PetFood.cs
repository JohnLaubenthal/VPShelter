using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class PetFood : VirtualPet
    {

        public string PetType { get; set; }
        public string PetDiet { get; set; }


        public PetFood(string PetType, string PetFood)
        {

            this.PetType = PetType;
            this.PetDiet = PetDiet;
        }
    
    }//class end
}//namespace end
