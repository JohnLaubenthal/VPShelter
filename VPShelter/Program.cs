using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet tyson = new VirtualPet("Tyson", 25, 15, 25, 15);
            VirtualPet crystal = new VirtualPet("Crystal", 25, 15, 25, 15);
            Manager joe = new Manager();

            string userTypeResponse ="";
            while (userTypeResponse != "quit") { 
            Console.WriteLine("Welcome to John's Virtual Pet Shelter!");
            Console.WriteLine("Are you a Manager or Volunteer, or press quit to exit.");
            userTypeResponse = Console.ReadLine().ToLower();
            
            if (userTypeResponse == "manager")
            {
                Console.WriteLine("1. Would you like to view the pets status?");
                Console.WriteLine("2. Would you like to play with one of the pets?");
                Console.WriteLine("3. Would you like to adopt a pet today?");
                int userManagerResponse = int.Parse(Console.ReadLine());

                if (userManagerResponse == 1)
                {
                    
                }

                if (userManagerResponse == 2)
                {
                    tyson.Play();
                   
                }
                if (userManagerResponse == 3)
                {
                    Console.WriteLine(joe.Adoption());
                }
                  
            }

            if (userTypeResponse == "volunteer")
            {
                Console.WriteLine("1. Would you like to give the pets a drink?");
                Console.WriteLine("2. Would you like to feed the pets?");
                int userVolunteerResponse = int.Parse(Console.ReadLine());

            }
            }


        }//main end
    }//class end
}//namespace end
