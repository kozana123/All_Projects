using Microsoft.Win32;
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

namespace DivingProgram.Windows
{
    /// <summary>
    /// Interaction logic for SystemWindowGuide.xaml
    /// </summary>
    public partial class SystemWindowGuide : Window
    {
        SystemManager systemManager = new SystemManager();

        public SystemWindowGuide()
        {
            InitializeComponent();

            Diver diver = systemManager.GetConnectedDiver();
            InstarctorId.Text = "Instactor ID:     " + diver.GetDiverIdNumber().ToString();
            firstNameText.Text = "First Name:     " + diver.GetFirstName();
            lastNameText.Text = "Last Name:     " + diver.GetLasttName();
            birthDateText.Text = "Birth Date:     " + diver.GetBirthDate().ToShortDateString();
            amountOfDivesText.Text = "Dives:     " + diver.GetNumOfDives().ToString();
            rankText.Text = "Rank:     " + diver.GetRank().GetRankName();
            emailText.Text = "Email:     " + diver.GetEmail();
            
        }

        BitmapImage img;

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog openDialog = new OpenFileDialog();
        //    if (openDialog.ShowDialog() == true)
        //    {
        //        img = new BitmapImage(new Uri(openDialog.FileName));
        //        proflieImg.Source = img;
        //    }

        //}

        private void OpenSearchDivingClubsBtn(object sender, RoutedEventArgs e)
        {
            Window searchDivingClubs = new SearchClubWindow(this);
            searchDivingClubs.Show();
            this.Close();
        }

        private void OpenDivingSitesBtn(object sender, RoutedEventArgs e)
        {
            Window divingSites = new DivingSitesWindow(this);
            divingSites.Show();
            this.Close();
        }

        private void OpenEditProfileBtn(object sender, RoutedEventArgs e)
        {
            Window editProfile = new EditProfileWindow();
            editProfile.Show();
        }

        private void OpenShowRankBtn(object sender, RoutedEventArgs e)
        {
            Window showRank = new ShowRankDetailsWindow(this);
            showRank.Show();
        }

        private void addDive_Click(object sender, RoutedEventArgs e)
        {
            Window system = new AddDiveWindow(this);
            system.Show();
            this.Close();
        }

        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnPreviosPage(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
