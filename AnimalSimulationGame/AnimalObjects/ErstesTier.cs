﻿using System;
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
using AnimalSimulationGame.utils;

namespace AnimalSimulationGame.AnimalObjects
{
    public class ErstesTier : Animals
    {
        public override void animalSpeak()
        {
            MessageBox.Show(animalName + " bedankt sich bei Dir!");
        }

        public override void rent()
        {
            GameManager.units += 50;
            MessageBox.Show("Die Miete wurde bezahlt! " + animalName + " überweist dir 50$");
        }
    }
}