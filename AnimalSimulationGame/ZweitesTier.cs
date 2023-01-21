using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AnimalSimulationGame
{
    class ZweitesTier : Animals
    {
        public override void animalSpeak()
        {
            MessageBox.Show("Das zweite Tier bedankt sich bei Dir");
        }
    }
}
