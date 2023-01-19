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

        public static bool buyAnimal1;
        public static bool buyAnimal2;
        public static bool buyAnimal3;
        public static bool buyAnimal4;
        public static int animalBuyCounter;

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
            checkAnimalBuyCounter();
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
            animalBuyCounter += 1;
            unitsAnzahl -= 500;
            dodoBuyBtn.IsEnabled = false;
            showMaxTiereInfo();
        }

        private void wombatBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            wombatBuy = true;
            animalBuyCounter += 1;
            unitsAnzahl -= 800;
            wombatBuyBtn.IsEnabled = false;
            showMaxTiereInfo();
        }

        private void opossumBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            opossumBuy = true;
            animalBuyCounter += 1;
            unitsAnzahl -= 1000;
            opossumBuyBtn.IsEnabled = false;
            showMaxTiereInfo();
        }

        private void kugelfischBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            kugelfischBuy = true;
            animalBuyCounter += 1;
            unitsAnzahl -= 4000;
            kugelfischBuyBtn.IsEnabled = false;
            showMaxTiereInfo();
        }

        private void megalodonBuybtn_Click(object sender, RoutedEventArgs e)
        {
            megalodonBuy = true;
            animalBuyCounter += 1;
            unitsAnzahl -= 7800;
            megalodonBuybtn.IsEnabled = false;
            showMaxTiereInfo();
        }

        private void bajoBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            bajoBuy = true;
            animalBuyCounter += 1;
            unitsAnzahl -= 10000;
            bajoBuyBtn.IsEnabled = false;
            showMaxTiereInfo();
        }

        public void checkAnimalBuyCounter()
        {

            if(animalBuyCounter == 1)
            {
                buyAnimal1 = true;
            }

            if(animalBuyCounter == 2)
            {
                buyAnimal2 = true;
            }

            if(animalBuyCounter == 3)
            {
                buyAnimal3 = true;
            }

            if(animalBuyCounter == 4)
            {
                buyAnimal4 = true;

                dodoBuyBtn.IsEnabled = false;
                wombatBuyBtn.IsEnabled = false;
                opossumBuyBtn.IsEnabled = false;
                kugelfischBuyBtn.IsEnabled = false;
                megalodonBuybtn.IsEnabled = false;
                bajoBuyBtn.IsEnabled = false;
            }

            if(dodoBuy == true)
            {
                dodoBuyBtn.IsEnabled = false;
            }

            if(wombatBuy == true)
            {
                wombatBuyBtn.IsEnabled = false;
            }

            if (opossumBuy == true)
            {
                opossumBuyBtn.IsEnabled = false;
            }

            if (kugelfischBuy == true)
            {
                kugelfischBuyBtn.IsEnabled = false;
            }

            if (megalodonBuy == true)
            {
                megalodonBuybtn.IsEnabled = false;
            }

            if(bajoBuy == true)
            {
                bajoBuyBtn.IsEnabled = false;
            }
        }

        public void showMaxTiereInfo()
        {
            if (animalBuyCounter == 4)
            {
                MessageBox.Show("Du hast jetzt die maximale Anzahl an Tieren gekauft!");
            }
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
            futterAnzahlLabel.Content = futterAnzahl;
            unitsAnzahlLabel.Content = unitsAnzahl + "$";

            if (unitsAnzahl < 500)
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

        public int AnimaBuyCounter
        {
            get { return animalBuyCounter; }
            set { animalBuyCounter = value; }
        }




        public bool BuyAnimal1
        {
            get { return buyAnimal1; }
            set { buyAnimal1 = value; }
        }

        public bool BuyAnimal2
        {
            get { return buyAnimal2; }
            set { buyAnimal2 = value; }
        }

        public bool BuyAnimal3
        {
            get { return buyAnimal3; }
            set { buyAnimal3 = value; }
        }

        public bool BuyAnimal4
        {
            get { return buyAnimal4; }
            set { buyAnimal4 = value; }
        }

    }
}
