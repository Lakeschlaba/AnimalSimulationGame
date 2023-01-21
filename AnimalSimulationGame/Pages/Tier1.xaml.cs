﻿using System;
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
using static AnimalSimulationGame.utils.GameManager;
using static AnimalSimulationGame.BarnStore;
using System.IO;
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

        Animals erstesTier = new ErstesTier();

        public Tier1()
        {
            InitializeComponent();
            initLabels();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += t_Tick;
            timer.Start();

            timerForRent.Interval = TimeSpan.FromMinutes(2);
            timerForRent.Tick += t_Tick2;
            timerForRent.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {

            gesundheit1.Value = GameManager.healthAnimal1;
            futter1.Value = GameManager.foodAnimal1;

            erstesTier.health();
            erstesTier.hunger();

            initLabels();
            checkStreicheln();
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
            this.Close();
        }

        private void feedBtn1_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isFedAnimal1 = true;
            erstesTier.eat();
            GameManager.isFedAnimal1 = false;
            if (GameManager.foodAmount == 0)
            {
                feedBtn1.IsEnabled= false;
            }
        }

        private void streichelnBtn1_Click(object sender, RoutedEventArgs e)
        {
            erstesTier.streicheln();
            erstesTier.hundespielzeug();
        }

        private void checkStreicheln()
        {
            if(GameManager.wantsStroked == false)
            {
                streichelnBtn1.IsEnabled= false;
            }
            else if (GameManager.wantsStroked == true)
            {
                streichelnBtn1.IsEnabled= true;
            }
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
            var dodoBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Dodo.jpg", UriKind.Relative)));

            var wombatBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Wombat.jpg", UriKind.Relative)));

            var opossumBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Opossum.jpg", UriKind.Relative)));

            var kugelfischBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Kugelfisch.jpg", UriKind.Relative)));

            var megalodonBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Megalodon.jpg", UriKind.Relative)));

            var bajoBitmap = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Images/Bajo.jpg", UriKind.Relative)));

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
