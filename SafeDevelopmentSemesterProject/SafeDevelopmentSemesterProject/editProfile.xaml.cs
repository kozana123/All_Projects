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

namespace SafeDevelopmentSemesterProject
{
    /// <summary>
    /// Interaction logic for editProfile.xaml
    /// </summary>
    public partial class editProfile : Window
    {
        int UserId;
        public editProfile(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
            LoadUserData();
        }


        private void LoadUserData()
        {
            string connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);

            SqlCommand command = new SqlCommand("SELECT preferred_partner,relationship_type, religion, height_preferences, is_smoker FROM dbo.user_preferences WHERE user_id = @UserId", connect);
            command.Parameters.Add(new SqlParameter("@UserId", UserId));

            connect.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                genderList.SelectedValue = reader["preferred_partner"].ToString();
                typeConnection.SelectedValue = reader["relationship_type"].ToString();
                religion.SelectedValue = reader["religion"].ToString();
                heightUser.Text = reader["height_preferences"].ToString();

                if (reader["is_smoker"].ToString() == "True")
                {
                    YesCheckBox.IsChecked = true;
                    NoCheckBox.IsChecked = false;
                }

                else
                {
                    YesCheckBox.IsChecked = false;
                    NoCheckBox.IsChecked = true;
                }


            }
            reader.Close();
            connect.Close();

       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);

            string height = heightUser.Text;
            ListBoxItem selectGender = (ListBoxItem)genderList.SelectedItem;
            string userGender = selectGender.Content.ToString();
            ListBoxItem selectType = (ListBoxItem)typeConnection.SelectedItem;
            string connectionChoice = selectType.Content.ToString();
            ListBoxItem selectReligion = (ListBoxItem)religion.SelectedItem;
            string religionChoice = selectReligion.Content.ToString();
            bool isSmokingYes = YesCheckBox.IsChecked.HasValue && YesCheckBox.IsChecked.Value;
            bool isSmokingNo = NoCheckBox.IsChecked.HasValue && NoCheckBox.IsChecked.Value;
            int smokingChoice = isSmokingNo ? 0 : (isSmokingYes ? 1 : (int?)null) ?? 0;


            if (height == null || userGender == null || connectionChoice == null || religionChoice == null || smokingChoice == null)
            {
                MessageBox.Show("Please fill all fields!");

                return;
            }
            connect.Open();

            foreach (char ch in height)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Please enter only numbers in height");
                    return;
                }
                    
            }

            SqlCommand chekUserCmd = new SqlCommand("SELECT Count(*) amount FROM dbo.user_preferences WHERE user_id = @UserId", connect);
            chekUserCmd.Parameters.Add(new SqlParameter("@UserId", UserId));

            SqlDataReader reader = chekUserCmd.ExecuteReader();
            int userExist = 0;
            while (reader.Read())
            {
               userExist = int.Parse(reader["amount"].ToString());
            }
            reader.Close();



            SqlCommand command;
            if (userExist == 1)
            {
                command = new SqlCommand("UPDATE dbo.user_preferences SET preferred_partner = @Gender,relationship_type = @Connection, height_preferences = @Height, religion = @Religion, is_smoker = @Smoking WHERE user_id = @UserId", connect);
            }
            else
            {
                command = new SqlCommand("INSERT INTO dbo.user_preferences(user_id, preferred_partner, relationship_type, height_preferences, religion, is_smoker) VALUES(@UserId, @Gender, @Connection, @Height, @Religion, @Smoking)", connect);
            }

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Gender", userGender);
            param[1] = new SqlParameter("@Connection ", connectionChoice);
            param[2] = new SqlParameter("@Religion", religionChoice);
            param[3] = new SqlParameter("@Height", height);
            param[4] = new SqlParameter("@Smoking", smokingChoice);
            param[5] = new SqlParameter("@UserId", UserId);

            foreach (SqlParameter item in param)
            {
                command.Parameters.Add(item);
            }

            command.ExecuteNonQuery();

            MessageBox.Show("Profile saved!");
            Window system = new ProfileWindow(UserId);
            system.Show();
            this.Close();



        }

        private void DeleteProflieBtn(object sender, RoutedEventArgs e)
        {
            string connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);

            MessageBoxResult result = MessageBox.Show(
                "Are you sure you want to delete the profile?",
                "Deleting Profile",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            
            if (result == MessageBoxResult.Yes)
            {
                connect.Open();

                SqlCommand command = new SqlCommand("DELETE FROM dbo.user_details WHERE user_id = @UserId", connect);
                command.Parameters.Add(new SqlParameter("@UserId", UserId));
                command.ExecuteNonQuery();
                connect.Close();

                Window system = new MainWindow();
                system.Show();
                this.Close();
            }
            
        }

        private void BtnPreviosPage(object sender, RoutedEventArgs e)
        {
            Window window = new ProfileWindow(UserId);
            window.Show();
            this.Close();
        }

        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChooseNo(object sender, RoutedEventArgs e)
        {
            YesCheckBox.IsChecked = false;
        }

        private void ChooseYes(object sender, RoutedEventArgs e)
        {
            NoCheckBox.IsChecked = false;
        }

    }
}
