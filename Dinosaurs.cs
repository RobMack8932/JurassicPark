using System;
namespace JurassicPark
{
    class Dinosaur
    {

        //First name Strings
        public string Name { get; set; }


        public string Diet { get; set; }

        public string Acquired { get; set; }

        public string Weight { get; set; }
        public string Enclosure { get; set; }
        public string Description()
        {
            var myOwnDescription = $"{Name} is a {Diet} who weighs {Weight}, they were acquired on {Acquired} and are located in {Enclosure}";

            return myOwnDescription;

        }


    }
}
