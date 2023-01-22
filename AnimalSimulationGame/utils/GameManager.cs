using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulationGame.utils
{
    public static class GameManager
    {

        public static ArrayList animalsContainer = new ArrayList();
        public static ArrayList barnsContainer = new ArrayList();

      

        public static int units = 90000;
        public static int foodAmount = 0;
        public static int dogToy = 0;
        public static int randomBajoReward;
        public static int hunger;

        public static double healthAnimal1 = 50;
        public static double foodAnimal1 = 0;

        public static double healthAnimal2 = 50;
        public static double foodAnimal2 = 10;

        public static double healthAnimal3 = 50;
        public static double foodAnimal3 = 10;

        public static double healthAnimal4 = 50;
        public static double foodAnimal4 = 10;

        public static bool isDodoBuyed;
        public static bool isWombatBuyed;
        public static bool isOpossumBuyed;
        public static bool isKugelfischBuyed;
        public static bool isMegalodonBuyed;
        public static bool isBajoBuyed;

        public static bool isWasserGehegeBuyed;
        public static bool isWiesenGehegeBuyed;

        public static bool wantsStroked1;
        public static bool wantsStroked2;
        public static bool wantsStroked3;
        public static bool wantsStroked4;

        public static bool wantsDogToy;

        public static bool randomChoose;

        public static bool isFedAnimal1;
        public static bool isFedAnimal2;
        public static bool isFedAnimal3;
        public static bool isFedAnimal4;
    }
}
