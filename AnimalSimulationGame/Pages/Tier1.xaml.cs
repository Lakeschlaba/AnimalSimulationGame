using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using AnimalSimulationGame.utils;
using AnimalSimulationGame.AnimalObjects;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für Tier1.xaml
    /// </summary>  
    public partial class Tier1 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timerForRent = new DispatcherTimer();

        Random random = new Random();

        Animals erstesTier = new ErstesTier();

        public Tier1()
        {
            InitializeComponent();
            initValues();

            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();

            timerForRent.Interval = TimeSpan.FromMinutes(1.5);
            timerForRent.Tick += t_Tick2;
            timerForRent.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            erstesTier.health();
            erstesTier.hunger();
            erstesTier.streicheln();

            initValues();
            loadBarnPic();
            loadAnimalPic();
        }

        private void t_Tick2(object sender, EventArgs e)
        {
            erstesTier.rent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelectionWindow = new AnimalSelection();
            animalSelectionWindow.Show();
            timer.Stop();
            timerForRent.Stop();
            this.Close();
        }

        private void feedBtn1_Click(object sender, RoutedEventArgs e)
        {
            erstesTier.eat();
            if (GameManager.foodAmount <= 0)
            {
                MessageBox.Show("Du musst Universal-Futter kaufen!");
                feedBtn1.IsEnabled = false;
            }
        }

        private void streichelnBtn1_Click(object sender, RoutedEventArgs e)
        {
            erstesTier.streicheln();
            if (GameManager.wantsStroked1 == false)
            {
                MessageBox.Show("Dein " + erstesTier.animalName + " muss glücklich sein. Um dies zu sein, braucht es Futter!");
                streichelnBtn1.IsEnabled = false;
            }
            else
            {
                streichelnBtn1.IsEnabled = true;
                GameManager.randomChoose = random.Next(5) == 1;

                if(GameManager.randomChoose == true)
                {
                    erstesTier.animalSpeak();
                }
            }
            erstesTier.hundespielzeug();
        }

        private void initValues()
        {
            gesundheit1.Value = GameManager.healthAnimal1;
            futter1.Value = GameManager.foodAnimal1;

            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units + "$";
            dogToyAnzahlLabel.Content = GameManager.dogToy;
        }

        private void loadBarnPic()
        {
            var bitmapWiesenGehege = new BitmapImage(new Uri("pack://application:,,,/Images/wiesenGehege.png"));

            var bitmapWasserGehege = new BitmapImage(new Uri("pack://application:,,,/Images/wasserGehege.png"));

            switch (GameManager.barnsContainer[0])
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
            var dodoBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Dodo.jpg"));

            var wombatBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Wombat.jpg"));

            var opossumBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Opossum.jpg"));

            var kugelfischBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Kugelfisch.jpg"));

            var megalodonBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Megalodon.jpg"));

            var bajoBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Bajo.jpg"));

            switch (GameManager.animalsContainer[0])
            {
                case "dodo":
                    tierImage.Source = dodoBitmap;
                    erstesTier.animalName = "Dodo";
                    animalNameLabel.Content= erstesTier.animalName;
                    break;
                case "wombat":
                    tierImage.Source = wombatBitmap;
                    erstesTier.animalName = "Wombat";
                    animalNameLabel.Content = erstesTier.animalName;
                    break;
                case "opossum":
                    tierImage.Source = opossumBitmap;
                    erstesTier.animalName = "Opossum";
                    animalNameLabel.Content = erstesTier.animalName;
                    break;
                case "kugelfisch":
                    tierImage.Source = kugelfischBitmap;
                    erstesTier.animalName = "Kugelfisch";
                    animalNameLabel.Content = erstesTier.animalName;
                    break;
                case "megalodon":
                    tierImage.Source = megalodonBitmap;
                    erstesTier.animalName = "Megalodon";
                    animalNameLabel.Content = erstesTier.animalName;
                    break;
                case "bajo":
                    tierImage.Source = bajoBitmap;
                    erstesTier.animalName = "Bajo";
                    animalNameLabel.Content = erstesTier.animalName;
                    GameManager.wantsDogToy = true;
                    break;
            }
        }
    }
}
