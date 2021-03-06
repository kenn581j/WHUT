﻿using System;
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
            bool tournament = Controller.Instance.LoadTournament(tournamentName.Text);

            if (tournament == true)
            {
                NavigationService.Navigate(new TournamentPage());
            }
            else
            {
                MessageBox.Show("Tournament: " + tournamentName.Text + ", was not found.");
            }
        }
    }
}
