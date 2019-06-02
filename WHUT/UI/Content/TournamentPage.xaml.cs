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
using WHUT.Application;

namespace WHUT.UI.Content
{
    /// <summary>
    /// Interaction logic for Tournament.xaml
    /// </summary>
    public partial class TournamentPage : Page
    {
        public TournamentPage()
        {
            InitializeComponent();
            tournamentName.Text = Controller.Instance.tournament.Name;
            tournamentLocation.Text = Controller.Instance.tournament.Location;
            tournamentDate.Text = Controller.Instance.tournament.Date.ToString();
            tournamentRuleset.Text = Controller.Instance.tournament.TournamentType;
            Controller.Instance.tournament.Participants.ForEach(x => Participants.Items.Add(x));
        }

        private void StartNewRound_Button_Click(object sender, RoutedEventArgs e)
        {
            Controller.Instance.NewRound();
            Controller.Instance.tournament.rounds[0].matches.ForEach(x => Matches.Items.Add(x));
        }

        private void SingleEli_Selected(object sender, RoutedEventArgs e)
        {
            Controller.Instance.tournament.TournamentType = "Single Elimination";
            tournamentRuleset.Text = Controller.Instance.tournament.TournamentType;
        }

        private void DoubleEli_Selected(object sender, RoutedEventArgs e)
        {
            Controller.Instance.tournament.TournamentType = "Double Elimination";
            tournamentRuleset.Text = Controller.Instance.tournament.TournamentType;
        }

        private void Swiss_Selected(object sender, RoutedEventArgs e)
        {
            Controller.Instance.tournament.TournamentType = "Monrad Swiss";
            tournamentRuleset.Text = Controller.Instance.tournament.TournamentType;
        }

        private void GwSwiss_Selected(object sender, RoutedEventArgs e)
        {
            Controller.Instance.tournament.TournamentType = "Games Workshop Swiss";
            tournamentRuleset.Text = Controller.Instance.tournament.TournamentType;
        }

        private void RoundRobin_Selected(object sender, RoutedEventArgs e)
        {
            Controller.Instance.tournament.TournamentType = "Monrad Swiss";
            tournamentRuleset.Text = Controller.Instance.tournament.TournamentType;
        }

        private void Matches_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegisterMatchResult inputMatchResults = new RegisterMatchResult());
            inputMatchResults.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            inputMatchResults.Show();

        }
    }
}
