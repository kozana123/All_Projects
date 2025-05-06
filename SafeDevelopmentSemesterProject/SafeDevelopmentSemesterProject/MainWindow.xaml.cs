using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SafeDevelopmentSemesterProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            Window register = new RegisterWindow();
            register.Show();
            this.Close();
        }

        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void BtnLogin(object sender, RoutedEventArgs e)
        {
            string email = userEmail.Text;
            string password = userPassword.Password;

            if (email == "" || password == "")
            {

                MessageBox.Show("Please fill all fields!");
                return;

            }

            string connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);

            password = Encryption.Encrypt(password);


            SqlCommand sqlCommand = new SqlCommand("SELECT user_id FROM dbo.user_details WHERE userEmail = @User_Email AND user_password = @User_Pass", connect);
            sqlCommand.Parameters.Add(new SqlParameter("@User_Email", email));
            sqlCommand.Parameters.Add(new SqlParameter("@User_Pass", password));

            connect.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                int userId = Convert.ToInt32(reader["user_id"]);
                reader.Close();

                Window system = new ProfileWindow(userId);
                system.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Incorrect email or password.");
                reader.Close();
            }

            connect.Close();
        }

        private void ForgotPassword(object sender, RoutedEventArgs e)
        {
            Window system = new ForgotPasswordWindow();
            system.Show();
            this.Close();
        }
    }
}