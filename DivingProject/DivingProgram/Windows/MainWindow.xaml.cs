using DivingProgram.Windows;
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

namespace DivingProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SystemManager systemManager = new SystemManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            Window register = new RegisterWindow();
            register.Show();
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

                systemManager.SetConnectedDiver();
                Window system = new SystemWindowGuide();
                system.Show();
                this.Close();
                //MessageBox.Show("Please fill all fields!");
                //return;

            }

            else if (systemManager.Login(email, password))
            {
                if (systemManager.GetConnectedDiver() is Instructor)
                {

                    Window system = new SystemWindowGuide();
                    system.Show();
                    this.Close();

                }
                else
                {

                    Window System = new SystemWintdow();
                    System.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }


    }
}