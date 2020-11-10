using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        private List<Animal> Animals { get; set; }
        private List<Wagon> Wagons { get; set; }


        public Train()
        {
            Animals = new List<Animal>();
            Wagon wagon = new Wagon();
            wagon.TryAdd();
        }

    }
}