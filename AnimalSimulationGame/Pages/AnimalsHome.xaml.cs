using AnimalSimulationGame.utils;
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
    /// <summary>
    /// Interaktionslogik für AnimalsHome.xaml
    /// </summary>
    public partial class AnimalsHome : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        ItemsStore unitsFutter = new ItemsStore();
        public AnimalsHome()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterValues();
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
            Application.Current.Shutdown();
        }

        public void unitsFutterValues()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units;
        }
    }
}
