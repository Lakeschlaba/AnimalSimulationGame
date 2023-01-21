using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AnimalSimulationGame
{
    class DrittesTier : Animals
    {
        public override void animalSpeak()
        {
            MessageBox.Show("Das dritte Tier bedankt sich bei Dir");
        }
    }
}
