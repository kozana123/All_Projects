using Microsoft.Data.SqlClient;
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
using System.Text.RegularExpressions;

namespace SafeDevelopmentSemesterProject
{
    /// <summary>
    /// Interaction logic for CreateNewPasswordWindow.xaml
    /// </summary>
    public partial class CreateNewPasswordWindow : Window
    {
        int userId;


        public CreateNewPasswordWindow(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private const string PASSWORD_REGEX = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$";

        private void SavePassword(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(userPassword.Password, PASSWORD_REGEX))
            {
                MessageBox.Show("Invalid password");
                return;
            }

            string connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);
            connect.Open();

            string encPassword = Encryption.Encrypt(userPassword.Password);

            SqlCommand command = new SqlCommand("UPDATE dbo.user_details SET user_password = @User_Password WHERE user_id = @User_Id", connect);
            command.Parameters.Add(new SqlParameter("@User_Id", userId));
            command.Parameters.Add(new SqlParameter("@User_Password", encPassword));
            command.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Password saved");

            Window system = new MainWindow();
            system.Show();
            this.Close();

        }

        private void BtnPreviosPage(object sender, RoutedEventArgs e)
        {
            Window window = new ForgotPasswordWindow();
            window.Show();
            this.Close();
        }

        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
