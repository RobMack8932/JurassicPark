using System;
using System.Collections.Generic;

namespace JurassicPark
{
    class Program
    {
        static string PromptForString(string prompt)


        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {

                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry this is not valid input 0 will be your answer");
                return 0;
            }

        }


        static void Main(string[] args)
        {

            //Add Dinosaurs

            var Velociraptor = new Dinosaurs
            {
                Name = "Velociraptor",
                Diet = "Herbavore",
                Acquired = "May 14th 2020",
                Enclosure = "Unit A",
                Weight = "50 lbs",
            };

            var Triceratops = new Dinosaurs
            {
                Name = "Triceratops",
                Diet = "Herbavore",
                Acquired = "May 15th 2020",
                Enclosure = "Unit A",
                Weight = "500 lbs",
            };

            var Tyrannosaurus = new Dinosaurs
            {
                Name = "Tyrannosaurus",
                Diet = "Carnivore",
                Acquired = "May 14th 2020",
                Enclosure = "Unit B",
                Weight = "800 lbs",

            };

            var Spinosaurus = new Dinosaurs
            {
                Name = "Spinosaurus",
                Diet = "Carnivore",
                Acquired = "May 16th 2020",
                Enclosure = "Unit B",
                Weight = "600 lbs",


            };

            var Cryolophosaurus = new Dinosaurs
            {
                Name = "Cryolosaurus",
                Diet = "Carnivore",
                Acquired = "May 17h 2020",
                Enclosure = "Unit B",
                Weight = "100 lbs",

            };
            //List the Dinos

            var listOfDinosaurs = new List<Dinosaurs>();

            listOfDinosaurs.Add(Velociraptor);
            listOfDinosaurs.Add(Triceratops);
            listOfDinosaurs.Add(Tyrannosaurus);
            listOfDinosaurs.Add(Spinosaurus);
            listOfDinosaurs.Add(Cryolophosaurus);








            Console.WriteLine();
            Console.WriteLine("Welcome to the Dinosaur Zoo");
            Console.WriteLine();

            //If They Quit
            var userHasChosenToQuit = false;
            while (userHasChosenToQuit == false)
            {
                Console.WriteLine("Choose: ");


                //Add Dino
                Console.WriteLine("(A)dd a new Dinosaur");
                //Remove
                Console.WriteLine("(R)emove a Dinosaur");

                //View all Dinos
                Console.WriteLine("(V)iew all Dinosaurs");
                //TransferDino to different Enclosure
                Console.WriteLine("(T)ransfer a Dinosaur");
                //List Herbavores and Canivores
                Console.WriteLine("(S)ummary of Herbavores and Carnivores");
                //Quit App
                Console.WriteLine("(Q)uit");
                Console.WriteLine();


                var choice = PromptForString("Choice: ");



                if (choice == "Q")
                {
                    userHasChosenToQuit = true;
                }
                if (choice == "V")
                {
                    Console.WriteLine("Here are all our dinosaurs");
                }

                //Name is a diet that weighs they were committed on and are located at 
                foreach (var Dinosaurs in listOfDinosaurs)
                {
                    var description = $"{Dinosaurs.Name} is a {Dinosaurs.Diet} who weighs {Dinosaurs.Weight}, they were acquired on {Dinosaurs.Acquired} and are located in {Dinosaurs.Enclosure}";
                    Console.WriteLine(description);
                }
            }
        }
    }
}



