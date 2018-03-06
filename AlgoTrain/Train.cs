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
                        bool addAnimal = SelectedWagon.CheckIfAnimalFit(SelectedWagon, SelectedAnimal);

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
