using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WABS_Application_Manager;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace WABS_Application_Manager.AuxiliaryHandlers
{
    public class UserAuth
    {
        private string uk01, l_us10, l_ps11, _ru00, _rp01, _nm00;

        public string _type, _name;

        public bool match_found = false;
        public string encryptresult { get; set; }
        public string UserKey { get { return uk01; } set { uk01 = value; } }
        public string Username { get { return l_us10; } set { l_us10 = value; } }
        public string Password { get { return l_ps11; } set { l_ps11 = value; } }
        public string _regusername { get { return _ru00; } set { _ru00 = value; } }
        public string _regpassword { get { return _rp01; } set { _rp01 = value; } }
        public string _regname { get { return _nm00; } set { _nm00 = value; } }

        string temp_id, temp_name, temp_user = null, temp_password = null, temp_type;


        string reg_query = "INSERT INTO _AuthUserDir(authID, name, username, _password, usertype) " +
            "VALUES(@rr_authID, @rr_name, @rr_username, @rr_password, @rr_type)";
        string count_query = "SELECT COUNT(*) FROM _AuthUserDir";
        string cauth_query = "SELECT authID, name, username, _password, usertype" +
            " FROM _AuthUserDir WHERE username = @chk_U AND _password = @chk_P";

        SQLiteConnection sql_conn = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");

        public void RegisterService()
        {
            encrypter(_rp01);
            id_Generate();


            using (SQLiteConnection c = new SQLiteConnection(sql_conn))
            {
                c.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(reg_query, c))
                {
                    sql_cmd.Parameters.AddWithValue("@rr_authID", uk01);
                    sql_cmd.Parameters.AddWithValue("@rr_name", _nm00);
                    sql_cmd.Parameters.AddWithValue("@rr_username", _ru00);
                    sql_cmd.Parameters.AddWithValue("@rr_password", encryptresult);
                    sql_cmd.Parameters.AddWithValue("@rr_type", _type);
                    sql_cmd.ExecuteNonQuery();
                }
            }
        }

        public void AuthenticationService()
        {
            encrypter(l_ps11);

            //foreach (_AuthUserDir x in authdb._AuthUserDirs)
            //{
            //    if (x.username == l_us10 && x._password == encryptresult)
            //    {
            //        match_found = true;
            //        uk01 = x.authID;
            //        _type = x.usertype;
            //        _name = x.name;
            //    }
            //}

            sql_conn.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(cauth_query, sql_conn);
            sql_cmd.Parameters.AddWithValue("@chk_U", l_us10);
            sql_cmd.Parameters.AddWithValue("@chk_P", encryptresult);
            SQLiteDataReader read = sql_cmd.ExecuteReader();

            read.Read();

            if (read.HasRows)
            {
                temp_id = read.GetString(0);
                temp_name = read.GetString(1);
                temp_user = read.GetString(2);
                temp_password = read.GetString(3);
                temp_type = read.GetString(4);
            }
            else
            {
            }

            sql_conn.Close();

            if (temp_user == l_us10 && temp_password == encryptresult)
            {
                match_found = true;
                uk01 = temp_id;
                _type = temp_type;
                _name = temp_name;
            }

            if (match_found == true)
            {
                TableWindow TW = new TableWindow();

                TW.perms = _type;
            }
            else
            {
                MessageBox.Show("Password does not match or the user does not exist!");                
            }

            return;
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

            encryptresult = x2.ToString();
            return;
        }

        private void id_Generate()
        {
            int _count = 0;
            sql_conn.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(count_query, sql_conn);
            sql_cmd.CommandType = CommandType.Text;

            _count = Convert.ToInt32(sql_cmd.ExecuteScalar());


            sql_conn.Close();

            uk01 = "AUs-" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()
                + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString()
                + Convert.ToString(100 + (_count + 1)) + "WABS";


        }
    }
}
