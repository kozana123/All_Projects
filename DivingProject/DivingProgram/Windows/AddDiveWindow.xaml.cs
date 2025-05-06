using System;
using System.Collections;
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
    /// Interaction logic for AddDiveWindow.xaml
    /// </summary>
    public partial class AddDiveWindow : Window
    {

        Window backWindow;
        SystemManager systemManager = new SystemManager();

        public AddDiveWindow(Window back)
        {
            InitializeComponent();
            backWindow = back;
            systemManager.DivingClubListBox(clubsListBox);
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

        private void ChoosenClub(object sender, SelectionChangedEventArgs e)
        {
            ArrayList divingSiteList = new ArrayList();
            string choosenClub = (string)clubsListBox.SelectedItem;
            DivingClub divingClub = null;

            foreach (DivingClub club in systemManager.GetDivingClubs())
            {
                if (choosenClub == club.GetName())
                {
                    divingClub = club;
                    break;
                }     
            }
            sitesList.Visibility = Visibility.Visible;
            foreach (DivingSite site in systemManager.GetDivingSites())
            {
                if(divingClub.GetCountry().GetName() == site.GetCountry())
                {
                    divingSiteList.Add(site.GetNameOfSite());
                }
            }

            sitesList.ItemsSource = divingSiteList;
        }

        //private void CoosenSite(object sender, SelectionChangedEventArgs e)
        //{
        //    List<DivingSite> divingSites = systemManager.GetDivingSites();
        //    string siteSelected = (string)sitesList.SelectedItem;

            //foreach (DivingSite site in divingSites)
            //{

            //    if (site.GetNameOfSite() == siteSelected)
            //    {
                    //nameOfSiteText.Text = site.GetNameOfSite();
                    //countryText.Text = site.GetCountry();
                    //addressText.Text = site.GetAddress();
                    //bottomDepthText.Text = site.GetBottomDepth().ToString() + "M";
                    //if (site.GetSaltWater())
                    //    SaltWaterText.Text = "Salt Water";
                    //else
                    //    SaltWaterText.Text = "Sweet Water";
                    //descriptionText.Text = site.GetDescription();
                    //return;
        //        }
        //    }
        //}
    }
}
