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
using static AnimalSimulationGame.ItemsStore;

namespace AnimalSimulationGame
{
    public partial class Animals : Window
    {
        public double gesundheitValue = 50;
        public double futterValue = 0;
       
        public void health()
        {
            if (futterValue <= 0)
            {
                gesundheitValue -= 0.055;
            }
            else
            {
                gesundheitValue += 0.055;
            }

            if(gesundheitValue <= 0)
            {

            }
        }

        public void gameOver()
        {
            MessageBox.Show("TIERQUÄLER! Dein Tier ist verstorben, dass Spiel ist vorbei");
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        public void eat()
        {
            if (futterAnzahl > 0) 
            {
                futterValue += 0.5;
                futterAnzahl -= 1;
            }
            else
            {
                futterAnzahl= 0;
                futterValue += 0;
            }

            if (futterValue <= 0)
            {
                futterValue += 0;
            }
        }

        public void streicheln()
        {
            bool streichelnJa;
            if(futterValue <= 0)
            {
                streichelnJa = false;
            }
            else
            {
                streichelnJa = true;
            }

            if(streichelnJa == true)
            {
                gesundheitValue += 0.035;
            }
            else
            {
                gesundheitValue += 0;
            }
        }

        public void animalSpeak()
        {
            MessageBox.Show("Ein Animal bedankt sich");
        }
    }
}