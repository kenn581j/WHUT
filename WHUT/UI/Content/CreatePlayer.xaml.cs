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
    /// Interaction logic for CreatePlayer.xaml
    /// </summary>
    public partial class CreatePlayer : Page
    {
        public CreatePlayer()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            PlayerRepo playerRepository = new PlayerRepo();
            playerRepository.RegisterPlayer(playerName.Text, playerClub.Text, playerWarband.Text);
            MessageBox.Show($"New player: {playerName.Text}, has been created");

            //}
            //catch
            //{
            //    MessageBox.Show("Fejl");
            //}
        }
    }
}