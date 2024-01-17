using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WABS_Application_Manager.AuxiliaryHandlers;
using System.Runtime.InteropServices;

namespace WABS_Application_Manager
{
    public partial class EditAcc : Form
    {
        UserAuth UA = new UserAuth();
        //AppDatabaseDataContext db = new AppDatabaseDataContext();
        SQLiteConnection sql_conn = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");



        string count_query = "SELECT COUNT(*) FROM _AuthUserDir";
        string cauth_query = "SELECT username FROM _AuthUserDir WHERE username = @chk_U";

        private string u_uix03, x_type, orig_username, temp_user;

        int _count;

        bool nomatch_found = true;

        public string x_username, x_password, x_name, orig_name;
        public string entryID { get { return u_uix03; } set { u_uix03 = value; } }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        #region UI Handler
        public static extern bool ReleaseCapture();
        private void EditAcc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion




        public EditAcc()
        {
            InitializeComponent();
            orig_username = tbox_Username.Text;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbox_Username_TextChanged(object sender, EventArgs e)
        {
            acc_validate();
            UserCheck();
        }

        private void btn_SubmitEdit_Click(object sender, EventArgs e)
        {
            UserCheck();
            acc_validate();

            if (rad_Admin.Checked)
            {
                x_type = "ADMIN";
            }
            else if (rad_User.Checked)
            {
                x_type = "USER";
            }

            if (nomatch_found == false)
            {
                MessageBox.Show("Username already exists!");
            }
            else
            {
                x_name = tbox_Name.Text;
                x_username = tbox_Username.Text;
                x_password = tbox_Password.Text;

                if (string.IsNullOrEmpty(tbox_Name.Text) ||
                    string.IsNullOrEmpty(tbox_Username.Text) ||
                    string.IsNullOrEmpty(tbox_Password.Text) ||
                    x_type == null &&
                    nomatch_found == true)
                {
                    MessageBox.Show("Some fields are empty!");
                }
                else
                {

                    try
                    {
                        encrypter(tbox_Password.Text);
                        //db.SP_UpdateAcc(u_uix03, x_name, x_username, x_password, x_type);

                        string update_acc = "UPDATE _AuthUserDir SET name = @ea_name, username = @ea_username, " +
                            "_password = @ea_password, usertype = @ea_type WHERE @ea_authID = authID";

                        using (SQLiteConnection c = new SQLiteConnection(sql_conn))
                        {
                            c.Open();
                            using (SQLiteCommand sql_cmd = new SQLiteCommand(update_acc, c))
                            {
                                sql_cmd.Parameters.AddWithValue("@ea_name", x_name);
                                sql_cmd.Parameters.AddWithValue("@ea_username", x_username);
                                sql_cmd.Parameters.AddWithValue("@ea_password", x_password);
                                sql_cmd.Parameters.AddWithValue("@ea_type", x_type);
                                sql_cmd.Parameters.AddWithValue("@ea_authID", u_uix03);
                                sql_cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Account has been updated!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex);
                    }
                    this.Close();
                }
            }
        }

        private void encrypter(string bucket)
        {
            var x0 = SHA256.Create();
            byte[] x1 = x0.ComputeHash(Encoding.UTF8.GetBytes((bucket)));

            var x2 = new StringBuilder();
            for (int k = 0; k < x1.Length; k++)
            {
                x2.Append(x1[k].ToString("X2"));
            }

            x_password = x2.ToString();
            return;
        }

        public void UserCheck()
        {
            usercount();
            

            if (_count > 0)
            {
                if (temp_user == tbox_Username.Text)
                {
                    nomatch_found = false;
                    

                    lbl_error_notif.Visible = true;
                }

                if (nomatch_found == false)
                {
                    if (temp_user != tbox_Username.Text)
                    {
                        nomatch_found = true;

                        lbl_error_notif.Visible = false;
                    }
                    if (orig_name == tbox_Username.Text)
                    {
                        nomatch_found = true;

                        lbl_error_notif.Visible = false;
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
    }
}
