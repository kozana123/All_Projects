using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
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
    /// Interaction logic for ForgotPasswordWindow.xaml
    /// </summary>
    public partial class ForgotPasswordWindow : Window
    {
        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int pin;
        int userId;
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
        string pass = "vskh ujxs fypj uyqw"; 
        string from = "kozana123@gmail.com";
        string subject = "Confim Code";

        private void SendPinBtn(object sender, RoutedEventArgs e)
        {
            
            string to = userEmail.Text;

            string connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);

            SqlCommand sqlCommand = new SqlCommand("SELECT user_id FROM dbo.user_details WHERE userEmail = @User_Email", connect);
            sqlCommand.Parameters.Add(new SqlParameter("@User_Email", to));

            connect.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                userId = Convert.ToInt32(reader["user_id"]);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Incorrect email");
                reader.Close();
                connect.Close();
                return;

            }
            connect.Close();

            pin = random.Next(11111, 100000);
            string body = pin.ToString();
            MailMessage mailMessage = new MailMessage(from, to, subject, body);

            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(from, pass);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);
            MessageBox.Show("Pin was sent to your email");
            EnterPinLable.Visibility = Visibility.Visible;
            pinText.Visibility = Visibility.Visible;
            confimBtn.Visibility = Visibility.Visible;
            
        }

        private void ConfirnPin(object sender, RoutedEventArgs e)
        {
            if (pinText.Text == pin.ToString())
            {
                Window system = new CreateNewPasswordWindow(userId);
                system.Show();
                this.Close();
            }
            else
                MessageBox.Show("The pin is incorrect!");
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
