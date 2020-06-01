using System;
using System.Collections.Generic;
using System.Linq;

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

            var Velociraptor = new Dinosaur
            {
                Name = "Velociraptor",
                Diet = "Herbivore",
                Acquired = "May 14th 2020",
                Enclosure = "Unit A",
                Weight = "50 lbs"
            };

            var Triceratops = new Dinosaur
            {
                Name = "Triceratops",
                Diet = "Herbivore",
                Acquired = "May 15th 2020",
                Enclosure = "Unit A",
                Weight = "500 lbs"
            };

            var Tyrannosaurus = new Dinosaur
            {
                Name = "Tyrannosaurus",
                Diet = "Carnivore",
                Acquired = "May 14th 2020",
                Enclosure = "Unit B",
                Weight = "800 lbs"

            };

            var Spinosaurus = new Dinosaur
            {
                Name = "Spinosaurus",
                Diet = "Carnivore",
                Acquired = "May 16th 2020",
                Enclosure = "Unit B",
                Weight = "600 lbs"


            };

            var Cryolophosaurus = new Dinosaur
            {
                Name = "Cryolosaurus",
                Diet = "Carnivore",
                Acquired = "May 17h 2020",
                Enclosure = "Unit B",
                Weight = "100 lbs"

            };
            //List the Dinos

            var listOfDinosaurs = new List<Dinosaur>();

            listOfDinosaurs.Add(Velociraptor);
            listOfDinosaurs.Add(Triceratops);
            listOfDinosaurs.Add(Tyrannosaurus);
            listOfDinosaurs.Add(Spinosaurus);
            listOfDinosaurs.Add(Cryolophosaurus);





            //foreach (var dinosaur in listOfDinosaurs)
            //{
            //  Console.WriteLine(dinosaur.Name);
            //}


            //var dinosaursThatAreCarnivores = listOfDinosaurs.Where(dinosaur => dinosaur.Diet == "Carnivore");



            //foreach (var dinosaur in dinosaursThatAreCarnivores)
            // {
            //    Console.WriteLine($"{dinosaur.Name}");

            // }








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

                //Separate Dinos

                var choice = PromptForString("Choice: ");

                if (choice == "S")
                {
                    var choiceOfDiet = PromptForString("(C)arnivores or (H)erbivores?");

                    var dinosaursThatAreCarnivores = listOfDinosaurs.Where(dinosaur => dinosaur.Diet == "Carnivore");
                    var dinosaursThatAreHerbivores = listOfDinosaurs.Where(dinosaur => dinosaur.Diet == "Herbivore");
                    if (choiceOfDiet == "C")
                    {

                        foreach (var dinosaur in dinosaursThatAreCarnivores)
                        {
                            Console.WriteLine(dinosaur.Name);

                        }
                    }

                    if (choiceOfDiet == "H")
                    {
                        foreach (var dinosaur in dinosaursThatAreHerbivores)
                        {
                            Console.WriteLine(dinosaur.Name);

                        }

                    }
                }

                //To Quit for some reason
                if (choice == "Q")
                {
                    userHasChosenToQuit = true;
                }
                //To Remove Dino

                //
                // if (foundDinosaur == null)
                //{
                //                         Console.WriteLine($"There is no Dinosaur named {foundDinosaur}");
                //                         break;

                // }

                //
                if (choice == "R")
                {
                    var nameOfDinosaurBeingRemoved = PromptForString("Name of dinosaur to be removed: ");
                    var foundDinosaur = listOfDinosaurs.FirstOrDefault(dinosaurs => nameOfDinosaurBeingRemoved == dinosaurs.Name);
                    var foundDinosaurDescription = foundDinosaur.Description();
                    Console.WriteLine(foundDinosaurDescription);
                    var shouldWeRemove = PromptForString("Are you sure you want to remove? (Y/N):");

                    if (shouldWeRemove == "Y")
                    {
                        listOfDinosaurs.Remove(foundDinosaur);

                    }

                    if (shouldWeRemove == "N")
                    {
                        Console.WriteLine("Okay, back to main menu");
                    }
                }

                //To Add a Dino
                if (choice == "A")
                {
                    var newName = PromptForString("Name: ");
                    var newDiet = PromptForString("Diet: ");
                    var newWeight = PromptForString("Weight: ");
                    var newAcquired = PromptForString("Acquired: ");
                    var newEnclosure = PromptForString("Enclosure: ");

                    listOfDinosaurs.Add(new Dinosaur
                    {
                        Name = newName,
                        Diet = newDiet,
                        Weight = newWeight,
                        Acquired = newAcquired,
                        Enclosure = newEnclosure,

                    });
                }

                //Show all Dinos
                if (choice == "V")
                {
                    Console.WriteLine("Here are all our dinosaurs");


                    //Name is a diet that weighs they were committed on and are located at 
                    foreach (var Dinosaurs in listOfDinosaurs)
                    {
                        var description = Dinosaurs.Description();
                        Console.WriteLine(description);
                    }
                }

                //Transfer Dino

                if (choice == "T")
                {
                    var nameOfDinosaurToTransfer = PromptForString("Which Dinosaur would you like to update with their new Enclosure?");
                    var foundDinosaur = listOfDinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinosaurToTransfer);

                    if (foundDinosaur == null)
                    {
                        Console.WriteLine($"There is no dinosaur named {nameOfDinosaurToTransfer}");

                    }
                    else
                    {
                        var foundDinosaurDescription = foundDinosaur.Description();
                        Console.WriteLine(foundDinosaurDescription);
                        var newDinosaurEnclosure = PromptForString("Unit A or Unit B for new Enclosure?: ");
                        foundDinosaur.Enclosure = newDinosaurEnclosure;
                    }

                }





            }






        }

    }
}
























