using AnimalSimulationGame.utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaktionslogik für ItemsStore.xaml
    /// </summary>
    public partial class ItemsStore : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public ItemsStore()
        {
            InitializeComponent();
            unitsAnzahlLabel.Content = GameManager.units.ToString();
            futterAnzahlLabel.Content = GameManager.foodAmount.ToString();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsDepot();
            unitsFutterValues();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void buyFutterBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.foodAmount += 1;
            GameManager.units -= 50;
        }

        private void buySpielzeugBajo_Click(object sender, RoutedEventArgs e)
        {
            GameManager.units -= 200;
        }

        public void unitsFutterValues()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units;
        }

        public void unitsDepot()
        {
            if(GameManager.units < 50)
            {
                buyFutterBtn.IsEnabled = false;
            }

            if(GameManager.units < 200)
            {
                buySpielzeugBajo.IsEnabled = false;
            }
        }
    }
}
