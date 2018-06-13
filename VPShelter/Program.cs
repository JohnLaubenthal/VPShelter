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
            Console.WriteLine("Are you a Manager or Volunteer, or enter 'quit' to exit.");
            userTypeResponse = Console.ReadLine().ToLower();
            
            if (userTypeResponse == "manager")
            {
                Console.WriteLine("1. Would you like to view the pets status?");
                Console.WriteLine("2. Would you like to play with one of the pets?");
                Console.WriteLine("3. Would you like to adopt a pet today?");
                int userManagerResponse = int.Parse(Console.ReadLine());

                if (userManagerResponse == 1)
                {
                        Console.WriteLine("These are Tyson's stats.");
                        Console.WriteLine("Hunger Level"+ (tyson.Hunger));
                        
                        Console.WriteLine("Thirst Level"+ tyson.Thirst);
                        
                        
                        Console.WriteLine("Boredom Level  " +(tyson.Boredom));
                        Console.WriteLine("Tiredness Level  " +(tyson.Tiredness));
                        Console.WriteLine("These are Crystal's stats.");
                        Console.WriteLine("Hunger Level  " +(crystal.Hunger));
                        Console.WriteLine("Thirst Level  " +(crystal.Thirst));
                        Console.WriteLine("Boredom Level  " + (crystal.Boredom));
                        Console.WriteLine("Tiredness Level  " + (crystal.Tiredness));
                }

                if (userManagerResponse == 2)
                {
                    tyson.Play();
                        
                }
                if (userManagerResponse == 3)
                {
                    Console.WriteLine("Please select 4. for Tyson: Jack Russell Terrier or 5. Crystal: Siamese Cat");
                        int ManagerResponse = int.Parse(Console.ReadLine());
                        Console.WriteLine(joe.Adoption());
                }
                if (userManagerResponse == 3)
                    {
                        Console.WriteLine("You have adopted Tyson!");
                        Console.WriteLine(joe.Adoption());
                    }
                  
            }

            if (userTypeResponse == "volunteer")
            {
                Console.WriteLine("1. Would you like to give the pets a drink?");
                Console.WriteLine("2. Would you like to feed the pets?");
                int userVolunteerResponse = int.Parse(Console.ReadLine());
                
                if (userVolunteerResponse == 1)
            {
                Console.WriteLine("Thanks for the drink!");
            }
                if (userVolunteerResponse == 2)
                    {
                        Console.WriteLine("Thanks for feeding me!");
                    }



                }




            }


        }//main end
    }//class end
}//namespace end
