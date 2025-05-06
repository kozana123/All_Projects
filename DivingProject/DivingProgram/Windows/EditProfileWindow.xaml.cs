using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for EditProfileWindow.xaml
    /// </summary>
    public partial class EditProfileWindow : Window
    {

        SystemManager systemManager = new SystemManager();
        BitmapImage img;
        Diver diver;
        public EditProfileWindow()
        {
            InitializeComponent();
            
            systemManager.DivingClubListBox(clubListBox);
            rankListBox.ItemsSource = Enum.GetNames(typeof(Ranks)).ToList();
            diver = systemManager.GetConnectedDiver();
            firstName.Text = diver.GetFirstName();
            lastName.Text = diver.GetLasttName();
            userBirthDate.SelectedDate = diver.GetBirthDate();
            email.Text = diver.GetEmail();
            password.Password = diver.GetPassword();
            numOfDives.Text = diver.GetNumOfDives().ToString();
            img = diver.GetProfileImage();
            rankListBox.SelectedItem = (diver.GetRank().GetRankName());
            gradeReceiptDate.SelectedDate = diver.GetRank().GetDateOfRecipt();
            clubListBox.SelectedItem = diver.GetRank().GetClub().GetName();

        }
        private const string EMAIL_REGEX = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        private const string PASSWORD_REGEX = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
        


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

            if (uFirstName == "" || uLastName == "" || uEmail == "" || uPassword == "" || selectedRankItem == null || selectedClubItem == null || uBirthDay == DateTime.Now
                || gradeReceiptDateValue == DateTime.Now)
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

            if (uBirthDay >= DateTime.Now || gradeReceiptDateValue >= DateTime.Now)
            {
                MessageBox.Show("Invalid date!");
                return;
            }

            int dives = int.Parse(numDives);

            if (selectedRankItem.Contains("First star") && dives < (int)Ranks.FirstStar)
            {
                MessageBox.Show("You must have at least 30 dives to choose First Star rank!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (selectedRankItem.Contains("Second star") && dives < (int)Ranks.SecondStar
                )
            {
                MessageBox.Show("You must have at least 100 dives to choose Second Star rank!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DivingClub clubV = new DivingClub(selectedClubItem);
            Rank rankV = new Rank(selectedRankItem, clubV, gradeReceiptDateValue);

            MessageBox.Show(firstName.Text);
            diver.SetFirstName(firstName.Text);
            diver.SetLastName(lastName.Text);
            diver.SetBirthDate(userBirthDate.SelectedDate.Value);
            diver.SetEmail(email.Text);
            diver.SetPassword(password.Password);
            diver.SetNumOfDives(int.Parse(numOfDives.Text));
            diver.SetProfileImage(img);
            diver.GetRank().SetRankName(rankListBox.SelectedItem.ToString());
            diver.GetRank().SetDateOfRecipt(gradeReceiptDate.SelectedDate.Value);
            foreach (var club in systemManager.GetDivingClubs())
            {
                if (club.GetName() == (string)clubListBox.SelectedItem)
                    diver.GetRank().SetClub(club);
            }
            


            //if (selectedRankItem.Contains("Instructor"))
            //{
            //    startDay = dateStart.SelectedDate.Value;
            //    endDay = dateFinish.SelectedDate.Value;

            //    Dictionary<string, (string start, string end)> workingHistory = new Dictionary<string, (string start, string end)>();
            //    workingHistory.Add(selectedClubItem, (startDay.ToString("yyyy-MM-dd"), endDay.ToString("yyyy-MM-dd")));

            //    if (img == null)
            //    {
            //        Instructor instructor = new Instructor(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV, workingHistory);
            //        systemManager.AddDiver(instructor);
            //    }
            //    else
            //    {
            //        Instructor instructor = new Instructor(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV, workingHistory);
            //        systemManager.AddDiver(instructor);
            //    }
            //}
            //else
            //{
            //    if (img == null)
            //    {
            //        Diver diver = new Diver(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV);
            //        systemManager.AddDiver(diver);
            //    }
            //    else
            //    {
            //        Diver diver = new Diver(uFirstName, uLastName, uEmail, uPassword, uBirthDay, uniqeId, dives, rankV, img);
            //        systemManager.AddDiver(diver);
            //    }
            //}



            MessageBox.Show("Profile Details Saved!");
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
