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
            //Assert
            Assert.IsNotNull(_wagon);
            Assert.AreEqual(10, _wagon.MaxSize);
        }

        [TestMethod]
        public void
            When_Animal_Is_Added_Capacity_Is_Lowered()
        {
            //Arrange
            Animal a = new Animal(Size.Large, Diet.Herbivore);
            int expectedCapacity = _wagon.MaxSize - (int) a.Size;

            //Act
            _wagon.TryAdd(a);

            //Assert
            Assert.AreEqual(expectedCapacity, _wagon.CurrentSize);
        }

        [TestMethod]
        public void Cant_Add_Animals_To_Full_Wagon()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore));
            _wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore)));
        }

        #region Add_Equal_Size_Animals
        [TestMethod]
        public void Cant_Add_Small_Carnivore_To_Small_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Small, Diet.Carnivore)));
        }

        [TestMethod]
        public void Cant_Add_Small_Herbivore_To_Small_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Small, Diet.Carnivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore)));
        }

        [TestMethod]
        public void Cant_Add_Medium_Carnivore_To_Medium_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Medium, Diet.Carnivore)));
        }

        [TestMethod]
        public void Cant_Add_Medium_Herbivore_To_Medium_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium, Diet.Carnivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Medium, Diet.Herbivore)));
        }

        [TestMethod]
        public void Cant_Add_Large_Carnivore_To_Large_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Large, Diet.Carnivore)));
        }

        [TestMethod]
        public void Cant_Add_Large_Herbivore_To_Large_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Carnivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore)));
        }
        #endregion

        #region Add_Bigger_Animal_To_Smaller_Animal
        [TestMethod]
        public void Cant_Add_Medium_Carnivore_To_Small_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Medium, Diet.Carnivore)));
        }

        [TestMethod]
        public void Can_Add_Medium_Herbivore_To_Small_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Small, Diet.Carnivore));

            //Assert
            Assert.IsTrue(_wagon.TryAdd(new Animal(Size.Medium, Diet.Herbivore)));
        }

        [TestMethod]
        public void Cant_Add_Large_Carnivore_To_Small_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Large, Diet.Carnivore)));
        }

        [TestMethod]
        public void Can_Add_Large_Herbivore_To_Small_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Small, Diet.Carnivore));

            //Assert
            Assert.IsTrue(_wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore)));
        }

        [TestMethod]
        public void Cant_Add_Large_Carnivore_To_Medium_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium, Diet.Herbivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Large, Diet.Carnivore)));
        }

        [TestMethod]
        public void Can_Add_Large_Herbivore_To_Medium_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium, Diet.Carnivore));

            //Assert
            Assert.IsTrue(_wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore)));
        }
        #endregion

        #region Add_Smaller_Animal_To_Bigger_Animal

        [TestMethod]
        public void Can_Add_Small_Carnivore_To_Large_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore));

            //Assert
            Assert.IsTrue(_wagon.TryAdd(new Animal(Size.Small, Diet.Carnivore)));
        }

        [TestMethod]
        public void Cant_Add_Small_Herbivore_To_Large_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Carnivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore)));
        }

        [TestMethod]
        public void Can_Add_Medium_Carnivore_To_Large_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Herbivore));

            //Assert
            Assert.IsTrue(_wagon.TryAdd(new Animal(Size.Medium, Diet.Carnivore)));
        }

        [TestMethod]
        public void Cant_Add_Medium_Herbivore_To_Large_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Large, Diet.Carnivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Medium, Diet.Herbivore)));
        }

        [TestMethod]
        public void Can_Add_Small_Carnivore_To_Medium_Herbivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium, Diet.Herbivore));

            //Assert
            Assert.IsTrue(_wagon.TryAdd(new Animal(Size.Small, Diet.Carnivore)));
        }

        [TestMethod]
        public void Cant_Add_Small_Herbivore_To_Medium_Carnivore()
        {
            //Arrange
            _wagon.TryAdd(new Animal(Size.Medium, Diet.Carnivore));

            //Assert
            Assert.IsFalse(_wagon.TryAdd(new Animal(Size.Small, Diet.Herbivore)));
        }
        #endregion
    }
}