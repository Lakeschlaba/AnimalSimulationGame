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
using static System.Net.Mime.MediaTypeNames;
using static AnimalSimulationGame.AnimalStore;
using static AnimalSimulationGame.BarnStore;
using static AnimalSimulationGame.ItemsStore;
using System.IO;
using AnimalSimulationGame.utils;
using AnimalSimulationGame.AnimalObjects;
using ViertesTier = AnimalSimulationGame.AnimalObjects.ViertesTier;

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
        private bool animalNachricht;

        public Tier4()
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

        private void t_Tick2(object sender, EventArgs e)
        {
            viertesTier.rent();
        }

        private void t_Tick(object sender, EventArgs e) 
        {

            gesundheit1.Value = GameManager.healthAnimal4;
            futter1.Value = GameManager.foodAnimal4;

            viertesTier.health();
            viertesTier.hunger();

            initLabels();
            loadBarnPic();
            loadAnimalPic();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalSelection animalSelectionWindow = new AnimalSelection();
            animalSelectionWindow.Show();
            this.Close();
        }

        private void feedBtn1_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isFedAnimal4 = true;
            viertesTier.eat();
            GameManager.isFedAnimal4 = false;
            if (GameManager.foodAmount == 0)
            {
                feedBtn1.IsEnabled = false;
            }
        }

        private void streichelnBtn1_Click(object sender, RoutedEventArgs e)
        {
            viertesTier.streicheln();
            viertesTier.hundespielzeug();
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

            var dodoBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Dodo.jpg", UriKind.Relative)));

            var wombatBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Wombat.jpg", UriKind.Relative)));

            var opossumBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Opossum.jpg", UriKind.Relative)));

            var kugelfischBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Kugelfisch.jpg", UriKind.Relative)));

            var megalodonBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Megalodon.jpg", UriKind.Relative)));

            var bajoBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Bajo.jpg", UriKind.Relative)));

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
