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
    public partial class Animals : Window
    {
        //static DispatcherTimer timer = new DispatcherTimer();

        public double _MaxValue = 100;
        public double _MinValue = 0;

        public double gesundheitValue = 100;
        public double futterValue = 0;

        public Animals()
        {
            //timer.Interval = TimeSpan.FromMilliseconds(20);
            //timer.Tick += t_Tick;
            //timer.Start();
        }

        //private void t_Tick(object sender, EventArgs e)
        //{
        //    futterValue -= 0.5;
        //    health();
        //}

        public void health()
        {
            if (futterValue == 0)
            {
                gesundheitValue -= 0.5;
            }
        }

        public void eat()
        {
            //if ()
        }

       
    }
}