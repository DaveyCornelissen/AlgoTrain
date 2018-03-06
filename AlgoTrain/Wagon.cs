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

        //acutale algoritem
        public bool CheckIfAnimalFit(Wagon _selectedWagon, Animal _selectedAnimal)
        {
            var condition = _selectedWagon.AnimalsInWagon.Where(a => (a.Size >= _selectedAnimal.Size || a.Size <= _selectedAnimal.Size) && a.Type == 0);
            int _cap = _selectedWagon.WagonCapacity;

            bool fitAnimal = condition.ToList().Count == 0 &&
                             (_cap += _selectedAnimal.Capacity) <= 10;
            return fitAnimal;
        }

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
