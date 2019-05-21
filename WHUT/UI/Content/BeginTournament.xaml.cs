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
using System.Xml.Linq;
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
            Controller controller = new Controller();
            XDocument showTournament = controller.LoadTournament(tournamentName.Text);

            if (showTournament != null)
            {
                TournamentWindow tournamentWindow = new TournamentWindow(tournamentName.Text);
                tournamentWindow.Show();
                //TournamentViewOnList.Items.Add(showTournament);
            }
            else MessageBox.Show("Tournament: " + tournamentName.Text + ", wasn't found");
        }

        private void TournamentViewOnList_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string selectedTournament = TournamentViewOnList.SelectedValue.ToString();
            //Gå til valgt turnering med selectedTournament
            MessageBox.Show(selectedTournament);
        }
    }
}
