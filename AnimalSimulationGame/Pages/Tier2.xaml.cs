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
    /// Interaktionslogik für Tier2.xaml
    /// </summary>
    public partial class Tier2 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        ItemsStore unitsFutter = new ItemsStore();
        BarnStore images = new BarnStore();
        AnimalStore animals = new AnimalStore();
        public Tier2()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterValues();
            gehegeTooTier2();
            animalTooTier2();
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

        public void gehegeTooTier2()
        {
            bool wiesenGehgeBuy2 = images.WiesenGehegeBuy2;
            var uriWiesenGehege2 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wiesenGehege.png");
            var bitmapWiesenGehege2 = new BitmapImage(uriWiesenGehege2);


            bool wasserGehegeBuy2 = images.WasserGehegeBuy2;
            var uriWasserGehege2 = new Uri("C:/Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//wasserGehege.png");
            var bitmapWasserGehege2 = new BitmapImage(uriWasserGehege2);

            if (wiesenGehgeBuy2 == true)
            {
                tier1GehegeImage.Source = bitmapWiesenGehege2;
            }

            if (wasserGehegeBuy2 == true)
            {
                tier1GehegeImage.Source = bitmapWasserGehege2;
            }

        }

        public void animalTooTier2()
        {
            bool dodoBuy2 = animals.DodoBuy;
            var uriDodoBuy2 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Dodo.jpg");
            var bitmapDodoBuy2 = new BitmapImage(uriDodoBuy2);

            bool wombatBuy2 = animals.WombatBuy;
            var uriWombatBuy2 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Wombat.jpg");
            var bitmapWombatBuy2 = new BitmapImage(uriWombatBuy2);

            bool opossumBuy2 = animals.OpossumBuy;
            var uriOpossumBuy2 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Opossum.jpg");
            var bitmapOpossumBuy2 = new BitmapImage(uriOpossumBuy2);

            bool kugelfischBuy2 = animals.KugelfischBuy;
            var uriKugelfischBuy2 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Kugelfisch.jpg");
            var bitmapKugelfischBuy2 = new BitmapImage(uriKugelfischBuy2);

            bool megalodonBuy2 = animals.MegalodonBuy;
            var uriMegalodonBuy2 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Megalodon.jpg");
            var bitmapMegalodonBuy2 = new BitmapImage(uriMegalodonBuy2);

            bool bajoBuy2 = animals.BajoBuy;
            var uriBajoBuy2 = new Uri("C://Users//gereo//Documents//ProgrammeC#//AnimalSimulationGame//AnimalSimulationGame//Images//Bajo.jpg");
            var bitmapBajoBuy2 = new BitmapImage(uriBajoBuy2);

            if (animalBuyCounter == 2)
            {
                if (dodoBuy2 == true)
                {
                    tier1TierImage.Source = bitmapDodoBuy2;
                }

                if (wombatBuy2 == true)
                {
                    tier1TierImage.Source = bitmapWombatBuy2;
                }

                if (opossumBuy2 == true)
                {
                    tier1TierImage.Source = bitmapOpossumBuy2;
                }

                if (kugelfischBuy2 == true)
                {
                    tier1TierImage.Source = bitmapKugelfischBuy2;
                }

                if (megalodonBuy2 == true)
                {
                    tier1TierImage.Source = bitmapMegalodonBuy2;
                }

                if (bajoBuy2 == true)
                {
                    tier1TierImage.Source = bitmapBajoBuy2;
                }
            }
        }

    }
}
