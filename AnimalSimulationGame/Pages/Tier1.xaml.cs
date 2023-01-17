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

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für Tier1.xaml
    /// </summary>  
    public partial class Tier1 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Animals erstesTier = new ErstesTier();
        private bool animalNachricht;
        
        public Tier1()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();

            
        }

        private void t_Tick(object sender, EventArgs e)
        {

            gesundheit1.Value = erstesTier.gesundheitValue;
            futter1.Value = erstesTier.futterValue;
            erstesTier.health();
            erstesTier.futterValue -= 0.05;
       
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void feedBtn1_Click(object sender, RoutedEventArgs e)
        {
            erstesTier.eat();
        }

        private void streichelnBtn1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            animalNachricht = random.Next(2) == 1;

            if(animalNachricht == true)
            {
                erstesTier.animalSpeak();
            }
            erstesTier.streicheln();
        }
    }
}
