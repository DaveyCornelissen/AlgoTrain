using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrain
{
    public class Animal
    {
        public string name { get; private set; }

        public int Type { get; private set; }

        public int Size { get; private set; }

        public int Capacity { get; private set; }

        public Animal(string naam, string type, string size)
        {
            name = naam;
            Type = getType(type);
            Size = getSize(size);
            Capacity = getCapWeight(Size);
        }

        //gets correct type of new animal
        private int getType(string _size)
        {
            switch (_size)
            {
                case "Carnivore":
                    return 0;
                case "Herbivore":
                    return 1;
                default:
                    return 3;
            }
        }

        //gets correct type of new animal
        private int getSize(string type)
        {
            switch (type)
            {
                case "Big":
                    return 2;
                case "Medium":
                    return 1;
                default:
                    return 0;
            }
        }

        //gets correct capweight of new animal
        private int getCapWeight(int _size)
        {
            switch (_size)
            {
                case 2:
                    return 5;
                case 1:
                    return 3;
                default:
                    return 1;
            }
        }
    }
}
