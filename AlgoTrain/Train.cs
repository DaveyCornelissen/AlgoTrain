using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrain
{
    public class Train
    {
        public List<Wagon> Wagons { get; private set; }

        public List<Animal> AllAnimals { get; set; }

        //Main loop
        public void TrainLoop()
        {
            while (!IsAnimalListEmpty())
            {
                Wagon SelectedWagon = FindNewWagon();

                foreach (Animal SelectedAnimal in AllAnimals.ToList())
                {
                    //for if the list of animas in wagons is null
                    if (SelectedWagon.WagonCapacity == 0)
                    {
                        SelectedWagon.AddAnimalToWagon(SelectedAnimal);
                        AllAnimals.Remove(SelectedAnimal);
                    }
                    else
                    {
                        bool addAnimal = CheckIfAnimalFit(SelectedWagon, SelectedAnimal);

                        if (addAnimal)
                        {
                            SelectedWagon.AddAnimalToWagon(SelectedAnimal);
                            AllAnimals.Remove(SelectedAnimal);
                        }
                    }
                }
                SelectedWagon.isFull = true;
            }
        }

        //acutale algoritem
        private bool CheckIfAnimalFit(Wagon _selectedWagon, Animal _selectedAnimal)
        {
            var condition = _selectedWagon.AnimalsInWagon.Where(a => (a.Size >= _selectedAnimal.Size || a.Size <= _selectedAnimal.Size) && a.Type == 0);
            int _cap = _selectedWagon.WagonCapacity;

            bool fitAnimal = condition.ToList().Count == 0 &&
                             (_cap += _selectedAnimal.Capacity) <= 10;
            return fitAnimal;
        }

        private Wagon FindNewWagon()
        {
            if (Wagons == null)
                Wagons = new List<Wagon>();

            Wagon _newWagon = new Wagon();
            Wagons.Add(_newWagon);
            return _newWagon;
        }

        //check if the animal list is empty
        private bool IsAnimalListEmpty()
        {
            int listCount = AllAnimals.Count;
            return listCount == 0 ? true : false;
        }

    }
}
