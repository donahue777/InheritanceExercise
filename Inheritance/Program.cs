using System;
using System.Threading.Channels;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Bird parrot = new Bird();
            parrot.Name = "-Parrot-";
            parrot.CanSing = true;
            parrot.ChirpNoise = "Wrraaaa!";
            parrot.CanFly = true;
            parrot.FeatherAmount = 3000;

            Reptile snake = new Reptile()
            {
                Name = "-Snake-",
                CanRegenerate = false,
                HasClaws = false,
                ScalySkin = true,
                ColdBlooded = "Why must I rely on external sources of heat?"
            };

            var animals = new Animal[]
            {
                parrot, snake
            };

            foreach ( var animal in animals )
            {
                Console.WriteLine( animal.Name );
                Console.WriteLine($"Breath:{animal.Respiration}");
                Console.WriteLine($"Eating style:{animal.Eat}");
                Console.WriteLine($"Response to stimuli:{animal.RespondToStimuli}");
                Console.WriteLine($"Movement:{animal.Movement}");
                Console.WriteLine("");
            }

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
