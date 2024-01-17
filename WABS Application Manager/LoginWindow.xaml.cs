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
using WABS_Application_Manager.AuxiliaryHandlers;

namespace WABS_Application_Manager
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        UserAuth UA = new UserAuth();
        



        #region UI Handler
        private void MainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btn_lbl_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion

        public LoginWindow()
        {
            InitializeComponent();
        }

        public void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            UA.Username = tbox_username.Text;
            UA.Password = pbox_password.Password;

            if (!string.IsNullOrEmpty(tbox_username.Text) ||
                !string.IsNullOrEmpty(pbox_password.Password))
            {
                UA.AuthenticationService();

                if (UA.match_found == true)
                {
                    MessageBox.Show("Successfully logged in!");

                    StartMenu SM = new StartMenu();

                    SM.Show();

                    SM.authID = UA.UserKey;
                    SM.perms = UA._type;
                    SM.m01_name = UA._name;

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Missing a field!");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqliteServices SS = new SqliteServices();

            SS.DBInit();
        }
    }
}
