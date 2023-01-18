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
    /// Interaktionslogik für AnimalStore.xaml
    /// </summary>
    public partial class AnimalStore : Window
    {
        public static bool dodoBuy;
        public static bool wombatBuy;
        public static bool opossumBuy;
        public static bool kugelfischBuy;
        public static bool megalodonBuy;
        public static bool bajoBuy;

        DispatcherTimer timer = new DispatcherTimer();
        ItemsStore unitsFutter = new ItemsStore();
        public AnimalStore()
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

        private void dodoBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            dodoBuy = true;
        }

        private void wombatBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            wombatBuy = true;
        }

        private void opossumBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            opossumBuy = true;
        }

        private void kugelfischBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            kugelfischBuy = true;
        }

        private void megalodonBuybtn_Click(object sender, RoutedEventArgs e)
        {
            megalodonBuy = true;
        }

        private void bajoBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            bajoBuy = true;
        }

        public bool DodoBuy
        {
            get { return dodoBuy; }
            set { dodoBuy = value; }
        }
        public bool WombatBuy
        {
            get { return wombatBuy; }
            set { wombatBuy = value; }
        }
        public bool OpossumBuy
        {
            get { return opossumBuy; }
            set { opossumBuy = value; }
        }
        public bool KugelfischBuy
        {
            get { return kugelfischBuy; }
            set { kugelfischBuy = value; }
        }
        public bool MegalodonBuy
        {
            get { return megalodonBuy; }
            set { megalodonBuy = value; }
        }
        public bool BajoBuy
        {
            get { return bajoBuy; }
            set { bajoBuy = value; }
        }

        public void unitsFutterValues()
        {
            int futterAnzahl = unitsFutter.FutterAnzahl;
            int unitsAnzahl = unitsFutter.UnitsAnzahl;

            futterAnzahlLabel.Content = futterAnzahl;
            unitsAnzahlLabel.Content = unitsAnzahl;

            if(unitsAnzahl < 500)
            {
                dodoBuyBtn.IsEnabled = false;
            }

            if (unitsAnzahl < 800)
            {
                wombatBuyBtn.IsEnabled = false;
            }

            if (unitsAnzahl < 1000)
            {
                opossumBuyBtn.IsEnabled = false;
            }

            if (unitsAnzahl < 4000)
            {
                kugelfischBuyBtn.IsEnabled = false;
            }

            if (unitsAnzahl < 7800)
            {
                megalodonBuybtn.IsEnabled = false;
            }

            if (unitsAnzahl < 10000)
            {
                bajoBuyBtn.IsEnabled = false;
            }
        }

    }
}
