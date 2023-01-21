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

namespace AnimalSimulationGame
{
    public class Animals 
    {
        public String animalName = "";

        Random random = new Random();

        public virtual void animalSpeak()
        {
            MessageBox.Show("Irgendein Tier bedankt sich bei dir für's streicheln");
        }

        public virtual void rent()
        {
            GameManager.units += 500;
        }

        public void hundespielzeug()
        {
            GameManager.randomChoose = random.Next(5) == 1;

            if (GameManager.randomChoose == true)
            {
                if (GameManager.wantsDogToy == true)
                {
                    if (GameManager.dogToy > 0)
                    {
                        GameManager.dogToy -= 1;
                        GameManager.randomBajoReward = random.Next(50, 1000);
                        GameManager.units += GameManager.randomBajoReward;
                        MessageBox.Show("Bajo hat das Spielzeug geschnappt! und spendet dir " + GameManager.randomBajoReward + "$");
                    }
                }
            }
        }

        public void health()
        {
            //Tier1
            if (GameManager.foodAnimal1 > 0)
            {
                GameManager.healthAnimal1 += 0.15;
            }
            else if(GameManager.foodAnimal1 <= 0)
            {
                GameManager.healthAnimal1 -= 0.15;
            }

            //Tier2
            if (GameManager.foodAnimal2 > 0)
            {
                GameManager.healthAnimal2 += 0.15;
            }
            else if (GameManager.foodAnimal2 <= 0)
            {
                GameManager.healthAnimal2 -= 0.15;
            }

            //Tier3
            if (GameManager.foodAnimal3 > 0)
            {
                GameManager.healthAnimal3 += 0.15;
            }
            else if (GameManager.foodAnimal3 <= 0)
            {
                GameManager.healthAnimal3 -= 0.15;
            }

                //Tier4
            if (GameManager.foodAnimal4 > 0)
            {
                GameManager.healthAnimal4 += 0.15;
            }
            else if (GameManager.foodAnimal4 <= 0)
            {
                GameManager.healthAnimal4 -= 0.15;
            }
        }

        public void eat()
        {
            GameManager.foodAmount -= 1;

            //Tier1
            if(GameManager.isFedAnimal1 == true)
            {
                GameManager.foodAnimal1 += 1.5;
            }

            //Tier2
            if (GameManager.isFedAnimal2 == true)
            {
                GameManager.foodAnimal2 += 1.5;
            }

            //Tier3
            if (GameManager.isFedAnimal3 == true)
            {
                GameManager.foodAnimal3 += 1.5;
            }

            //Tier4
            if (GameManager.isFedAnimal4 == true)
            {
                GameManager.foodAnimal4 += 1.5;
            }
        }

        public void hunger()
        {
            GameManager.randomChoose = random.Next(10) == 1;

            if (GameManager.randomChoose == true)
            {
                //Tier1
                if(GameManager.foodAnimal1 > 0)
                {
                    GameManager.foodAnimal1 -= 0.025;
                }

                //Tier2
                if (GameManager.foodAnimal2 > 0)
                {
                    GameManager.foodAnimal2 -= 0.025;
                }

                //Tier3
                if (GameManager.foodAnimal3 > 0)
                {
                    GameManager.foodAnimal3 -= 0.025;
                }

                //Tier4
                if (GameManager.foodAnimal4 > 0)
                {
                    GameManager.foodAnimal4 -= 0.025;
                }
            }   
        }

        public void streicheln()
        {
            GameManager.randomChoose = random.Next(5) == 1;

            //Tier1
            if (GameManager.foodAnimal1 <= 0)
            {
                GameManager.wantsStroked = false;
            }
            else if (GameManager.foodAnimal1 > 0)
            {
                GameManager.wantsStroked = true;
            }

            //Tier2
            if (GameManager.foodAnimal2 <= 0)
            {
                GameManager.wantsStroked = false;
            }
            else if (GameManager.foodAnimal2 > 0)
            {
                GameManager.wantsStroked = true;
            }

            //Tier3
            if (GameManager.foodAnimal3 <= 0)
            {
                GameManager.wantsStroked = false;
            }
            else if (GameManager.foodAnimal3 > 0)
            {
                GameManager.wantsStroked = true;
            }

            //Tier4
            if (GameManager.foodAnimal4 <= 0)
            {
                GameManager.wantsStroked = false;
            }
            else if (GameManager.foodAnimal4 > 0)
            {
                GameManager.wantsStroked = true;
            }

            if (GameManager.randomChoose == true)
            {
                if (GameManager.wantsStroked)
                {
                    animalSpeak();
                }
            }
        }
    }
}