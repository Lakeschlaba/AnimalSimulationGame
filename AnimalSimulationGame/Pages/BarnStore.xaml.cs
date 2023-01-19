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
using static AnimalSimulationGame.ItemsStore;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für BarnStore.xaml
    /// </summary>
    public partial class BarnStore : Window
    {
        public static bool wiesenGehegeBuy;
        public static bool wiesenGehegeBuy2;
        public static bool wiesenGehegeBuy3;
        public static bool wiesenGehegeBuy4;

        public static bool wasserGehegeBuy;
        public static bool wasserGehegeBuy2;
        public static bool wasserGehegeBuy3;
        public static bool wasserGehegeBuy4;

        public static int gehegeBuyCounter;

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
            checkWiesenGehegeCount();
            checkWasserGehegeCount();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void wiesenGehegeBtn_Click(object sender, RoutedEventArgs e)
        {
            gehegeBuyCounter += 1;
            showMaxGehegeInfo();
            unitsAnzahl -= 500;
        }

        private void wasserGehegeBtn_Click(object sender, RoutedEventArgs e)
        {
            gehegeBuyCounter += 1;
            showMaxGehegeInfo();
            unitsAnzahl -= 1000;
        }

        public void checkWiesenGehegeCount()
        {

            if (gehegeBuyCounter == 1)
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

            if (gehegeBuyCounter == 2)
            {
                if (wasserGehegeBuy2 == true)
                {
                    wiesenGehegeBuy2 = false;
                }
                else
                {
                    wiesenGehegeBuy2 = true;
                }
            }

            if (gehegeBuyCounter == 3)
            {
                if (wasserGehegeBuy3 == true)
                {
                    wiesenGehegeBuy3 = false;
                }
                else
                {
                    wiesenGehegeBuy3 = true;
                }
            }

            if (gehegeBuyCounter == 4)
            {
                if (wasserGehegeBuy4 == true)
                {
                    wiesenGehegeBuy4 = false;
                }
                else
                {
                    wiesenGehegeBuy4 = true;
                }

                wiesenGehegeBtn.IsEnabled = false;
                wasserGehegeBtn.IsEnabled = false;
            }
        }

        public void checkWasserGehegeCount()
        {
            if (gehegeBuyCounter == 1)
            {
                if (wiesenGehegeBuy == true)
                {
                    wasserGehegeBuy = false;
                }
                else
                {
                    wasserGehegeBuy = true;
                }

            }

            if (gehegeBuyCounter == 2)
            {
                if (wiesenGehegeBuy2 == true)
                {
                    wasserGehegeBuy2 = false;
                }
                else
                {
                    wasserGehegeBuy2 = true;
                }
            }

            if (gehegeBuyCounter == 3)
            {
                if (wiesenGehegeBuy3 == true)
                {
                    wasserGehegeBuy3 = false;
                }
                else
                {
                    wasserGehegeBuy3 = true;
                }
            }

            if (gehegeBuyCounter == 4)
            {
                if (wiesenGehegeBuy4 == true)
                {
                    wasserGehegeBuy4 = false;
                }
                else
                {
                    wasserGehegeBuy4 = true;
                }

                wiesenGehegeBtn.IsEnabled = false;
                wasserGehegeBtn.IsEnabled = false;
            }
        }

        public void showMaxGehegeInfo()
        {   
            if(gehegeBuyCounter == 4)
            {
                MessageBox.Show("Du hast jetzt die maximale Anzahl an Gehegen gekauft!");
            }
        }

        public bool WiesenGehegeBuy
        {
            get { return wiesenGehegeBuy; }
            set { wiesenGehegeBuy = value; }
        }

        public bool WiesenGehegeBuy2
        {
            get { return wiesenGehegeBuy2; }
            set { wiesenGehegeBuy2 = value; }
        }

        public bool WiesenGehegeBuy3
        {
            get { return wiesenGehegeBuy3; }
            set { wiesenGehegeBuy3 = value; }
        }

        public bool WiesenGehegeBuy4
        {
            get { return wiesenGehegeBuy4; }
            set { wiesenGehegeBuy4 = value; }
        }






        public bool WasserGehegeBuy
        {
            get { return wasserGehegeBuy; }
            set { wasserGehegeBuy = value; }
        }

        public bool WasserGehegeBuy2
        {
            get { return wasserGehegeBuy2; }
            set { wasserGehegeBuy2 = value; }
        }

        public bool WasserGehegeBuy3
        {
            get { return wasserGehegeBuy3; }
            set { wasserGehegeBuy3 = value; }
        }

        public bool WasserGehegeBuy4
        {
            get { return wasserGehegeBuy4; }
            set { wasserGehegeBuy4 = value; }
        }

        public void unitsFutterValues()
        {
            futterAnzahlLabel.Content = futterAnzahl;
            unitsAnzahlLabel.Content = unitsAnzahl;

            if (unitsAnzahl < 500)
            {
                wiesenGehegeBtn.IsEnabled = false;
            }

            if(unitsAnzahl < 1000)
            {
                wasserGehegeBtn.IsEnabled = false;
            }

        }

        public int GehegeBuyCounter
        {
            get { return gehegeBuyCounter; }
            set { gehegeBuyCounter = value; }
        }


    }
}
