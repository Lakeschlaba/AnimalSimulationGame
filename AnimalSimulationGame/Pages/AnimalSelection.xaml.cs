using AnimalSimulationGame.utils;
using System;
using System.Windows;
using System.Windows.Threading;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für AnimalSelection.xaml
    /// </summary>
    public partial class AnimalSelection : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public AnimalSelection()
        {
            InitializeComponent();
            checkAnimalCount();

            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFoodalues();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Tier1Btn_Click(object sender, RoutedEventArgs e)
        {
            Tier1 tier1Window = new Tier1();
            tier1Window.Show();
            this.Close();
        }

        private void Tier2Btn_Click(object sender, RoutedEventArgs e)
        {
            Tier2 tier2Window = new Tier2();
            tier2Window.Show();
            this.Close();
        }

        private void Tier3Btn_Click(object sender, RoutedEventArgs e)
        {
            Tier3 tier3Window = new Tier3();
            tier3Window.Show();
            this.Close();
        }

        private void Tier4Btn_Click(object sender, RoutedEventArgs e)
        {
            Tier4 tier4Window = new Tier4();
            tier4Window.Show();
            this.Close();
        }

        private void unitsFoodalues()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units + "$";
            dogToyAnzahlLabel.Content = GameManager.dogToy;
        }

        private void checkAnimalCount()
        {
            if (GameManager.animalsContainer.Count == 0 || GameManager.barnsContainer.Count == 0)
            {
                Tier1.IsEnabled= false;
                Tier2.IsEnabled = false;
                Tier3.IsEnabled = false;
                Tier4.IsEnabled = false;
                MessageBox.Show("Du hast noch kein Tier bzw. Gehege gekauft, änder dies!");
            }

            if (GameManager.animalsContainer.Count == 1 || GameManager.barnsContainer.Count == 1)
            {
                Tier2.IsEnabled = false;
                Tier3.IsEnabled = false;
                Tier4.IsEnabled = false;
            }

            if (GameManager.animalsContainer.Count == 2 || GameManager.barnsContainer.Count == 2)
            {
                Tier3.IsEnabled = false;
                Tier4.IsEnabled = false;
            }

            if (GameManager.animalsContainer.Count == 3 || GameManager.barnsContainer.Count == 3)
            {
                Tier4.IsEnabled = false;
            }

        }
    }
}
