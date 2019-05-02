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
using WHUT.Business;

namespace WHUT.UI.Content
{
    /// <summary>
    /// Interaction logic for NewTournamentPage.xaml
    /// </summary>
    public partial class NewTournamentPage : Page
    {
        public NewTournamentPage()
        {
            InitializeComponent();
        }

        private void SaveTournament_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TournamentRepo tournamentRepo = new TournamentRepo();
                tournamentRepo.NewTournament(tournamentName.Text, location.Text, date.DisplayDate);
                MessageBox.Show("Tournament: " + " '" + tournamentName.Text + "' " + ", at location " + " '" + location.Text + "' " + " was created for " + date.DisplayDate);
                this.NavigationService.Navigate(new FrontPage());
                this.NavigationService.RemoveBackEntry();
            }
            catch
            {
                MessageBox.Show("Something went wrong, try again. This is under development. Name has to be string, location has to be string and you have to use the dropdown calender to pick a date.");
            }
        }
    }
}
