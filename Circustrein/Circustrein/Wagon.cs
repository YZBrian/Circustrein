using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        private List<Animal> AnimalsInWagon { get; set; }
        public int MaxSize { get; private set; }
        public int CurrentSize { get; private set; }

        public Wagon()
        {
            MaxSize = 10;
            CurrentSize = 0;
            AnimalsInWagon = new List<Animal>();
        }

        //This method checks if you are adding a carnivore and if there already is a carnivore in the wagon.
        //Because 2 carnivores can never be in the same wagon.
        public bool CheckDoubleCarnivore(Animal animalToCompare)
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

        //This method checks if you are adding a carnivore and if the size of this carnivore is equal or bigger than the ones already in the wagon.
        //Because a carnivore cannot be bigger or equaly as big as another animal.
        public bool CheckCarnivoreSize(Animal animalToCompare)
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

        //This methode tries to add an animal to a wagon by checking the previous two methods and then checking if there is room left.
        public bool TryAdd(Animal animalToAdd)
        {
            if (CheckDoubleCarnivore(animalToAdd) && CheckCarnivoreSize(animalToAdd) && (int)animalToAdd.Size + CurrentSize <= MaxSize)
            {
                CurrentSize += (int)animalToAdd.Size;
                AnimalsInWagon.Add(animalToAdd);
                return true;
            }

            return false;
        }
    }
}