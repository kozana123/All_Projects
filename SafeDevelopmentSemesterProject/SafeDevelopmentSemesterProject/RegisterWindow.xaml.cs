using Microsoft.Win32;
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
using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace SafeDevelopmentSemesterProject
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        
        public RegisterWindow()
        {
            InitializeComponent();
            CreateCityList();
        }

        string connectionSql = "Data Source=T67396;Initial Catalog=Members;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        
        List<ListBoxItem> cities = new List<ListBoxItem>();
        byte[] img;
        private const string EMAIL_REGEX = @"^[a-zA-Z0-9-._]{1,}@[a-zA-Z]{2,15}(?:\.[a-zA-Z]{1,}|\.[a-zA-Z]{1,}\.[a-zA-Z]{1,})$";
        private const string PASSWORD_REGEX = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
        private const string PHONE_REGEX = @"^05\d{1}\d{7}$";

        private void CreateCityList()
        {
            
            connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);
            connect.Open();

            SqlCommand command = new SqlCommand($"Get_All_Citys", connect);
            command.CommandType = CommandType.StoredProcedure;  

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = reader["city_name"].ToString();
                item.Tag = reader["city_id"];
                cities.Add(item);
            }

            reader.Close();
            cityListBox.ItemsSource = cities;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            connectionSql = "Data Source=T67396;Initial Catalog=APP_DATE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connect = new SqlConnection(connectionSql);
            DateTime userBirth = DateTime.Now;
            string name = nameText.Text;
            try
            { 
                userBirth = userBirthDate.SelectedDate.Value; 
            }
            catch (Exception exeption)
            {
                MessageBox.Show($"Please fill the birthdate");
                return;
            }
            
            string sqlUserDate = $"{userBirth.Year}-{userBirth.Month}-{userBirth.Day}";
             string userEmail = emailText.Text;
            string userPassword = passwordText.Password;
            string userPhone = userPhoneText.Text;
            ListBoxItem selectedGender = (ListBoxItem)genderList.SelectedItem;
            string userGender = selectedGender.Content.ToString();
            ListBoxItem selectedItem = (ListBoxItem)cityListBox.SelectedItem;
            int userCity = (int)selectedItem.Tag;

            if (name == "" || userEmail == "" || userPassword == "" || userGender == "" || userCity == 0 || img == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            SqlCommand command = new SqlCommand($"Check_Email", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@User_Email", userEmail));

            if (!Regex.IsMatch(userEmail, EMAIL_REGEX))
            {
                MessageBox.Show("Invalid email address");
                return;
            }

            if (!Regex.IsMatch(userPassword, PASSWORD_REGEX))
            {
                MessageBox.Show("Invalid password");
                return;
            }

            if (!Regex.IsMatch(userPhone, PHONE_REGEX))
            {
                MessageBox.Show("Invalid phone number");
                return;
            }

            connect.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                MessageBox.Show("Email is already exist");
                reader.Close();
                return;
            }
            reader.Close();

            userPassword = Encryption.Encrypt(userPassword);

            command = new SqlCommand($"INSERT INTO user_details (userName, userEmail, user_password, birth_date, gender, phone, profile_image, city_id) VALUES (@UserName, " +
             $"@UserEmail, @UserPass, @UserBD, @UserGender, @UserPhone, @Profile_Image, @UserCity)", connect);


            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@UserName", name);
            param[1] = new SqlParameter("@UserEmail", userEmail);
            param[2] = new SqlParameter("@UserPass", userPassword);
            param[3] = new SqlParameter("@UserBD", sqlUserDate);
            param[4] = new SqlParameter("@UserGender", userGender);
            param[5] = new SqlParameter("@UserPhone", userPhone);
            param[6] = new SqlParameter("@UserCity", userCity);
            param[7] = new SqlParameter("@Profile_Image", img);
            foreach (SqlParameter item in param)
            {
                command.Parameters.Add(item);
            }

            reader = command.ExecuteReader();
            reader.Read();
            reader.Close();

            connect.Close();

            MessageBox.Show("Register Complate!");
            Window system = new MainWindow();
            system.Show();
            this.Close();



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
                img = File.ReadAllBytes(openDialog.FileName);
            }
        }
        
        private void BtnPreviosPage(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void SearchCity(object sender, TextChangedEventArgs e) // מסנן את הערים ברשימה
        {
            ArrayList citiesFound = new ArrayList();
            string citySearch = citySearchText.Text;
            foreach (ListBoxItem citie in cities)
            {
                if (citie.Content.ToString().ToLower().Contains(citySearch.ToLower()))
                    citiesFound.Add(citie);
                    
            }

            cityListBox.ItemsSource = citiesFound;
        }

     


    }
}
