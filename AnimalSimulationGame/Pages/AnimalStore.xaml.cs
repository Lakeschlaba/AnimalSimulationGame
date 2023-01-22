using AnimalSimulationGame.utils;
using System;
using System.Windows;
using System.Windows.Threading;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für AnimalStore.xaml
    /// </summary>
    public partial class AnimalStore : Window
    {

        DispatcherTimer timer = new DispatcherTimer();

        public AnimalStore()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += t_Tick;
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            unitsFutterValues();
            checkAnimalBuyed();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void dodoBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isDodoBuyed = true;
            GameManager.animalsContainer.Add("dodo");
            GameManager.units -= 500;
            showMaxBuyedAnimalInfo();
        }

        private void wombatBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isWombatBuyed = true;
            GameManager.animalsContainer.Add("wombat");
            GameManager.units -= 800;
            showMaxBuyedAnimalInfo();
        }

        private void opossumBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isOpossumBuyed = true;
            GameManager.animalsContainer.Add("opossum");
            GameManager.units -= 1000;
            showMaxBuyedAnimalInfo();
        }

        private void kugelfischBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isKugelfischBuyed = true;
            GameManager.animalsContainer.Add("kugelfisch");
            GameManager.units -= 4000;
            showMaxBuyedAnimalInfo();
        }

        private void megalodonBuybtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isMegalodonBuyed = true;
            GameManager.animalsContainer.Add("megalodon");
            GameManager.units -= 7800;
            showMaxBuyedAnimalInfo();
        }

        private void bajoBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            GameManager.isBajoBuyed = true;
            GameManager.animalsContainer.Add("bajo");
            GameManager.units -= 10000;
            bajoBuyBtn.IsEnabled = false;
            showMaxBuyedAnimalInfo();
        }

        public void checkAnimalBuyed()
        {

            if(GameManager.isDodoBuyed == true)
            {
                dodoBuyBtn.IsEnabled = false;
            }

            if(GameManager.isWombatBuyed == true)
            {
                wombatBuyBtn.IsEnabled = false;
            }

            if (GameManager.isOpossumBuyed == true)
            {
                opossumBuyBtn.IsEnabled = false;
            }

            if (GameManager.isKugelfischBuyed == true)
            {
                kugelfischBuyBtn.IsEnabled = false;
            }

            if (GameManager.isMegalodonBuyed == true)
            {
                megalodonBuybtn.IsEnabled = false;
            }

            if (GameManager.isBajoBuyed == true)
            {
                bajoBuyBtn.IsEnabled = false;
            }

            if(GameManager.animalsContainer.Count == 4)
            {
                dodoBuyBtn.IsEnabled = false;
                wombatBuyBtn.IsEnabled = false;
                opossumBuyBtn.IsEnabled = false;
                kugelfischBuyBtn.IsEnabled = false;
                megalodonBuybtn.IsEnabled = false;
                bajoBuyBtn.IsEnabled = false;
            }
        }



        public void showMaxBuyedAnimalInfo()
        {
            if (GameManager.animalsContainer.Count == 4)
            {
                MessageBox.Show("Du hast jetzt die maximale Anzahl an Tieren gekauft!");
            }
        }

        public void unitsFutterValues()
        {
            futterAnzahlLabel.Content = GameManager.foodAmount;
            unitsAnzahlLabel.Content = GameManager.units + "$";

            if (GameManager.units < 500)
            {
                dodoBuyBtn.IsEnabled = false;
            }

            if (GameManager.units < 800)
            {
                wombatBuyBtn.IsEnabled = false;
            }

            if (GameManager.units < 1000)
            {
                opossumBuyBtn.IsEnabled = false;
            }

            if (GameManager.units < 4000)
            {
                kugelfischBuyBtn.IsEnabled = false;
            }

            if (GameManager.units < 7800)
            {
                megalodonBuybtn.IsEnabled = false;
            }

            if (GameManager.units < 10000)
            {
                bajoBuyBtn.IsEnabled = false;
            }
        }
    }
}
