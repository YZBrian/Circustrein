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
        public int MaxSize { get; private set; }

        public int CurrentSize
        {
            get { return AnimalsInWagon.Sum(e => (int) e.Size); }
        }

        public Wagon()
        {
            MaxSize = 10;
            AnimalsInWagon = new List<Animal>();
        }

        public IEnumerable<Animal> GetAnimalsInWagon()
        {
            return AnimalsInWagon;
        }

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

        private bool CheckCarnivoreSizeBiggerOrEqualToAnimal(Animal animalToCompare)
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

        private bool CheckHerbivoreSizeSmallerOrEqualToCarnivoreSize(Animal animalToCompare)
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
        
        public bool TryAdd(Animal animalToAdd)
        {
            if (CheckDoubleCarnivore(animalToAdd) && CheckCarnivoreSizeBiggerOrEqualToAnimal(animalToAdd) &&
                CheckHerbivoreSizeSmallerOrEqualToCarnivoreSize(animalToAdd) && (int) animalToAdd.Size + CurrentSize <= MaxSize)
            {
                AnimalsInWagon.Add(animalToAdd);

                return true;
            }

            return false;
        }
    }
}