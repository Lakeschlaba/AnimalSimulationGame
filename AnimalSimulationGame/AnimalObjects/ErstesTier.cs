using System.Windows;
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
