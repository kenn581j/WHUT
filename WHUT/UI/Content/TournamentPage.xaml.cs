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
            Participants.Items.Add(Controller.Instance.tournament.Participants);
        }
    }
}
