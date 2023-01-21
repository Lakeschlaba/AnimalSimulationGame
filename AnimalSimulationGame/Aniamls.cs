using AnimalSimulationGame.utils;
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
using static AnimalSimulationGame.MainWindow;

namespace AnimalSimulationGame
{
    public class Animals 
    {
        public double gesundheitValue = 50;
        public double futterValue = 50;
        public String animalName = "";

        Random randomHunger = new Random();
        private bool animalHunger;

        public void health()
        {
            if (futterValue <= 0)
            {
                gesundheitValue -= 0.155;
            }
            else
            {
                gesundheitValue += 0.55;
            }

        }

        public void eat()
        {
            if (GameManager.foodAmount > 0) 
            {
                futterValue += 5;
                GameManager.foodAmount -= 1;
            }
            else
            {
                GameManager.foodAmount = 0;
                futterValue += 0;
            }

            if (futterValue <= 0)
            {
                futterValue += 0;
            }
            
        }

        public void hunger()
        {
            animalHunger = randomHunger.Next(10) == 1;
            if (animalHunger == false)
            {
                futterValue -= 0;
            }
            else
            {
                futterValue -= 0.5;
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

        public virtual void animalSpeak()
        {
           MessageBox.Show("Animal bedankt sich bei dir fürs streicheln :>");
        }
    }
}