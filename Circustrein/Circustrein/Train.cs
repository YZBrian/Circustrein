﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        private List<Wagon> Wagons { get; set; }

        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public List<Wagon> GetAllWagons()
        {
            return Wagons;
        }

        public void AddWagon()
        {
            Wagon wagon = new Wagon();
            Wagons.Add(wagon);
        }

        public void DivideAnimals(List<Animal> animalCollection)
        {
            foreach (Animal animal in animalCollection)
            {

            }
        }
    }
}