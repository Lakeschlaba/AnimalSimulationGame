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
    /// Interaktionslogik für Tier4.xaml
    /// </summary>
    public partial class Tier4 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        ItemsStore unitsFutter = new ItemsStore();
        public Tier4()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterValues();
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
    }
}
