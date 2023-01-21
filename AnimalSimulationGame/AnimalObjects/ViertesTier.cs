using AnimalSimulationGame.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AnimalSimulationGame.AnimalObjects
{
    class ViertesTier : Animals
    {
        public override void animalSpeak()
        {
            MessageBox.Show(animalName + " bedankt sich bei Dir!");
        }

        public override void rent()
        {
            GameManager.units += 200;
            MessageBox.Show("Die Miete wurde bezahlt! " + animalName + " überweist dir 200$");
        }
    }
}
