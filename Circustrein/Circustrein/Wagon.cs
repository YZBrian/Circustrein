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

        public bool CheckSpace()
        {
            foreach (Wagon wagon in Wagons)
            {
                
            }
        }
    }
}