using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public enum Size
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }

    public enum Diet
    {
        Herbivore = 0,
        Carnivore = 1
    }

    public class Animal
    {
        public Size Size { get; private set; }
        public Diet Diet { get; private set; }
        public bool IsAdded { get; set; }

        public Animal(Size size, Diet diet)
        {
            Size = size;
            Diet = diet;
            IsAdded = false;
        }

        public override string ToString()
        {
            return Size + " " + Diet;
        }
    }
}