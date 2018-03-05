using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrain
{
    public class Wagon
    {
        public List<Animal> AnimalsInWagon { get; private set; }

        public int WagonCapacity { get; private set; }

        public bool containCarnivore { get; private set; }

        public bool isFull { get; set; }

        public void AddAnimalToWagon(Animal _newAnimal)
        {
            if (AnimalsInWagon == null)
                AnimalsInWagon = new List<Animal>();

            AnimalsInWagon.Add(_newAnimal);
            WagonCapacity += _newAnimal.Capacity;
            if (_newAnimal.Type == 0)
                containCarnivore = true;
        }
    }
}
