using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WABS_Application_Manager
{
    public partial class EditWindow : Form
    {

        public string id, fname, mname, lname, gender, address, cno, email, edu_bg, course,
            source, prio_e, othr_e, moe, acc_mngr, acc_status, startdate, exp_months, pos_applied;

        SQLiteConnection sql_conn = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");

        string update_entry = "	UPDATE _ApplicantEntry SET fname = @eX_fname, mname = @eX_mname, " +
            "lname = @eX_lname, age = @eX_age, bdate = @eX_bdate," +
            "gender = @eX_gender, [address] = @eX_address," +
            "cno = @eX_cno, email = @eX_email, educational_background = @eX_edubg," +
            "course = @eX_course, [source] = @eX_source, appdate = @eX_appdate, text_date = @eX_text_date," +
            "priority_endorsement = @eX_priority_e, other_endorsements = @eX_others_e," +
            "mode_of_endorsements = @eX_mo_e, exp_months = @eX_exp_months," +
            "pos_applied = @eX_pos_applied, account_manager = @eX_accmngr, account_status = @eX_accstatus," +
            "[start_date] = @eX_start_date, [status] = 'ACTIVE'" +
            "WHERE id = @eX_id";


        //AppDatabaseDataContext _eDB = new AppDatabaseDataContext();

        public DateTime bdate, appdate, text_date;

        public int age;



        private void etxt_exp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void etxt_cno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void edtp_bday_ValueChanged(object sender, EventArgs e)
        {
            if (edtp_bday.Value.Date.Month <= DateTime.Now.Year)
            {
                if (edtp_bday.Value.Date.Month <= DateTime.Now.Month)
                {
                    if (edtp_bday.Value.Date.Day <= DateTime.Now.Day)
                    {
                        age = DateTime.Now.Year - int.Parse(edtp_bday.Value.Date.Year.ToString());
                        elbl_age.Text = age.ToString();
                    }
                    else
                    {
                        age = DateTime.Now.Year - int.Parse(edtp_bday.Value.Date.Year.ToString()) - 1;
                        elbl_age.Text = age.ToString();
                    }
                }
                else
                {
                    age = DateTime.Now.Year - int.Parse(edtp_bday.Value.Date.Year.ToString()) - 1;
                    elbl_age.Text = age.ToString();
                }
            }
            else
            {
                age = 0;
                elbl_age.Text = "-:-";
            }

        }


        private void EditWindow_Load(object sender, EventArgs e)
        {
            etxt_fname.Text = fname;
            etxt_mname.Text = mname;
            etxt_lname.Text = lname;
            ecbox_gender.Text = gender;
            etxt_address.Text = address;
            etxt_cno.Text = cno;
            etxt_email.Text = email;
            etxt_edu_bg.Text = edu_bg;
            etxt_course.Text = course;
            etxt_source.Text = source;
            etxt_prio_e.Text = prio_e;
            etxt_othr_e.Text = othr_e;
            etxt_moe.Text = moe;
            etxt_acc_mngr.Text = acc_mngr;
            etxt_acc_status.Text = acc_status;
            etxt_pos_applied.Text = pos_applied;

            edtp_bday.Value = bdate;
            edtp_appdate.Value = appdate;
            etxt_startdate.Text = startdate;

            elbl_age.Text = age.ToString();
            etxt_exp.Text = exp_months.ToString();
        }

        public EditWindow()
        {
            InitializeComponent();
        }

        public void EditHandler()
        {
            //_eDB.SP_UpdateEntry(
            //    id,
            //    etxt_fname.Text,
            //    etxt_mname.Text,
            //    etxt_lname.Text,
            //    age,
            //    bdate.ToString("MMM dd, yyyy"),
            //    ecbox_gender.Text,
            //    etxt_address.Text,
            //    etxt_cno.Text,
            //    etxt_email.Text,
            //    etxt_edu_bg.Text,
            //    etxt_course.Text,
            //    etxt_source.Text,
            //    appdate.ToString("MMM dd, yyyy"),
            //    etxt_prio_e.Text,
            //    etxt_othr_e.Text,
            //    etxt_moe.Text,
            //    Convert.ToInt32(etxt_exp.Text),
            //    etxt_acc_mngr.Text,
            //    etxt_acc_status.Text,
            //    startdate.ToString("MMM dd, yyyy"),
            //    "ACTIVE"
            //);



            using (SQLiteConnection c = new SQLiteConnection(sql_conn))
            {
                c.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(update_entry, c))
                {
                    sql_cmd.Parameters.AddWithValue("@eX_id", id);
                    sql_cmd.Parameters.AddWithValue("@eX_fname", etxt_fname.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_mname", etxt_mname.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_lname", etxt_lname.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_age", age);
                    sql_cmd.Parameters.AddWithValue("@eX_bdate", edtp_bday.Value.ToString("MMM dd, yyyy"));
                    sql_cmd.Parameters.AddWithValue("@eX_gender", ecbox_gender.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_address", etxt_address.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_cno", etxt_cno.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_email", etxt_email.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_edubg", etxt_edu_bg.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_course", etxt_course.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_source", etxt_source.Text);
                    sql_cmd.Parameters.AddWithValue("@ex_text_date", edtp_appdate.Value.ToString("MMM dd, yyyy"));
                    sql_cmd.Parameters.AddWithValue("@eX_appdate", edtp_appdate.Value.ToString("yyyy-MM-dd"));
                    sql_cmd.Parameters.AddWithValue("@eX_priority_e", etxt_prio_e.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_others_e", etxt_othr_e.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_mo_e", etxt_moe.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_pos_applied", etxt_pos_applied.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_exp_months", etxt_exp.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_accmngr", etxt_acc_mngr.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_accstatus", etxt_acc_status.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_start_date", etxt_startdate.Text);
                    sql_cmd.Parameters.AddWithValue("@eX_status", "ACTIVE");
                    sql_cmd.ExecuteNonQuery();
                }
            }
        }


        private void btn_SubmitEdit_Click(object sender, EventArgs e)
        {
            TableWindow TW = new TableWindow();
            
            EditHandler();

            TW.UpdateHandler();

            this.Close();
        }
    }
}
