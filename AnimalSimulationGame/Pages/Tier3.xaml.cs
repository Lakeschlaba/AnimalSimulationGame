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
using static AnimalSimulationGame.MainWindow;
using static System.Net.Mime.MediaTypeNames;
using static AnimalSimulationGame.AnimalStore;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für Tier3.xaml
    /// </summary>
    public partial class Tier3 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        ItemsStore unitsFutter = new ItemsStore();
        BarnStore images = new BarnStore();
        AnimalStore animals = new AnimalStore();
        public Tier3()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterValues();
            gehegeTooTier3();
            animalTooTier3();
        }


        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelection = new AnimalSelection();
            animalSelection.Show();
            this.Close();
        }

        public void unitsFutterValues()
        {
            int futterAnzahl = unitsFutter.FutterAnzahl;
            int unitsAnzahl = unitsFutter.UnitsAnzahl;

            futterAnzahlLabel.Content = futterAnzahl;
            unitsAnzahlLabel.Content = unitsAnzahl;
        }

        public void gehegeTooTier3()
        {
            bool wiesenGehgeBuy3 = images.WiesenGehegeBuy3;
            var uriWiesenGehege3 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wiesenGehege.png");
            var bitmapWiesenGehege3 = new BitmapImage(uriWiesenGehege3);


            bool wasserGehegeBuy3 = images.WasserGehegeBuy3;
            var uriWasserGehege3 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wasserGehege.png");
            var bitmapWasserGehege3 = new BitmapImage(uriWasserGehege3);

            if (wiesenGehgeBuy3 == true)
            {
                tier1GehegeImage.Source = bitmapWiesenGehege3;
            }

            if (wasserGehegeBuy3 == true)
            {
                tier1GehegeImage.Source = bitmapWasserGehege3;
            }

        }

        public void animalTooTier3()
        {
            bool dodoBuy3 = animals.DodoBuy;
            var uriDodoBuy3 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Dodo.jpg");
            var bitmapDodoBuy3 = new BitmapImage(uriDodoBuy3);

            bool wombatBuy3 = animals.WombatBuy;
            var uriWombatBuy3 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Wombat.jpg");
            var bitmapWombatBuy3 = new BitmapImage(uriWombatBuy3);

            bool opossumBuy3 = animals.OpossumBuy;
            var uriOpossumBuy3 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Opossum.jpg");
            var bitmapOpossumBuy3 = new BitmapImage(uriOpossumBuy3);

            bool kugelfischBuy3 = animals.KugelfischBuy;
            var uriKugelfischBuy3 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Kugelfisch.jpg");
            var bitmapKugelfischBuy3 = new BitmapImage(uriKugelfischBuy3);

            bool megalodonBuy3 = animals.MegalodonBuy;
            var uriMegalodonBuy3 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Megalodon.jpg");
            var bitmapMegalodonBuy3 = new BitmapImage(uriMegalodonBuy3);

            bool bajoBuy3 = animals.BajoBuy;
            var uriBajoBuy3 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Bajo.jpg");
            var bitmapBajoBuy3 = new BitmapImage(uriBajoBuy3);

            if (animalBuyCounter == 3)
            {
                if (dodoBuy3 == true)
                {
                    tier1TierImage.Source = bitmapDodoBuy3;
                }

                if (wombatBuy3 == true)
                {
                    tier1TierImage.Source = bitmapWombatBuy3;
                }

                if (opossumBuy3 == true)
                {
                    tier1TierImage.Source = bitmapOpossumBuy3;
                }

                if (kugelfischBuy3 == true)
                {
                    tier1TierImage.Source = bitmapKugelfischBuy3;
                }

                if (megalodonBuy3 == true)
                {
                    tier1TierImage.Source = bitmapMegalodonBuy3;
                }

                if (bajoBuy3 == true)
                {
                    tier1TierImage.Source = bitmapBajoBuy3;
                }
            }
        }

    }
}
