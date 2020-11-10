using System;
using System.Collections.Generic;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>();
            Animal animal1 = new Animal(Size.Small, Diet.Herbivore);
            Animal animal2 = new Animal(Size.Medium, Diet.Carnivore);
            Animal animal3 = new Animal(Size.Large, Diet.Herbivore);
            Animal animal4 = new Animal(Size.Small, Diet.Carnivore);
            Animal animal5 = new Animal(Size.Medium, Diet.Herbivore);
            Animal animal6 = new Animal(Size.Large, Diet.Carnivore);
            Animal animal7 = new Animal(Size.Small, Diet.Herbivore);
            Animal animal8 = new Animal(Size.Medium, Diet.Carnivore);
            Animal animal9 = new Animal(Size.Large, Diet.Herbivore);
            Animal animal10 = new Animal(Size.Small, Diet.Carnivore);

            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            animals.Add(animal10);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}