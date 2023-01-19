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
    /// Interaktionslogik für Tier4.xaml
    /// </summary>
    public partial class Tier4 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        ItemsStore unitsFutter = new ItemsStore();
        BarnStore images = new BarnStore();
        AnimalStore animals = new AnimalStore();
        public Tier4()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterValues();
            gehegeTooTier4();
            animalTooTier4();
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

        public void gehegeTooTier4()
        {
            bool wiesenGehgeBuy4 = images.WiesenGehegeBuy4;
            var uriWiesenGehege4 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wiesenGehege.png");
            var bitmapWiesenGehege4 = new BitmapImage(uriWiesenGehege4);


            bool wasserGehegeBuy4 = images.WasserGehegeBuy4;
            var uriWasserGehege4 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wasserGehege.png");
            var bitmapWasserGehege4 = new BitmapImage(uriWasserGehege4);

            if (wiesenGehgeBuy4 == true)
            {
                tier1GehegeImage.Source = bitmapWiesenGehege4;
            }

            if (wasserGehegeBuy4 == true)
            {
                tier1GehegeImage.Source = bitmapWasserGehege4;
            }

        }

        public void animalTooTier4()
        {
            bool dodoBuy4 = animals.DodoBuy;
            var uriDodoBuy4 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Dodo.jpg");
            var bitmapDodoBuy4 = new BitmapImage(uriDodoBuy4);

            bool wombatBuy4 = animals.WombatBuy;
            var uriWombatBuy4 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Wombat.jpg");
            var bitmapWombatBuy4 = new BitmapImage(uriWombatBuy4);

            bool opossumBuy4 = animals.OpossumBuy;
            var uriOpossumBuy4 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Opossum.jpg");
            var bitmapOpossumBuy4 = new BitmapImage(uriOpossumBuy4);

            bool kugelfischBuy4 = animals.KugelfischBuy;
            var uriKugelfischBuy4 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Kugelfisch.jpg");
            var bitmapKugelfischBuy4 = new BitmapImage(uriKugelfischBuy4);

            bool megalodonBuy4 = animals.MegalodonBuy;
            var uriMegalodonBuy4 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Megalodon.jpg");
            var bitmapMegalodonBuy4 = new BitmapImage(uriMegalodonBuy4);

            bool bajoBuy4 = animals.BajoBuy;
            var uriBajoBuy4 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Bajo.jpg");
            var bitmapBajoBuy4 = new BitmapImage(uriBajoBuy4);

            if (animalBuyCounter == 4)
            {
                if (dodoBuy4 == true)
                {
                    tier1TierImage.Source = bitmapDodoBuy4;
                }

                if (wombatBuy4 == true)
                {
                    tier1TierImage.Source = bitmapWombatBuy4;
                }

                if (opossumBuy4 == true)
                {
                    tier1TierImage.Source = bitmapOpossumBuy4;
                }

                if (kugelfischBuy4 == true)
                {
                    tier1TierImage.Source = bitmapKugelfischBuy4;
                }

                if (megalodonBuy4 == true)
                {
                    tier1TierImage.Source = bitmapMegalodonBuy4;
                }

                if (bajoBuy4 == true)
                {
                    tier1TierImage.Source = bitmapBajoBuy4;
                }
            }
        }
    }
}
