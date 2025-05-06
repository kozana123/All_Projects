using DivingProgram.Windows;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
using static System.Reflection.Metadata.BlobBuilder;

namespace DivingProgram
{
    /// <summary>
    /// Interaction logic for SearchClubWindow.xaml
    /// </summary>
    public partial class SearchClubWindow : Window
    {

        Window backWindow;
        
        SystemManager systemManager = new SystemManager();
        public SearchClubWindow(Window back)
        {
            InitializeComponent();
            systemManager.CountryListBox(countryList);
            //systemManager.DivingClubListBox(clubsListBox);
            backWindow = back;
        }



        private void SearchClubBtn(object sender, RoutedEventArgs e)
        {
            List<DivingClub> divingClubs = systemManager.GetDivingClubs();
            ArrayList clubs = new ArrayList();

            foreach (DivingClub club in divingClubs)
            {
                if (club.GetName().Contains(clubNameSearchText.Text))
                    clubs.Add(club.GetName());
            }

            clubsListBox.ItemsSource = clubs;
        }

        private void ChoosenClub(object sender, SelectionChangedEventArgs e)
        {
            List<DivingClub> divingClubs = systemManager.GetDivingClubs();
            string clubSelected = (string)clubsListBox.SelectedItem;

            foreach (DivingClub club in divingClubs)
            {
                
                if (club.GetName() == clubSelected)
                {
                    addressClubText.Text = club.GetAddress();
                    phoneNumberText.Text = club.GetPhoneNumber();
                    contactText.Text = club.GetContact();
                    licenseText.Text = club.GetLicense();
                    emailText.Text = club.GetEmail();
                    webSiteText.Text = club.GetWebsite();
                    return;
                }
            }
        }

        private void ChoosenCountry(object sender, SelectionChangedEventArgs e)
        {

            List<DivingClub> divingClubs = systemManager.GetDivingClubs();
            ArrayList clubs = new ArrayList();

            string choosenCountry = (string)countryList.SelectedItem;
                
            foreach (DivingClub club in divingClubs)
            {
                if (club.GetCountry().GetName() == choosenCountry)
                    clubs.Add(club.GetName());
            }

            clubsListBox.ItemsSource = clubs;


        }

        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void BtnPreviosPage(object sender, RoutedEventArgs e)
        {
            if (backWindow.GetType() == typeof(SystemWindowGuide))
            {
                Window window = new SystemWindowGuide();
                window.Show();
            }
            else
            {
                Window window = new SystemWintdow();
                window.Show();
            }
            
            this.Close();  
        }
    }
}
