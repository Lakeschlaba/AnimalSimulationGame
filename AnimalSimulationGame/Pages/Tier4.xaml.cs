using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using AnimalSimulationGame.utils;
using AnimalSimulationGame.AnimalObjects;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für Tier4.xaml
    /// </summary>
    public partial class Tier4 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timerForRent = new DispatcherTimer();

        Animals viertesTier = new ViertesTier();

        Random random = new Random();

        public Tier4()
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

            gesundheit4.Value = GameManager.healthAnimal4;
            futter4.Value = GameManager.foodAnimal4;

            viertesTier.health();
            viertesTier.hunger();

            initLabels();
            loadBarnPic();
            loadAnimalPic();
        }

        private void t_Tick2(object sender, EventArgs e)
        {
            viertesTier.rent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelectionWindow = new AnimalSelection();
            animalSelectionWindow.Show();
            timer.Stop();
            timerForRent.Stop();
            this.Close();
        }

        private void feedBtn4_Click(object sender, RoutedEventArgs e)
        {
            viertesTier.eat();
            if (GameManager.foodAmount <= 0)
            {
                MessageBox.Show("Du musst Universal-Futter kaufen!");
                feedBtn4.IsEnabled = false;
            }
        }

        private void streichelnBtn4_Click(object sender, RoutedEventArgs e)
        {
            viertesTier.streicheln();
            if (GameManager.wantsStroked4 == false)
            {
                MessageBox.Show("Dein " + viertesTier.animalName + " muss glücklich sein. Um dies zu sein, braucht es Futter!");
                streichelnBtn4.IsEnabled = false;
            }
            else
            {
                streichelnBtn4.IsEnabled = true;
                GameManager.randomChoose = random.Next(3) == 1;

                if (GameManager.randomChoose == true)
                {
                    viertesTier.animalSpeak();
                }
            }
            viertesTier.hundespielzeug();
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

            switch (GameManager.barnsContainer[3])
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

            switch (GameManager.animalsContainer[3])
            {
                case "dodo":
                    tierImage.Source = dodoBitmap;
                    viertesTier.animalName = "Dodo";
                    animalNameLabel.Content = viertesTier.animalName;
                    break;
                case "wombat":
                    tierImage.Source = wombatBitmap;
                    viertesTier.animalName = "Wombat";
                    animalNameLabel.Content = viertesTier.animalName;
                    break;
                case "opossum":
                    tierImage.Source = opossumBitmap;
                    viertesTier.animalName = "Opossum";
                    animalNameLabel.Content = viertesTier.animalName;
                    break;
                case "kugelfisch":
                    tierImage.Source = kugelfischBitmap;
                    viertesTier.animalName = "Kugelfisch";
                    animalNameLabel.Content = viertesTier.animalName;
                    break;
                case "megalodon":
                    tierImage.Source = megalodonBitmap;
                    viertesTier.animalName = "Megalodon";
                    animalNameLabel.Content = viertesTier.animalName;
                    break;
                case "bajo":
                    tierImage.Source = bajoBitmap;
                    viertesTier.animalName = "Bajo";
                    animalNameLabel.Content = viertesTier.animalName;
                    GameManager.wantsDogToy = true;
                    break;  
            }

        }
    }
}
