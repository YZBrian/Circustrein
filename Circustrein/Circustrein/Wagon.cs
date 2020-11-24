using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        private List<Animal> AnimalsInWagon { get; set; }
        private int MaxSize { get; set; }

        public int CurrentSize
        {
            get { return AnimalsInWagon.Sum(e => (int) e.Size); }
        }

        public Wagon()
        {
            MaxSize = 10;
            AnimalsInWagon = new List<Animal>();
        }

        public List<Animal> GetAnimalsInWagon()
        {
            return AnimalsInWagon;
        }


        //This method checks if you are adding a carnivore and if there already is a carnivore in the wagon.
        //Because 2 carnivores can never be in the same wagon.

        private bool CheckDoubleCarnivore(Animal animalToCompare)
        {
            foreach (Animal animal in AnimalsInWagon)
            {
                if (animalToCompare.Diet == Diet.Carnivore && animal.Diet == Diet.Carnivore)
                {
                    return false;
                }
            }

            return true;
        }

        //This method checks if you are adding a carnivore or a herbivore and if the size of this animal is compatible with the size of the animals in the wagon.
        //Because a carnivore cannot be bigger or equally as big as another animal.
        private bool CheckCarnivoreSize(Animal animalToCompare)
        {
            foreach (Animal animal in AnimalsInWagon)
            {
                if (animalToCompare.Diet == Diet.Carnivore && animalToCompare.Size >= animal.Size)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckHerbivoreSize(Animal animalToCompare)
        {
            foreach (Animal animal in AnimalsInWagon)
            {
                if (animalToCompare.Diet == Diet.Herbivore && animal.Diet == Diet.Carnivore &&
                    animalToCompare.Size <= animal.Size)
                {
                    return false;
                }
            }

            return true;
        }

        //This method tries to add an animal to a wagon by checking the previous two methods and then checking if there is room.
        public bool TryAdd(Animal animalToAdd)
        {
            if (CheckDoubleCarnivore(animalToAdd) && CheckCarnivoreSize(animalToAdd) &&
                CheckHerbivoreSize(animalToAdd) && (int) animalToAdd.Size + CurrentSize <= MaxSize)
            {
                animalToAdd.IsAdded = true;
                AnimalsInWagon.Add(animalToAdd);

                return true;
            }

            return false;
        }
    }
}