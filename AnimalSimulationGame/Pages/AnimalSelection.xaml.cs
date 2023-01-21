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

using static AnimalSimulationGame.utils.GameManager;

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
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
            checkAnimalCount();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterValues();
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

        public void unitsFutterValues()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units;
        }

        public void checkAnimalCount()
        {
            if (animalsContainer.Count == 0 || barnsContainer.Count == 0)
            {
                Tier1.IsEnabled= false;
                Tier2.IsEnabled = false;
                Tier3.IsEnabled = false;
                Tier4.IsEnabled = false;
                MessageBox.Show("Du hast noch kein Tier bzw. Gehege gekauft, änder dies!");
            }

            if (animalsContainer.Count == 1 || barnsContainer.Count == 1)
            {
                Tier2.IsEnabled = false;
                Tier3.IsEnabled = false;
                Tier4.IsEnabled = false;
            }

            if (animalsContainer.Count == 2 || barnsContainer.Count == 2)
            {
                Tier3.IsEnabled = false;
                Tier4.IsEnabled = false;
            }

            if (animalsContainer.Count == 3 || barnsContainer.Count == 3)
            {
                Tier4.IsEnabled = false;
            }

        }
    }
}
