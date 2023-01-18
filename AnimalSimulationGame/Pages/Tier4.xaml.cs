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

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für Tier4.xaml
    /// </summary>
    public partial class Tier4 : Window
    {
        public Tier4()
        {
            InitializeComponent();
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelection = new AnimalSelection();
            animalSelection.Show();
            this.Close();
        }
    }
}
