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
    /// Interaktionslogik für AnimalSelection.xaml
    /// </summary>
    public partial class AnimalSelection : Window
    {
        public AnimalSelection()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Tier1_Click(object sender, RoutedEventArgs e)
        {
            Tier1 tier1Window = new Tier1();
            tier1Window.Show();
            this.Close();
        }

        private void Tier2_Click(object sender, RoutedEventArgs e)
        {
            Tier2 tier2Window = new Tier2();
            tier2Window.Show();
            this.Close();
        }

        private void Tier3_Click(object sender, RoutedEventArgs e)
        {
            Tier3 tier3Window = new Tier3();
            tier3Window.Show();
            this.Close();
        }

        private void Tier4_Click(object sender, RoutedEventArgs e)
        {
            Tier4 tier4Window = new Tier4();
            tier4Window.Show();
            this.Close();
        }
    }
}
