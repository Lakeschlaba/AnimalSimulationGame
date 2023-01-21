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
        public static int foodAmount = 500;
        public static int hunger;

        public static double gesundheitValueM = 50;
        public static double futterValueM = 50;

        public static double gesundheitValueM2 = 50;
        public static double futterValueM2 = 50;

        public static double gesundheitValue3 = 50;
        public static double futterValue3 = 0;

        public static double gesundheitValue4 = 50;
        public static double futterValue4 = 0;

        public static bool isDodoBuyed;
        public static bool isWombatBuyed;
        public static bool isOpossumBuyed;
        public static bool isKugelfischBuyed;
        public static bool isMegalodonBuyed;
        public static bool isBajoBuyed;

        public static bool isWasserGehegeBuyed;
        public static bool isWiesenGehegeBuyed;

    }
}
