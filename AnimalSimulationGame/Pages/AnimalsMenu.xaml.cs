using System.Windows;

namespace AnimalSimulationGame
{
    /// <summary>
    /// Interaktionslogik für AnimalsMenu.xaml
    /// </summary>
    public partial class AnimalsMenu : Window
    {
        public AnimalsMenu()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            AnimalsHome animalsHome = new AnimalsHome();
            animalsHome.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
