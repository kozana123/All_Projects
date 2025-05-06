using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace SafeDevelopmentSemesterProject
{
    /// <summary>
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        int userId;

        public ProfileWindow(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            ShowProfileImage();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Window system = new editProfile(userId);
            system.Show();
            this.Close();
        }

        private void ShowProfileImage()
        {

            BitmapImage bitmapImage = new BitmapImage();

            string connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);

            SqlCommand command = new SqlCommand("SELECT profile_image FROM dbo.user_details WHERE user_id = @UserId", connect);
            command.Parameters.Add(new SqlParameter("@UserId", userId));
            connect.Open();

            byte[] imageBytes = (byte[])command.ExecuteScalar();
            MemoryStream ms = new MemoryStream(imageBytes);
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = ms;
            bitmapImage.EndInit();

            proflieImg.Source = bitmapImage;
            connect.Close();
        }

        private void BtnPreviosPage(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
