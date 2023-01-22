using AnimalSimulationGame.utils;
using System;
using System.Windows;
using System.Windows.Threading;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für AnimalsHome.xaml
    /// </summary>
    public partial class AnimalsHome : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public AnimalsHome()
        {
            InitializeComponent();
            checkBarnContainer();

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
            unitsAnzahlLabel.Content = GameManager.units + "$";
            dogToyAnzahlLabel.Content = GameManager.dogToy;
        }

        public void checkBarnContainer()
        {

    

            if(GameManager.isWasserGehegeBuyed || GameManager.isWiesenGehegeBuyed == true)
            {
                AnimalStoreBtn.IsEnabled = true;
            }
            else
            {
                AnimalStoreBtn.IsEnabled = false;
            }
        }
    }
}
