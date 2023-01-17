using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AnimalSimulationGame
{
    public class ErstesTier : Animals
    {
        public override void animalSpeak()
        {
            MessageBox.Show("Danke fürs Strecheln");
        }
    }
}
