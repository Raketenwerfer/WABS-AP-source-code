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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using WABS_Application_Manager.AuxiliaryHandlers;
using System.Data.SQLite;
using System.Data;

namespace WABS_Application_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TableWindow _tView = new TableWindow();
        AdminServices _aServ = new AdminServices();
        UserAuth UA = new UserAuth();
        SQLiteConnection sql_conn = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");

        string add_entry = "INSERT INTO _ApplicantEntry(appdate, text_date, id, fname, mname, lname, age, bdate, gender, " +
        "address, cno, email, educational_background, course, source, priority_endorsement, other_endorsements, " +
        "mode_of_endorsements, exp_months, pos_applied, account_manager, account_status, start_date, status) " +
        "VALUES(@XX_appdate, @XX_text_date, @XX_id, @XX_fname, @XX_mname, @XX_lname, @XX_age, @XX_bdate, @XX_gender, " +
        "@XX_address, @XX_cno, @XX_email, @XX_edubg, @XX_course, @XX_source, @XX_priority_e, @XX_others_e, " +
        "@XX_mo_e, @XX_exp_months, @XX_pos_applied, @XX_accmngr, @XX_accstatus, @XX_start_date, @XX_status)";
        string find_accmngr = "SELECT name FROM _AuthUserDir";
        string count_query = "SELECT COUNT(*) FROM _ApplicantEntry";
        string find_appsources = "SELECT DISTINCT source FROM _ApplicantEntry";


        //AppDatabaseDataContext db = new AppDatabaseDataContext();

        int cal_age;
        string available_ID;
        public string authID, perms, m01_name;
        public bool logged = false;

        public MainWindow()
        {
            InitializeComponent();

            cbox_accmngrs.SelectedItem = m01_name;

            //foreach (_AuthUserDir x in db._AuthUserDirs)
            //{
            //    cbox_accmngrs.Items.Add(x.name);
            //}

            using (SQLiteConnection cs = new SQLiteConnection(sql_conn))
            {
                cs.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(find_accmngr, cs))
                {
                    using (SQLiteDataReader read = sql_cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            cbox_accmngrs.Items.Add(read.GetString(0));
                        }
                    }
                }

            }

            using (SQLiteConnection cs = new SQLiteConnection(sql_conn))
            {
                cs.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(find_appsources, cs))
                {
                    using (SQLiteDataReader read = sql_cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            cbox_appsource.Items.Add(read.GetString(0));
                        }
                    }
                }

            }
        }

        private void dp_bday_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            if (dp_bday.SelectedDate.Value.Year <= DateTime.Now.Year)
            {
                if (dp_bday.SelectedDate.Value.Month <= DateTime.Now.Month)
                {
                    if (dp_bday.SelectedDate.Value.Day <= DateTime.Now.Day)
                    {
                        cal_age = DateTime.Now.Year - int.Parse(dp_bday.SelectedDate.Value.Year.ToString());
                        lbl_display_age.Content = cal_age.ToString();
                    }
                    else
                    {
                        cal_age = DateTime.Now.Year - int.Parse(dp_bday.SelectedDate.Value.Year.ToString()) - 1;
                        lbl_display_age.Content = cal_age.ToString();
                    }
                }
                else
                {
                    cal_age = DateTime.Now.Year - int.Parse(dp_bday.SelectedDate.Value.Year.ToString()) - 1;
                    lbl_display_age.Content = cal_age.ToString();
                }
            }
            else
            {
                cal_age = 0;
                lbl_display_age.Content = "-:-";
            }
        }

        private void tbox_cno_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);
            if (Char.IsNumber(c))
                e.Handled = false;
            else
                e.Handled = true;

            base.OnPreviewTextInput(e);
        }
        private void tbox_exp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);
            if (Char.IsNumber(c))
                e.Handled = false;
            else
                e.Handled = true;

            base.OnPreviewTextInput(e);
        }
        public void id_manager()
        {
            string generator;

            int _count = 0;
            sql_conn.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(count_query, sql_conn);
            sql_cmd.CommandType = CommandType.Text;

            _count = Convert.ToInt32(sql_cmd.ExecuteScalar());


            sql_conn.Close();


            if (_count == 0)
            {
                generator = "WABS-" + "1-" + DateTime.Now.Year.ToString() + "00" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

                available_ID = generator;
            }

            else
            {
                generator = "WABS-" + Convert.ToString(_count + 1) + "-" + DateTime.Now.Year.ToString() + "00" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

                available_ID = generator;
            };
        }

        private void submitEntryHandler()
        {

            //try
            //{
            //    submitEntryHandle();
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.ToString());
            //}
            try
            {
                SubmitFields();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    string generator;
                    int _count = 0;
                    sql_conn.Open();
                    SQLiteCommand sql_cmd = new SQLiteCommand(count_query, sql_conn);
                    sql_cmd.CommandType = CommandType.Text;

                    _count = Convert.ToInt32(sql_cmd.ExecuteScalar());
                    sql_conn.Close();

                    generator = "WABS-" + Convert.ToString(_count + 2) + "-" + DateTime.Now.Year.ToString() + 
                        Convert.ToString(DateTime.Now.Second + DateTime.Now.Minute) + 
                        DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

                    available_ID = generator;

                    SubmitFields();
                }
            }
        }

        public void SubmitFields()
        {
            using (SQLiteConnection c = new SQLiteConnection(sql_conn))
            {
                c.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(add_entry, c))
                {
                    sql_cmd.Parameters.AddWithValue("@XX_id", available_ID);
                    sql_cmd.Parameters.AddWithValue("@XX_fname", tbox_fname.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_mname", tbox_mname.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_lname", tbox_lname.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_age", cal_age);
                    sql_cmd.Parameters.AddWithValue("@XX_bdate", dp_bday.SelectedDate.Value.ToString("MMM dd, yyyy"));
                    sql_cmd.Parameters.AddWithValue("@XX_gender", cbox_gender.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_address", tbox_address.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_cno", tbox_cno.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_email", tbox_email.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_edubg", cbox_edubg.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_course", tbox_course.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_source", cbox_appsource.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_text_date", dp_appdate.SelectedDate.Value.ToString("MMM dd, yyyy"));
                    sql_cmd.Parameters.AddWithValue("@XX_appdate", dp_appdate.SelectedDate.Value.ToString("yyyy-MM-dd"));
                    sql_cmd.Parameters.AddWithValue("@XX_priority_e", tbox_prio_end.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_others_e", tbox_other_end.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_mo_e", tbox_end_mode.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_exp_months", tbox_exp.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_pos_applied", tbox_pos_applied.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_accmngr", cbox_accmngrs.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_accstatus", tbox_accstatus.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_start_date", tbox_startdate.Text);
                    sql_cmd.Parameters.AddWithValue("@XX_status", "ACTIVE");
                    sql_cmd.ExecuteNonQuery();
                }
            }
            System.Windows.MessageBox.Show("Entry submitted!", "WABS Application Manager", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void ClearFields()
        {
                        tbox_fname.Text = "";
                        tbox_mname.Text = "";
                        tbox_lname.Text = "";
                        cal_age = 0;
                        dp_bday.SelectedDate = DateTime.Now;
                        cbox_gender.Text = "";
                        tbox_address.Text = "";
                        tbox_cno.Text = "";
                        tbox_email.Text = "";
                        cbox_edubg.Text = "";
                        tbox_course.Text = "";
                        cbox_appsource.Text = "";
                        dp_appdate.SelectedDate = DateTime.Now;
                        tbox_prio_end.Text = "";
                        tbox_other_end.Text = "";
                        tbox_end_mode.Text = "";
                        tbox_exp.Text = "0";
                        tbox_exp.IsEnabled = false;
                        rad_expNo.IsChecked = true;
                        rad_expYes.IsChecked = false;
                        tbox_pos_applied.Text = "";
                        cbox_accmngrs.Text = "";
                        tbox_accstatus.Text = "";
                        tbox_startdate.Text = "";
        }
        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            string x = _tView.load_table;

            if (
                 string.IsNullOrEmpty(tbox_fname.Text) ||
                 string.IsNullOrEmpty(tbox_mname.Text) ||
                 string.IsNullOrEmpty(tbox_lname.Text) ||
                 string.IsNullOrEmpty(dp_bday.Text.ToString()) ||
                 string.IsNullOrEmpty(cbox_gender.Text) ||
                 string.IsNullOrEmpty(tbox_address.Text) ||
                 string.IsNullOrEmpty(tbox_cno.Text) ||
                 string.IsNullOrEmpty(tbox_email.Text) ||
                 string.IsNullOrEmpty(cbox_edubg.Text) ||
                 string.IsNullOrEmpty(tbox_course.Text) ||
                 string.IsNullOrEmpty(cbox_appsource.Text) ||
                 string.IsNullOrEmpty(dp_appdate.Text.ToString()) ||
                 string.IsNullOrEmpty(tbox_prio_end.Text) ||
                 string.IsNullOrEmpty(tbox_other_end.Text) ||
                 string.IsNullOrEmpty(tbox_end_mode.Text) ||
                 //string.IsNullOrEmpty(tbox_pos_applied.Text) ||
                 string.IsNullOrEmpty(tbox_exp.Text) ||
                 string.IsNullOrEmpty(cbox_accmngrs.Text) ||
                 string.IsNullOrEmpty(tbox_accstatus.Text) ||
                 string.IsNullOrEmpty(tbox_startdate.Text)
                )
            {
                System.Windows.MessageBox.Show("Please compelete all the fields!", "WABS Application Manager", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                if (cal_age < 18)
                {
                    System.Windows.MessageBox.Show("Invalid age!", "WABS Application Manager", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    id_manager();

                    /// Insert fields here for input submission
                    /// 
                        submitEntryHandler();
                        ClearFields();
                        _tView.SourceLoader(x);
                        _tView.DGVhts();
                }

            }
        }


        private void btn_viewtable_Click(object sender, RoutedEventArgs e)
        {

            _tView.authID = authID;
            _tView.perms = perms;

            _tView.ShowDialog();
        }

        private void rad_expYes_Checked(object sender, RoutedEventArgs e)
        {
            tbox_exp.Text = "";
            tbox_exp.IsEnabled = true;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void rad_expNo_Checked(object sender, RoutedEventArgs e)
        {
            tbox_exp.Text = "0";
            tbox_exp.IsEnabled = false;
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            StartMenu SM = new StartMenu();

            SM.BeginInit();
            SM.Activate();

            SM.authID = authID;
            SM.perms = perms;
            SM.m01_name = m01_name;

            this.Close();

            SM.ShowDialog();
        }
    }
}
