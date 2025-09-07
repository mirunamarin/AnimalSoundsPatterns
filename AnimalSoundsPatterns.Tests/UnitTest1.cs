using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalSoundsPatterns.Animals;
using AnimalSoundsPatterns.Factory;

namespace AnimalSoundsPatterns.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strategy_Dog_Sound_IsWoof()
        {
            IAnimal dog = new Dog();
            Assert.AreEqual("Dog", dog.Type);
            Assert.AreEqual("woof", dog.Sound);
        }

        [TestMethod]
        public void FactoryMethod_CatCreator_CreatesCat()
        {
            var creator = new CatCreator();
            IAnimal animal = creator.Create();

            Assert.IsInstanceOfType(animal, typeof(Cat));
            Assert.AreEqual("Cat", animal.Type);
            Assert.AreEqual("meow", animal.Sound);
        }
    }
}
