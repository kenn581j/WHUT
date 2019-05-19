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
using System.Xml;
using WHUT.Business;

namespace WHUT.UI.Content
{
    /// <summary>
    /// Interaction logic for BeginTournament.xaml
    /// </summary>
    public partial class BeginTournament : Page
    {
        public BeginTournament()
        {
            InitializeComponent();
        }

        private void LoadTournament_Click(object sender, RoutedEventArgs e)
        {
            TournamentRepo tournamentRepo = new TournamentRepo();
            tournamentRepo.LoadTournament(tournamentName.Text);

            TournamentViewOnList.Items.Add(tournamentRepo);
        }
    }
}
