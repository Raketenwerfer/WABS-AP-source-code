using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows;
using System.Security.Cryptography;

namespace WABS_Application_Manager.AuxiliaryHandlers
{
    public class SqliteServices
    {

        public SQLiteConnection sql_conn = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");
        string dir = @"C:\WABS Database";

        string encryptresult;


        string reg_query = "INSERT INTO _AuthUserDir(authID, name, username, _password, usertype) " +
            "VALUES(@rr_authID, @rr_name, @rr_username, @rr_password, @rr_type)";

        string createAuthUser = @"CREATE TABLE _AuthUserDir
                                    (
                                        authID VARCHAR(256) PRIMARY KEY UNIQUE,
                                        [name] VARCHAR(160),
                                        username VARCHAR(64) UNIQUE,
                                        _password VARCHAR(512),
                                        usertype VARCHAR(6)
                                    );";

        string createApplicantEntry = @"CREATE TABLE _ApplicantEntry
                                    (
	                                    appdate VARCHAR(32),
                                        text_date VARCHAR(32),
	                                    id VARCHAR(256) PRIMARY KEY,
	                                    fname VARCHAR(64),
	                                    mname VARCHAR(32),
	                                    lname VARCHAR(64),
	                                    age INT,
	                                    bdate VARCHAR(12),
	                                    gender VARCHAR(16),
	                                    [address] VARCHAR(128),
	                                    cno VARCHAR(64),
	                                    email VARCHAR(64),
	                                    educational_background VARCHAR(128),
	                                    course VARCHAR(256),
	                                    [source] VARCHAR(128),
	                                    priority_endorsement VARCHAR(64),
	                                    other_endorsements VARCHAR(256),
	                                    mode_of_endorsements VARCHAR(128),
	                                    exp_months VARCHAR(4),
                                        pos_applied VARCHAR(256),
	                                    account_manager VARCHAR(64),
	                                    account_status VARCHAR(256),
	                                    [start_date] VARCHAR(32),
	                                    [status] VARCHAR(8)
                                    );";

        public void DBInit()
        {

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(@"C:\WABS Database\wabsdir.db"))
            {
                SQLiteConnection.CreateFile(@"C:\WABS Database\wabsdir.db");

                sql_conn.Open();

                SQLiteCommand sql_cmd = new SQLiteCommand(createAuthUser + createApplicantEntry, sql_conn);
                sql_cmd.ExecuteNonQuery();
                sql_conn.Close();

                AddAdminAcc();

                MessageBox.Show("No local database was found." + "\n" + 
                    "A new one is generated at: C:\\WABS Database\\");
            }
        }

        public void AddAdminAcc()
        {
            encrypter("Admin");
            using (SQLiteConnection c = new SQLiteConnection(sql_conn))
            {
                c.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(reg_query, c))
                {
                    sql_cmd.Parameters.AddWithValue("@rr_authID", "WABS-ADMIN-Default");
                    sql_cmd.Parameters.AddWithValue("@rr_name", "Administrator");
                    sql_cmd.Parameters.AddWithValue("@rr_username", "Admin");
                    sql_cmd.Parameters.AddWithValue("@rr_password", encryptresult);
                    sql_cmd.Parameters.AddWithValue("@rr_type", "ADMIN");
                    sql_cmd.ExecuteNonQuery();
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

            encryptresult = x2.ToString();
            return;
        }
    }
}

#region pcl-create table
//class AuthUserDir
//{
//    [PrimaryKey]
//    public string authID { get; set; }
//    public string name { get; set; }
//    public string username { get; set; }
//    public string _password { get; set; }
//    public string usertype { get; set; }


//    AuthUserDir() { }

//    AuthUserDir(string au1, string au2, string au3, string au4, string au5)
//    {
//        authID = au1;
//        name = au2;
//        username = au3;
//        _password = au4;
//        usertype = au5;
//    }
//}


//class ApplicantEntry
//{
//    public string appdate { get; set; }

//    [PrimaryKey]
//    public string id { get; set; }
//    public string fname { get; set; }
//    public string mname { get; set; }
//    public string lname { get; set; }
//    public int age { get; set; }
//    public string bdate { get; set; }
//    public string gender { get; set; }
//    public string address { get; set; }
//    public string cno { get; set; }
//    public string email { get; set; }
//    public string educational_background { get; set; }
//    public string course { get; set; }
//    public string source { get; set; }
//    public string priority_endorsement { get; set; }
//    public string other_endorsements { get; set; }
//    public string mode_of_endorsements { get; set; }
//    public int exp_months { get; set; }
//    public string account_manager { get; set; }
//    public string account_status { get; set; }
//    public string start_date { get; set; }
//    public string status { get; set; }



//    ApplicantEntry() { }

//    ApplicantEntry(string ae1, string ae2, string ae3, string ae4, string ae5, int ae6, string ae7, string ae8,
//        string ae9, string ae10, string ae11, string ae12, string ae13, string ae14, string ae15, string ae16,
//        string ae17, int ae18, string ae19, string ae20, string ae21, string ae22)
//    {
//        appdate = ae1;
//        id = ae2;
//        fname = ae3;
//        mname = ae4;
//        lname = ae5;
//        age = ae6;
//        bdate = ae7;
//        gender = ae8;
//        address = ae9;
//        cno = ae10;
//        email = ae11;
//        educational_background = ae12;
//        course = ae13;
//        source = ae14;
//        priority_endorsement = ae15;
//        other_endorsements = ae16;
//        mode_of_endorsements = ae17;
//        exp_months = ae18;
//        account_manager = ae19;
//        account_status = ae20;
//        start_date = ae21;
//        status = ae22;
//    }
//}
#endregion