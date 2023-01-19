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
using static AnimalSimulationGame.AnimalStore;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für Tier1.xaml
    /// </summary>  
    public partial class Tier1 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Animals erstesTier = new ErstesTier();
        BarnStore images = new BarnStore();
        AnimalStore animals = new AnimalStore();
        Random random = new Random();
        private bool animalNachricht;

        public Tier1()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            gesundheit1.Value = erstesTier.gesundheitValue;
            futter1.Value = erstesTier.futterValue;
            
            erstesTier.health();
            erstesTier.futterValue -= 0.05;
            gehegeTooTier1();
            animalTooTier1();
            unitsFutterValues();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelection = new AnimalSelection();
            animalSelection.Show();
            this.Close();
        }

        private void feedBtn1_Click(object sender, RoutedEventArgs e)
        {
            erstesTier.eat();

            if(futterAnzahl == 0)
            {
                feedBtn1.IsEnabled= false;
            }
        }

        private void streichelnBtn1_Click(object sender, RoutedEventArgs e)
        {
            animalNachricht = random.Next(2) == 1;

            if(animalNachricht == true)
            {
                erstesTier.animalSpeak();
            }
            erstesTier.streicheln();
        }

        public void gehegeTooTier1()
        {
            bool wiesenGehgeBuy = images.WiesenGehegeBuy;
            var uriWiesenGehege1 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wiesenGehege.png");
            var bitmapWiesenGehege1 = new BitmapImage(uriWiesenGehege1);

            bool wasserGehegeBuy = images.WasserGehegeBuy;
            var uriWasserGehege1 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wasserGehege.png");
            var bitmapWasserGehege1 = new BitmapImage(uriWasserGehege1);

            if (wiesenGehgeBuy == true)
            {
                tier1GehegeImage.Source = bitmapWiesenGehege1;
            }

            if(wasserGehegeBuy == true)
            {
                tier1GehegeImage.Source = bitmapWasserGehege1;
            }
          
        }

        public void animalTooTier1()
        {
            bool dodoBuy = animals.DodoBuy;
            var uriDodoBuy = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Dodo.jpg");
            var bitmapDodoBuy = new BitmapImage(uriDodoBuy);

            bool wombatBuy = animals.WombatBuy;
            var uriWombatBuy = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Wombat.jpg");
            var bitmapWombatBuy = new BitmapImage(uriWombatBuy);

            bool opossumBuy = animals.OpossumBuy;
            var uriOpossumBuy = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Opossum.jpg");
            var bitmapOpossumBuy = new BitmapImage(uriOpossumBuy);

            bool kugelfischBuy = animals.KugelfischBuy;
            var uriKugelfischBuy = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Kugelfisch.jpg");
            var bitmapKugelfischBuy = new BitmapImage(uriKugelfischBuy);

            bool megalodonBuy = animals.MegalodonBuy;
            var uriMegalodonBuy = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Megalodon.jpg");
            var bitmapMegalodonBuy = new BitmapImage(uriMegalodonBuy);

            bool bajoBuy = animals.BajoBuy;
            var uriBajoBuy = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Bajo.jpg");
            var bitmapBajoBuy = new BitmapImage(uriBajoBuy);

            if(animalBuyCounter== 1)
            {
                if (dodoBuy == true)
                {
                    tier1TierImage.Source = bitmapDodoBuy;
                }

                if (wombatBuy == true)
                {
                    tier1TierImage.Source = bitmapWombatBuy;
                }

                if (opossumBuy == true)
                {
                    tier1TierImage.Source = bitmapOpossumBuy;
                }

                if (kugelfischBuy == true)
                {
                    tier1TierImage.Source = bitmapKugelfischBuy;
                }

                if (megalodonBuy == true)
                {
                    tier1TierImage.Source = bitmapMegalodonBuy;
                }

                if (bajoBuy == true)
                {
                    tier1TierImage.Source = bitmapBajoBuy;
                }
            }

           
        }

        public void unitsFutterValues()
        {
            futterAnzahlLabel.Content= futterAnzahl;
            unitsAnzahlLabel.Content= unitsAnzahl;
        }
    }
}
