using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            train.AddWagon();

            List<Animal> animalCollection = new List<Animal>();

            Animal animal1 = new Animal(Size.Large, Diet.Herbivore);
            Animal animal2 = new Animal(Size.Small, Diet.Carnivore);
            Animal animal3 = new Animal(Size.Medium, Diet.Herbivore);
            Animal animal4 = new Animal(Size.Large, Diet.Herbivore);
            Animal animal5 = new Animal(Size.Small, Diet.Carnivore);
            Animal animal6 = new Animal(Size.Small, Diet.Carnivore);
            Animal animal7 = new Animal(Size.Large, Diet.Carnivore);
            Animal animal8 = new Animal(Size.Medium, Diet.Herbivore);
            Animal animal9 = new Animal(Size.Medium, Diet.Herbivore);
            Animal animal10 = new Animal(Size.Small, Diet.Herbivore);

            animalCollection.Add(animal1);
            animalCollection.Add(animal2);
            animalCollection.Add(animal3);
            animalCollection.Add(animal4);
            animalCollection.Add(animal5);
            animalCollection.Add(animal6);
            animalCollection.Add(animal7);
            animalCollection.Add(animal8);
            animalCollection.Add(animal9);
            animalCollection.Add(animal10);

            train.DivideAnimals(animalCollection);

            foreach (Wagon wagon in train.GetAllWagons())
            {
                Console.WriteLine("Current wagon size is: " + wagon.CurrentSize);
                foreach (Animal animal in wagon.GetAnimalsInWagon())
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}