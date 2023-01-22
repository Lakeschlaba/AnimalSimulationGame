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
            unitsFoodValues();
        }

        private void AnimalStoreBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalStore animalsStore = new AnimalStore();
            animalsStore.Show();
            this.Close();
        }

        private void BarnStoreBtn_Click(object sender, RoutedEventArgs e)
        {
            BarnStore barnStore = new BarnStore();
            barnStore.Show();
            this.Close();
        }

        private void AnimalSelectionBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelection = new AnimalSelection();
            animalSelection.Show();
            this.Close();
        }

        private void ItemsStoreBtn_Click(object sender, RoutedEventArgs e)
        {
            ItemsStore itemsStore = new ItemsStore();
            itemsStore.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void unitsFoodValues()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units + "$";
            dogToyAnzahlLabel.Content = GameManager.dogToy;
        }

        private void checkBarnContainer()
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
