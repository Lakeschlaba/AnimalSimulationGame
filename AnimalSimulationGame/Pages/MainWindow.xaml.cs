using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DispatcherTimer timer = new DispatcherTimer();

        public Tier1 ErstesTier1 = new Tier1();

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += t_Tick;
            timer.Start();
        }

        public class Animals
        {
          
        }

        public class ErstesTier : Animals
        {

        }

        public class ZweitesTier : Animals
        {

        }

        public class DrittesTier : Animals
        {

        }

        public class ViertesTier : Animals
        {

        }
        

        private void t_Tick(object sender, EventArgs e)
        {
            FutterBar.Value -= 0.025;
            health();
        }

        private void Button_Click_Fuettern(object sender, RoutedEventArgs e)
        {
            FutterBar.Value += 10;
            if (FutterBar.Value == FutterBar.Maximum)
            {
                FutterBtn.IsEnabled = false;
            }
            
            if (FutterBar.Value <= 100)
            {
                FutterBtn.IsEnabled = true;
            }
        }

        private void Button_Click_Streicheln(object sender, RoutedEventArgs e)
        {
            
        }

        public void health()
        {
            if(FutterBar.Value == FutterBar.Minimum)
            {
                GesundheitBar.Value -= 0.05;
            }
        }

    }

    
}
