using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WABS_Application_Manager.AuxiliaryHandlers;

namespace WABS_Application_Manager
{
    public partial class Registration : Form
    {
        UserAuth AU = new UserAuth();
        SQLiteConnection sql_conn = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");
        bool nomatch_found;
        string temp, temp_user, usertype = null;
        int _count = 0;

        string count_query = "SELECT COUNT(*) FROM _AuthUserDir";
        string cauth_query = "SELECT username FROM _AuthUserDir WHERE username = @chk_U";


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        #region UI Handler
        public static extern bool ReleaseCapture();
        private void Registration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion



        public Registration()
        {
            InitializeComponent();

            lbl_username_error.Visible = false;
            lbl_password_error.Visible = false;
            lbl_confpass_error.Visible = false;
        }
        private void tbox_Username_TextChanged(object sender, EventArgs e)
        {
            acc_validate();
            UserCheck();
        }

        private void btn_RegisterAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_Name.Text) &&
                !string.IsNullOrEmpty(tbox_Username.Text) &&
                !string.IsNullOrEmpty(tbox_Password.Text) &&
                !string.IsNullOrEmpty(tbox_ConfPassword.Text) &&
                !string.IsNullOrEmpty(usertype))

            {
                if (nomatch_found == true)
                {
                    if (tbox_Password.Text == tbox_ConfPassword.Text)
                    {
                        bool exthrown = false;

                        AU._regname = tbox_Name.Text;
                        AU._regusername = tbox_Username.Text;
                        AU._regpassword = tbox_Password.Text;
                        AU._type = usertype;

                        try
                        {
                            AU.RegisterService();
                        }
                        catch
                        {
                            MessageBox.Show("The account already exists!");

                            exthrown = true;
                        }
                        finally
                        {
                            if (exthrown == false)
                            {
                                MessageBox.Show("Account successfully registered");

                                tbox_Name.Text = "";
                                tbox_Username.Text = "";
                                tbox_Password.Text = "";
                                tbox_ConfPassword.Text = "";
                                rad_User.Checked = false;
                                rad_Admin.Checked = false;
                                exthrown = false;

                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!");
                    }
                }
                else
                {
                    MessageBox.Show("Username is already taken!");
                }
            }
            else
            {
                MessageBox.Show("Fields are incomplete!");
            }

        }
        private void tbox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbox_ConfPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbox_Password.Text == tbox_ConfPassword.Text)
            {
                lbl_password_error.Visible = false;
                lbl_confpass_error.Visible = false;
            }
            else
            {
                lbl_password_error.Visible = true;
                lbl_confpass_error.Visible = true;
            }
        }
        public void UserCheck()
        {
            usercount();

            if (_count > 0)
            {
                if (temp_user == tbox_Username.Text)
                {
                    nomatch_found = false;
                    temp = tbox_Username.Text;

                    lbl_username_error.Visible = true;
                }

                if (nomatch_found == false && temp != tbox_Username.Text)
                {
                    if (temp_user != tbox_Username.Text)
                    {
                        nomatch_found = true;

                        lbl_username_error.Visible = false;
                    }

                }
            }
            else
            {
                nomatch_found = true;
            }

        }

        public void acc_validate()
        {
            using (SQLiteConnection c = new SQLiteConnection(sql_conn))
            {
                c.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(cauth_query, c))
                {
                    sql_cmd.Parameters.AddWithValue("@chk_U", tbox_Username.Text);

                    using (SQLiteDataReader read = sql_cmd.ExecuteReader())
                    {
                        read.Read();

                        if (read.HasRows)
                        {
                            temp_user = read.GetString(0);
                        }
                    }
                }
            }
        }

        private void rad_User_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_User.Checked == true)
            {
                usertype = "USER";
            }
        }

        private void rad_Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Admin.Checked == true)
            {
                usertype = "ADMIN";
            }
        }
        public void usercount()
        {
            using (SQLiteConnection c = new SQLiteConnection(sql_conn))
            {
                c.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(count_query, c))
                {
                    using (SQLiteDataReader read = sql_cmd.ExecuteReader())
                    {
                        read.Read();
                        _count = read.GetInt32(0);
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
