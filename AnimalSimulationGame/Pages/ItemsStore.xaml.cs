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

        public static int unitsAnzahl = 80000;
        public static int futterAnzahl = 5;

        public ItemsStore()
        {
            InitializeComponent();
            unitsAnzahlLabel.Content = unitsAnzahl.ToString();
            futterAnzahlLabel.Content = futterAnzahl.ToString();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsDepot();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void buyFutterBtn_Click(object sender, RoutedEventArgs e)
        {
            futterAnzahl += 1;
            unitsAnzahl -= 50;
            unitsAnzahlLabel.Content = "" + unitsAnzahl.ToString();
            futterAnzahlLabel.Content = "" + futterAnzahl.ToString();
        }

        private void buySpielzeugBajo_Click(object sender, RoutedEventArgs e)
        {
            unitsAnzahl -= 200;
            unitsAnzahlLabel.Content = "" + unitsAnzahl.ToString();
            futterAnzahlLabel.Content = "" + futterAnzahl.ToString();
        }

        public void unitsDepot()
        {
            if(unitsAnzahl < 50)
            {
                buyFutterBtn.IsEnabled = false;
            }

            if(unitsAnzahl < 200)
            {
                buySpielzeugBajo.IsEnabled = false;
            }
        }

        public int UnitsAnzahl
        {
            get { return unitsAnzahl; }
            set { unitsAnzahl = value; }
        }

        public int FutterAnzahl
        {
            get { return futterAnzahl; }
            set { futterAnzahl = value; }
        }

    }

}
