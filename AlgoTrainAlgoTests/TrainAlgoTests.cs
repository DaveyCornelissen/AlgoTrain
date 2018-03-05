using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoTrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrain.AlgoTests
{
    [TestClass()]
    public class TrainAlgoTests
    {
        private List<Animal> TestAnimals;

        private Train SetTest()
        {
            TestAnimals = new List<Animal>();
            Train testTrain = new Train();

            for (int i = 0; i < 5; i++)
            {
                TestAnimals.Add(new Animal("Test","Carnivore","Big"));
            }

            testTrain.AllAnimals = TestAnimals;
            testTrain.TrainLoop();

            return testTrain;
        }

        [TestMethod()]
        public void CheckAlgoritme()
        {
            //Setup the tests
            Train testTrain = SetTest();

            int result = testTrain.Wagons.Count;

            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void CheckwagonCap()
        {
            //Setup the tests
            Train testTrain = SetTest();

            int result = testTrain.Wagons[1].WagonCapacity;

            Assert.AreEqual(5, result);
        }

    }
}