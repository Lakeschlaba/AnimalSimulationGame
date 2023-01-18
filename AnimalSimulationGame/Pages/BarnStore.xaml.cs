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
    /// Interaktionslogik für BarnStore.xaml
    /// </summary>
    public partial class BarnStore : Window
    {
        public static bool wiesenGehegeBuy;
        public static bool wasserGehegeBuy;

        DispatcherTimer timer = new DispatcherTimer();
        ItemsStore unitsFutter = new ItemsStore();

        public BarnStore()
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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void wiesenGehegeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (wasserGehegeBuy == true)
            {
                wiesenGehegeBuy = false;
            }
            else
            {
                wiesenGehegeBuy = true;
            }
        }

        private void wasserGehegeBtn_Click(object sender, RoutedEventArgs e)
        {
            if(wiesenGehegeBuy == true)
            {
                wasserGehegeBuy = false;
            }
            else
            {
                wasserGehegeBuy = true;
            }
        }

        public bool WiesenGehegeBuy
        {
            get { return wiesenGehegeBuy; }
            set { wiesenGehegeBuy = value; }
        }

        public bool WasserGehegeBuy
        {
            get { return wasserGehegeBuy; }
            set { wasserGehegeBuy = value; }
        }

        public void unitsFutterValues()
        {
            int futterAnzahl = unitsFutter.FutterAnzahl;
            int unitsAnzahl = unitsFutter.UnitsAnzahl;

            futterAnzahlLabel.Content = futterAnzahl;
            unitsAnzahlLabel.Content = unitsAnzahl;

            if(unitsAnzahl < 500)
            {
                wiesenGehegeBtn.IsEnabled = false;
            }

            if(unitsAnzahl < 1000)
            {
                wasserGehegeBtn.IsEnabled = false;
            }
        }

    }
}
