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
    /// Interaktionslogik für Tier1.xaml
    /// </summary>  
    public partial class Tier1 : Window
    {
        public Tier1()
        {
            InitializeComponent();
            gesundheit1.Value = 100;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void Button_Click_Fuettern(object sender, RoutedEventArgs e)
        {
        
        }

        private void Button_Click_Streicheln(object sender, RoutedEventArgs e)
        {

        }
    }
}
