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
    /// Interaktionslogik für AnimalsHome.xaml
    /// </summary>
    public partial class AnimalsHome : Window
    {
        public AnimalsHome()
        {
            InitializeComponent();
        }

        private void AnimalStoreBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalStore animalsStore = new AnimalStore();
            animalsStore.Show();
            this.Close();
        }

        private void BarnStore_Click(object sender, RoutedEventArgs e)
        {
            BarnStore barnStore = new BarnStore();
            barnStore.Show();
            this.Close();
        }

        private void AnimalSelection_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelection = new AnimalSelection();
            animalSelection.Show();
            this.Close();
        }

        private void ItemsStore_Click(object sender, RoutedEventArgs e)
        {
            ItemsStore itemsStore = new ItemsStore();
            itemsStore.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
