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
using System.Windows.Shapes;

namespace WHUT.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.NavigationService.Navigate(new Content.FrontPage());
            
        }

        private void NewTournament_Button_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.NavigationService.Navigate(new Content.NewTournamentPage());
        }

        private void CreatePlayer_Butoon_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.NavigationService.Navigate(new Content.CreatePlayer());
        }

        private void RenameTournament_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BeginTournament_Button_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.NavigationService.Navigate(new Content.SearchForTournamentPage());
        }
        private void ChooseRuleset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartNewRound_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegisterMatchResults_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void DrawNewParrings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManuallyChangeMatch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowScore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
