using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoTrain
{
    public partial class Form1 : Form
    {
        List<Animal> CurrentAnimals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string animalname = tbName.Text;
            string AnimalType = cbType.SelectedItem.ToString();
            string AnimalSize = cbSize.SelectedItem.ToString();

            Animal _newAnimal = new Animal(animalname, AnimalType, AnimalSize);

            string listAnimal = "Animal Name: " + _newAnimal.name + " Type: " + _newAnimal.Type + " Size: " + _newAnimal.Size;

            CurrentAnimals.Add(_newAnimal);
            lbAnimals.Items.Add(listAnimal);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RunAlgoritem();
        }

        private void RunAlgoritem()
        {
            Train NewTrain = new Train();
            NewTrain.AllAnimals = CurrentAnimals;
            NewTrain.TrainLoop();

            lblResult.Text = NewTrain.Wagons.Count.ToString();

            foreach (Wagon WagoninTrain in NewTrain.Wagons)
            {
                string  listAnimal = "Animals Total: " + WagoninTrain.AnimalsInWagon.Count + " - Capacity: " + WagoninTrain.WagonCapacity + " - Contains carnivore: " + WagoninTrain.containCarnivore + "- IsFull: " + WagoninTrain.isFull;

                lbWagonList.Items.Add(listAnimal);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset all labels and cb/tb
            cbSize.Text = "";
            cbType.Text = "";
            tbName.Text = "";
            lblResult.Text = "...";

            lbAnimals.Items.Clear();
            lbWagonList.Items.Clear();

            //empty the Animal list
            CurrentAnimals.Clear();
        }
    }
}
