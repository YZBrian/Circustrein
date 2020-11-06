using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        private List<Animal> animals = new List<Animal>();
        private List<Wagon> Wagons { get; set; }
        public Wagon Wagon = new Wagon();
    }
}