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
using System.Xml.Linq;

namespace WHUT.UI.Content
{
    /// <summary>
    /// Interaction logic for SearchForTournamentPage.xaml
    /// </summary>
    public partial class SearchForTournamentPage : Page
    {
        public SearchForTournamentPage()
        {
            InitializeComponent();
        }

        private void LoadTournament_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            XDocument showTournament = controller.LoadTournament(tournamentName.Text);

            if (showTournament != null)
            {
                TournamentWindow tournamentWindow = new TournamentWindow(tournamentName.text);
                tournamentWindow.Show();
            }
            else MessageBox.Show("Tournament: " + tournamentName.Text + ", was not found.");


        }
    }
}
