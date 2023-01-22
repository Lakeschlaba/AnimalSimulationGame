﻿using AnimalSimulationGame.utils;
using System;
using System.Windows;
using System.Windows.Threading;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für BarnStore.xaml
    /// </summary>
    public partial class BarnStore : Window
    {

        DispatcherTimer timer = new DispatcherTimer();

        public BarnStore()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterGehegeValues();;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void wiesenGehegeBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isWiesenGehegeBuyed = true;
            GameManager.barnsContainer.Add("wiesengehege");
            GameManager.units -= 500;
            showMaxGehegeInfo();
        }

        private void wasserGehegeBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isWasserGehegeBuyed = true;
            GameManager.barnsContainer.Add("wassergehege");
            GameManager.units -= 1000;
            showMaxGehegeInfo();
        }

        public void showMaxGehegeInfo()
        {   
            if (GameManager.barnsContainer.Count == 4)
            {
                MessageBox.Show("Du hast jetzt die maximale Anzahl an Gehegen gekauft!");
            }
        }

        public void unitsFutterGehegeValues()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units + "$";

            if (GameManager.units < 500)
            {
                wiesenGehegeBtn.IsEnabled = false;
            }

            if(GameManager.units < 1000)
            {
                wasserGehegeBtn.IsEnabled = false;
            }

            if(GameManager.barnsContainer.Count == 4) 
            {
                wiesenGehegeBtn.IsEnabled = false;
                wasserGehegeBtn.IsEnabled = false;
            }

        }
    }
}
