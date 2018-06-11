using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter
    {
        public string PetHouse { get; set; }
        public string PeopleHouse { get; set; }
        public List<string> PetList { get; set; }
        public string Pets { get; set; }
        public List<string> Volunteer { get; set; }
        public string AnimalType { get; set; }




        public VirtualPetShelter()
        {
            //default constructor
        }

        public VirtualPetShelter(string petHouse, string peopleHouse, List<string> petList)
        {
            this.PetHouse = petHouse;
            this.PeopleHouse = peopleHouse;
            this.PetList = petList;
        }

        public VirtualPetShelter(List<string> petlist, string dog, string cat)
        {
            this.PetList = petlist;
            this.AnimalType = AnimalType;

        }
        Volunteer volunteerOne = new Volunteer();
        List<Volunteer> volunteerList = new List<Volunteer>();
        Manager managerOne = new Manager();
        List<Manager> managerList = new List<Manager>();

       
    }//class end

}//namespace end
