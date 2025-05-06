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

namespace DivingProgram
{
    /// <summary>
    /// Interaction logic for ShowRankDetailsWindow.xaml
    /// </summary>
    public partial class ShowRankDetailsWindow : Window
    {
        Window backWindow;
        SystemManager systemManager = new SystemManager();
        Diver diver;
        BitmapImage img;

        public ShowRankDetailsWindow(Window back)
        {
            InitializeComponent();
            diver = systemManager.GetConnectedDiver();
            backWindow = back;

            rankText.Text = diver.GetRank().GetRankName();
            clubText.Text = diver.GetRank().GetClub().GetName();
            dateReceiptText.Text = diver.GetRank().GetDateOfRecipt().ToShortDateString();
            img = diver.GetRank().GetRankImage();
            if (img != null)
            {
                rankImg.Source = img;
            }
        }


        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void ChoosePicture(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == true)
            {
                img = new BitmapImage(new Uri(openDialog.FileName));
                diver.GetRank().SetRankImage(img);
                rankImg.Source = img;
            }

        }


    }
}
