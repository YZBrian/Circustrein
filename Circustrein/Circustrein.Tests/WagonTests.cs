using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circustrein.Tests
{
    [TestClass]
    public class WagonTests
    {
        private Wagon _wagon;

        [TestInitialize]
        public void Setup()
        {
            _wagon = new Wagon();
        }

        [TestMethod]
        public void Wagon_Can_Be_Constructed_With_Default_Capacity()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsNotNull(_wagon);
            Assert.AreEqual(10, _wagon.MaxSize);
        }

        [TestMethod]
        public void
            When_Animal_Is_Added_Capacity_Is_Lowered() //Mogen namen ook gewoon zoals normale methodes dus MethodeNamenAanElkaar in plaats van Dit_Rare_Gedoe?
        {
            //Arrange
            Animal a = new Animal(Size.Large, Diet.Herbivore);
            int originalCapacity = _wagon.MaxSize;
            int animalSize = (int) a.Size;
            int expectedCapacity = originalCapacity - animalSize;
            // int expectedCapacity = _wagon.MaxSize - (int)a.Size;

            //Act
            _wagon.TryAdd(a);

            //Assert
            Assert.AreEqual(expectedCapacity, _wagon.CurrentSize);
        }

        [TestMethod]
        public void Cant_Add_Herbivore_With_Same_Or_Smaller_Size_To_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium,
                Diet.Carnivore)); //Moet dit gesplitst worden in 2 statements? Mag je aannemen dat dit correct werkt?

            //Act
            //_wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore)));
            //Mag je in de assert checken of de uitgevoerde code true/false teruggeeft of moet je de logic in act zetten en met een exception werken?
        }

        [TestMethod]
        public void Cant_Add_Carnivore_With_Same_Size_Or_Bigger_To_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium, Diet.Herbivore));

            //Act

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Large, Diet.Carnivore)));
        }

        [TestMethod]
        public void Cant_Add_Animals_To_Full_Wagon()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore));
            _wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore));

            //Act

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore)));
        }
    }
}