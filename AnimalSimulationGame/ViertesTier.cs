using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AnimalSimulationGame
{
    class ViertesTier : Animals
    {
        public override void animalSpeak()
        {
            MessageBox.Show("Das vierte Tier bedankt sich bei Dir");
        }
    }
}
