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
using WHUT.Business;
using WHUT.UI.Content;

namespace WHUT.UI
{
    /// <summary>
    /// Interaction logic for TournamentWindow.xaml
    /// </summary>
    public partial class TournamentWindow : Window
    {
        private TournamentRepo tournamentRepo = new TournamentRepo();

        public TournamentWindow()
        {
            InitializeComponent();
        }

        private void AddParticipants_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Player p in tournamentRepo.Participants())
            {
                ViewParticipants.Items.Add(p);
            }
            //tournamentPage.Participants.Items.AddRange(participants.ToArray);
        }
        

        private void StartNewRound_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public void RefreshParticipants()
        {
            ViewParticipants.Items.Clear();
            foreach (Player p in tournamentRepo.Participants())
            {
                ViewParticipants.Items.Add(p);
            }
        }

        private void ViewParticipants_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("You are about to remove selected player from the game.", "Please confirm",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                
                int item = ViewParticipants.Items.IndexOf(ViewParticipants.SelectedItem);
                ViewParticipants.Items.RemoveAt(item);
            }
        }
        private void DrawNewParrings_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void ManuallyChangeMatch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegisterMatchResults_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowScore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChooseRuleset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
