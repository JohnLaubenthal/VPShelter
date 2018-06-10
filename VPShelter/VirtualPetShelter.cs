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
        public List<Pets> PetList { get; set; }
        public string Pets { get; set; }

        public VirtualPetShelter()
        {
            //default constructor
        }

        public VirtualPetShelter(string petHouse, string peopleHouse, List<Pets> petList)
        {
            this.PetHouse = petHouse;
            this.PeopleHouse = peopleHouse;
            this.PetList = petList;
        }

        public VirtualPetShelter(List<Pets> petlist, string dog, string cat)
        {
            this.PetList = petlist;
            this.PetList = petlist;
        }
        Volunteer volunteerOne = new Volunteer();
        List<Volunteer> volunteerList = new List<Volunteer>();
        Manager managerOne = new Manager();
        List<Manager> managerList = new List<Manager>();

       
    }

}
