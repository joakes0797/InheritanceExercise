using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common --------Done


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class -----------------Done

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class ------------------Done


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values ------------------------Done
             */

            var robin = new Bird();
            robin.Name = "American Robin";
            robin.MakesNoise = "tweet tweet";
            robin.FeatherColor = "grey wings and reddish-orange breast";
            robin.Characteristic = "bobs";
            robin.BlueEgg = true;

            var goose = new Bird();
            goose.Name = "Canada Goose";
            goose.MakesNoise = "loud HONK";
            goose.FeatherColor = "a long black neck and prominent white chin strap";
            goose.Characteristic= "aggressiveness";

            Console.WriteLine($"It's {robin.BlueEgg} that the {robin.Name} lays blue eggs and goes {robin.MakesNoise}.  \n" +
                $"This bird is noted for its {robin.FeatherColor} and {robin.LegCount} legs that it {robin.Characteristic} around on.  \n" +
                $"The dreaded {goose.Name} is known for its {goose.Characteristic} and {goose.MakesNoise}.  \n" +
                $"It has {goose.FeatherColor}.");
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values --------------------------Done
             */
            var turtle = new Reptile();
            turtle.Name = "Turtle";
            turtle.MakesNoise = "cowabunga!";
            turtle.LegCount = 2;
            turtle.FoodPreference = "pizza";
            turtle.PoweredBy = "video games";
            turtle.ForkedTongue = false;
            turtle.HasShell = true;

            Console.WriteLine($"Does a {turtle.Name} have a shell and say '{turtle.MakesNoise}'?  \n" +
                $"It's {turtle.HasShell} if that turtle is Michaelangelo from the Teenage Mutant Ninja Turtles.  \n" +
                $"It's weird because he has {turtle.LegCount} legs instead of 4, walking upright and fighting crime with his arms.  \n" +
                $"He also loves {turtle.FoodPreference} and enjoys {turtle.PoweredBy} over sunning on a log in a pond.");
        }
    }
}
