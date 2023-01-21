using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.IO;
using AnimalSimulationGame.utils;
using AnimalSimulationGame.AnimalObjects;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für Tier3.xaml
    /// </summary>
    public partial class Tier3: Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timerForRent = new DispatcherTimer();
        Animals drittesTier = new DrittesTier();

        Random random = new Random();

        public Tier3()
        {
            InitializeComponent();

            Console.WriteLine(GameManager.animalsContainer);

            initLabels();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();

            timerForRent.Interval = TimeSpan.FromMinutes(1);
            timerForRent.Tick += t_Tick2;
            timerForRent.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {

            gesundheit1.Value = GameManager.healthAnimal3;
            futter1.Value = GameManager.foodAnimal3;

            drittesTier.health();
            drittesTier.hunger();

            initLabels();
            loadBarnPic();
            loadAnimalPic();
        }

        private void t_Tick2(object sender, EventArgs e)
        {
            drittesTier.rent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelectionWindow = new AnimalSelection();
            animalSelectionWindow.Show();
            this.Close();
        }

        private void feedBtn1_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isFedAnimal3 = true;
            drittesTier.eat();
            GameManager.isFedAnimal3 = false;
            if (GameManager.foodAmount == 0)
            {
                feedBtn1.IsEnabled = false;
            }
        }

        private void streichelnBtn1_Click(object sender, RoutedEventArgs e)
        {
            drittesTier.streicheln();
            drittesTier.hundespielzeug();
        }

        private void initLabels()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units;
        }

        private void loadBarnPic()
        {
            var bitmapWiesenGehege = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/wiesenGehege.png", UriKind.Relative)));

            var bitmapWasserGehege = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/wasserGehege.png", UriKind.Relative)));

            switch (GameManager.barnsContainer[2])
            {
                case "wiesengehege":
                    gehegeImage.Source = bitmapWiesenGehege;
                    break;
                case "wassergehege":
                    gehegeImage.Source = bitmapWasserGehege;
                    break;
            }
        }

        private void loadAnimalPic()
        {
            var dodoBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Dodo.jpg", UriKind.Relative)));

            var wombatBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Wombat.jpg", UriKind.Relative)));

            var opossumBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Opossum.jpg", UriKind.Relative)));

            var kugelfischBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Kugelfisch.jpg", UriKind.Relative)));

            var megalodonBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Megalodon.jpg", UriKind.Relative)));

            var bajoBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Bajo.jpg", UriKind.Relative)));

            switch (GameManager.animalsContainer[2])
            {
                case "dodo":
                    tierImage.Source = dodoBitmap;
                    drittesTier.animalName = "Dodo";
                    animalNameLabel.Content = drittesTier.animalName;
                    break;
                case "wombat":
                    tierImage.Source = wombatBitmap;
                    drittesTier.animalName = "Wombat";
                    animalNameLabel.Content = drittesTier.animalName;
                    break;
                case "opossum":
                    tierImage.Source = opossumBitmap;
                    drittesTier.animalName = "Opossum";
                    animalNameLabel.Content = drittesTier.animalName;
                    break;
                case "kugelfisch":
                    tierImage.Source = kugelfischBitmap;
                    drittesTier.animalName = "Kugelfisch";
                    animalNameLabel.Content = drittesTier.animalName;
                    break;
                case "megalodon":
                    tierImage.Source = megalodonBitmap;
                    drittesTier.animalName = "Megalodon";
                    animalNameLabel.Content = drittesTier.animalName;
                    break;
                case "bajo":
                    tierImage.Source = bajoBitmap;
                    drittesTier.animalName = "Bajo";
                    animalNameLabel.Content = drittesTier.animalName;
                    GameManager.wantsDogToy = true;
                    break;
            }

        }
    }
}

