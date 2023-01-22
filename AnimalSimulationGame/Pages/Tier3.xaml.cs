using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
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

        Random random = new Random();

        Animals drittesTier = new DrittesTier();

        public Tier3()
        {
            InitializeComponent();

            initLabels();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();

            timerForRent.Interval = TimeSpan.FromMinutes(1.5);
            timerForRent.Tick += t_Tick2;
            timerForRent.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {

            gesundheit3.Value = GameManager.healthAnimal3;
            futter3.Value = GameManager.foodAnimal3;

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
            timer.Stop();
            timerForRent.Stop();
            this.Close();
        }

        private void feedBtn3_Click(object sender, RoutedEventArgs e)
        {
            drittesTier.eat();
            if (GameManager.foodAmount <= 0)
            {
                MessageBox.Show("Du musst Universal-Futter kaufen!");
                feedBtn3.IsEnabled = false;
            }
        }

        private void streichelnBtn3_Click(object sender, RoutedEventArgs e)
        {
            drittesTier.streicheln();
            if (GameManager.wantsStroked3 == false)
            {
                MessageBox.Show("Dein " + drittesTier.animalName + " muss glücklich sein. Um dies zu sein, braucht es Futter!");
                streichelnBtn3.IsEnabled = false;
            }
            else
            {
                streichelnBtn3.IsEnabled = true;
                GameManager.randomChoose = random.Next(5) == 1;

                if (GameManager.randomChoose == true)
                {
                    drittesTier.animalSpeak();
                }
            }
            drittesTier.hundespielzeug();
        }

        private void initLabels()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units + "$";
        }

        private void loadBarnPic()
        {
            var bitmapWiesenGehege = new BitmapImage(new Uri("pack://application:,,,/Images/wiesenGehege.png"));

            var bitmapWasserGehege = new BitmapImage(new Uri("pack://application:,,,/Images/wasserGehege.png"));

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
            var dodoBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Dodo.jpg"));

            var wombatBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Wombat.jpg"));

            var opossumBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Opossum.jpg"));

            var kugelfischBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Kugelfisch.jpg"));

            var megalodonBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Megalodon.jpg"));

            var bajoBitmap = new BitmapImage(new Uri("pack://application:,,,/Images/Bajo.jpg"));

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

