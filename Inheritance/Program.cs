using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();

            bird1.Breed = "Peregrine Falcon";
            bird1.BirdOfPrey = true;
            bird1.DoesItFly = true;
            bird1.Speed = "up to 200mph";
            bird1.Noise = "screeeech";
            bird1.Size = "up to 23 inches";
            bird1.Legs = 2; 
             
            Reptile rep1 = new Reptile();

            rep1.Type = "Gecko";
            rep1.Scales = false;
            rep1.Herbivore = false;
            rep1.EcoSystem = "Adaptive";
            rep1.Legs = 4;
            rep1.IsNocturnal = true;
            rep1.Speed = "up to 30mph";
            rep1.Noise = "click click click";
            
            Console.WriteLine($"We are now here to see our {bird1.Breed} hunt for something to eat.\n " +
                $"The stats on this swift creature is:\n" +
                $"Bird of prey? - {bird1.BirdOfPrey}\n" +
                $"Does it fly? - {bird1.DoesItFly} at speeds {bird1.Speed} when diving from the air\n" +
                $"Size of bird - Can grow {bird1.Size}\n" +
                $"These are one of the many birds that are great hunters. \n" +
                $"With a {bird1.Noise} our friend the {bird1.Breed} has found a snack and dives down to what looks like a {rep1.Type}??\n" +
                $"{rep1.Type} stats:\n" +
                $"Will it make it? Probably not its speed is only {rep1.Speed}\n" +
                $"Now let the hunter be hunted as {rep1.Type}s are plant eaters: {rep1.Herbivore}!! they hunt insects.\n" +
                $"As the {bird1.Breed} is close to getting its prey. The {rep1.Type} notices and gives off {rep1.Noise}\n" +
                $"and 30 other {rep1.Type}s jump the {bird1.Breed} and fight it off oh my gossshhh poor {bird1.Breed}!!!\n" +
                $" If there is one thing we've learned today is dont mess with {rep1.Type}s because you might get jumped.\n" +
                $"And insects are not the the only thing {rep1.Type}s are willing to hunt. ");
        }
    }
}
