using AnimalSimulationGame.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AnimalSimulationGame.AnimalObjects
{
    class ZweitesTier : Animals
    {
        public override void animalSpeak()
        {
            MessageBox.Show(animalName + " bedankt sich bei Dir!");
        }

        public override void rent()
        {
            GameManager.units += 100;
            MessageBox.Show("Die Miete wurde bezahlt! " + animalName + " überweist dir 100$");
        }
    }
}
