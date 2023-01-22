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
    public partial class Tier2 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timerForRent = new DispatcherTimer();

        Random random = new Random();

        Animals zweitesTier = new ZweitesTier();

        public Tier2()
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
            gesundheit2.Value = GameManager.healthAnimal2;
            futter2.Value = GameManager.foodAnimal2;

            zweitesTier.health();
            zweitesTier.hunger();
            zweitesTier.streicheln();

            initLabels();
            loadBarnPic();
            loadAnimalPic();
        }

        private void t_Tick2(object sender, EventArgs e)
        {
            zweitesTier.rent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelectionWindow = new AnimalSelection();
            animalSelectionWindow.Show();
            timer.Stop();
            timerForRent.Stop();
            this.Close();
        }

        private void feedBtn2_Click(object sender, RoutedEventArgs e)
        {
            zweitesTier.eat();
            if (GameManager.foodAmount <= 0)
            {
                MessageBox.Show("Du musst Universal-Futter kaufen!");
                feedBtn2.IsEnabled = false;
            }
        }

        private void streichelnBtn2_Click(object sender, RoutedEventArgs e)
        {
            zweitesTier.streicheln();
            if (GameManager.wantsStroked2 == false)
            {
                MessageBox.Show("Dein " + zweitesTier.animalName + " muss glücklich sein. Um dies zu sein, braucht es Futter!");
                streichelnBtn2.IsEnabled = false;
            }
            else
            {
                streichelnBtn2.IsEnabled = true;
                GameManager.randomChoose = random.Next(5) == 1;

                if (GameManager.randomChoose == true)
                {
                    zweitesTier.animalSpeak();
                }
            }
            zweitesTier.hundespielzeug();
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

            switch (GameManager.barnsContainer[1])
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

            switch (GameManager.animalsContainer[1])
            {
                case "dodo":
                    tierImage.Source = dodoBitmap;
                    zweitesTier.animalName = "Dodo";
                    animalNameLabel.Content = zweitesTier.animalName;
                    break;
                case "wombat":
                    tierImage.Source = wombatBitmap;
                    zweitesTier.animalName = "Wombat";
                    animalNameLabel.Content = zweitesTier.animalName;
                    break;
                case "opossum":
                    tierImage.Source = opossumBitmap;
                    zweitesTier.animalName = "Opossum";
                    animalNameLabel.Content = zweitesTier.animalName;
                    break;
                case "kugelfisch":
                    tierImage.Source = kugelfischBitmap;
                    zweitesTier.animalName = "Kugelfisch";
                    animalNameLabel.Content = zweitesTier.animalName;
                    break;
                case "megalodon":
                    tierImage.Source = megalodonBitmap;
                    zweitesTier.animalName = "Megalodon";
                    animalNameLabel.Content = zweitesTier.animalName;
                    break;
                case "bajo":
                    tierImage.Source = bajoBitmap;
                    zweitesTier.animalName = "Bajo";
                    animalNameLabel.Content = zweitesTier.animalName;
                    GameManager.wantsDogToy = true;
                    break;
            }
        }
    }
}

