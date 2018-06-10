using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class PetFood : VirtualPet
    {

                //fields & properties
        public string Dog { get; set; }
        public string Cat { get; set; }
        public string DogFood { get; set; }
        public string CatFood { get; set; }


                
        public PetFood()
        {
            //default constructor
        }

        public PetFood( string dog, string cate, string dogfood, string catfood)
        {
            this.Dog = dog;
            this.Cat = Cat;
            this.DogFood = dogfood;
            this.CatFood = catfood;
        }
        public void ViewPetInfo()
        {
            Dog = "Tyson";
            Cat = "Crystal";
            DogFood = "Pedigree";
            CatFood = "MeowMix";
        }
    }
}
