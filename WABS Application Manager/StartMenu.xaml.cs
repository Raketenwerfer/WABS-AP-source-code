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

namespace WABS_Application_Manager
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {

        public string authID, perms, m01_name;

        private void MainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow LW = new LoginWindow();
            LW.Show();
            this.Close();
        }

        public StartMenu()
        {
            InitializeComponent();
        }

        private void btn_UserDetails_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Name: " + m01_name + "\n" + "Permission Level: " + perms + "\n" + "User ID: " + authID, "User Details");
        }

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            Registration RG = new Registration();

            if (perms == "ADMIN")
            {
                RG.ShowDialog();
            }
            else
            {
                MessageBox.Show("You're not authorized to perform this action!");
            }
            
        }

        private void btn_MngAcc_Click(object sender, RoutedEventArgs e)
        {
            AdminServices AS = new AdminServices();

            if (perms == "ADMIN")
            {
                AS.ShowDialog();
            }
            else
            {
                MessageBox.Show("You're not authorized to perform this action!");
            }
        }

        private void btn_AddEntries_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.authID = authID;
            MW.perms = perms;
            MW.m01_name = m01_name;

            MW.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
