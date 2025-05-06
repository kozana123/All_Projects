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
using System.Collections;
using DivingProgram.Windows;
using Microsoft.Win32;

namespace DivingProgram
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        SystemManager systemManager = new SystemManager();
        
        public RegisterWindow()
        {
            InitializeComponent();
            systemManager.DivingClubListBox(clubListBox);
            rankListBox.ItemsSource = Enum.GetNames(typeof(Ranks)).ToList();
            
        }

        private const string EMAIL_REGEX = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        private const string PASSWORD_REGEX = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$";

        BitmapImage img;

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

            DateTime uBirthDay = DateTime.Now;
            DateTime gradeReceiptDateValue = DateTime.Now;
            string uFirstName = firstName.Text;
            string uLastName = lastName.Text;
            string uEmail = email.Text;
            string uPassword = password.Password;
            string numDives = numOfDives.Text;
            DateTime startDay = DateTime.Now;
            DateTime endDay = DateTime.Now;


            string selectedRankItem = (string)rankListBox.SelectedItem;
            string selectedClubItem = (string)clubListBox.SelectedItem;

            if (uFirstName == "" || uLastName == "" || uEmail == "" || uPassword == "" || selectedRankItem == null || selectedClubItem == null || uBirthDay >= DateTime.Now
                || gradeReceiptDateValue >= DateTime.Now || numDives == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            else
            {
                uBirthDay = userBirthDate.SelectedDate.Value;
                gradeReceiptDateValue = gradeReceiptDate.SelectedDate.Value;
            }

            if (!Regex.IsMatch(uEmail, EMAIL_REGEX))
            {
                MessageBox.Show("Invalid email format!");
                return;
            }

            if (!Regex.IsMatch(uPassword, PASSWORD_REGEX))
            {
                MessageBox.Show("Password must contain at least 8 characters, one uppercase letter, one lowercase letter, one number and one special character!");
                return;
            }

            if (uBirthDay >= DateTime.Now.Date || gradeReceiptDateValue >= DateTime.Now.Date)
            {
                MessageBox.Show("Invalid date!");
                return;
            }

            int dives = int.Parse(numDives);

            if (selectedRankItem.Contains("FirstStar") && dives < (int)Ranks.FirstStar)
            {
                MessageBox.Show("You must have at least 30 dives to choose First Star rank!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (selectedRankItem.Contains("SecondStar") && dives < (int)Ranks.SecondStar
                )
            {
                MessageBox.Show("You must have at least 100 dives to choose Second Star rank!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            //

            int counterId = 9;
            int uniqeId = counterId++;
            DivingClub clubV = new DivingClub(selectedClubItem);

            foreach (var club in systemManager.GetDivingClubs())
            {
                if (club.GetName() == (string)clubListBox.SelectedItem)
                    clubV = club;
            }
             
            Rank rankV = new Rank(selectedRankItem, clubV, gradeReceiptDateValue);


            if (selectedRankItem.Contains("Instructor"))
            {
                startDay = dateStart.SelectedDate.Value;
                endDay = dateFinish.SelectedDate.Value;

                Dictionary<string, (string start, string end)> workingHistory = new Dictionary<string, (string start, string end)>();
                workingHistory.Add(selectedClubItem, (startDay.ToString("yyyy-MM-dd"), endDay.ToString("yyyy-MM-dd")));

                if (img == null)
                {
                    
                    Instructor instructor = new Instructor(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV, workingHistory);
                    systemManager.AddDiver(instructor);
                }
                else
                {
                    Instructor instructor = new Instructor(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV, workingHistory);
                    systemManager.AddDiver(instructor);
                }
            }
            else
            {

                if (img == null)
                {
                    Diver diver = new Diver(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV);
                    systemManager.AddDiver(diver);
                }
                else
                {
                    Diver diver = new Diver(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV, img);
                    systemManager.AddDiver(diver);
                }
                
            }

            this.Close();

        }

        private void chooseRank(object sender, SelectionChangedEventArgs e)
        {
            string choose = (string)rankListBox.SelectedItem;


            if (choose == "Instructor")
            {
                dateStart.Visibility = Visibility.Visible;
                dateFinish.Visibility = Visibility.Visible;
            }
            else
            {
                dateStart.Visibility = Visibility.Hidden;
                dateFinish.Visibility = Visibility.Hidden;
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
            }
        }
    }
}
