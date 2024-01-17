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

namespace WABS_Application_Manager
{
    public partial class AdminServices : Form
    {
        //AppDatabaseDataContext db = new AppDatabaseDataContext();

        public string authID, perms;
        public string selID;

        //// This section will be changed upon deployment
        //// DB conn string will be hardcoded for this one
        SQLiteConnection _csDB = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");

        string update_status = "UPDATE _ApplicantEntry SET status = @rx_status WHERE @rx_id = id";
        string delete_acc = "DELETE FROM _AuthUserDir WHERE authID = @ea_authID";
        string delete_entry = "DELETE FROM _ApplicantEntry WHERE id = @DE_id";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]



        #region UI Handler
        public static extern bool ReleaseCapture();
        private void AdminServices_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public AdminServices()
        {
            InitializeComponent();
            SourceReload();
            dgVHTS();
        }

        public void SourceReload()
        {
            EntryHandler();
            AccListHandler();
        }
        public void EntryHandler()
        {
            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(_csDB))
                {

                    string query = @"SELECT * FROM _ApplicantEntry
	                                WHERE status = 'INACTIVE'";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataAdapter dAdapter = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dgvRemovedApps.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        public void AccListHandler()
        {
            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(_csDB))
                {

                    string query = "SELECT * FROM _AuthUserDir";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataAdapter dAdapter = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dgvDisplay.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        private void dgVHTS()
        {
            dgvDisplay.Columns[0].HeaderText = "ID";
            dgvDisplay.Columns[1].HeaderText = "Manager Name";
            dgvDisplay.Columns[2].HeaderText = "Username";
            dgvDisplay.Columns[3].Visible = false;
            dgvDisplay.Columns[4].HeaderText = "User Type";

            /////////////////////////////////////////////////////////

            dgvRemovedApps.Columns[0].HeaderText = "Application Date";
            dgvRemovedApps.Columns[1].Visible = false;
            dgvRemovedApps.Columns[2].HeaderText = "Entry ID";
            dgvRemovedApps.Columns[3].HeaderText = "First Name";
            dgvRemovedApps.Columns[4].HeaderText = "Middle Name";
            dgvRemovedApps.Columns[5].HeaderText = "Last Name";
            dgvRemovedApps.Columns[6].HeaderText = "Age";
            dgvRemovedApps.Columns[7].HeaderText = "Birth Date";
            dgvRemovedApps.Columns[8].HeaderText = "Gender";
            dgvRemovedApps.Columns[9].HeaderText = "Address";
            dgvRemovedApps.Columns[10].HeaderText = "Contact Number";
            dgvRemovedApps.Columns[11].HeaderText = "Email Address";
            dgvRemovedApps.Columns[12].HeaderText = "Educational Background";
            dgvRemovedApps.Columns[13].HeaderText = "Course";
            dgvRemovedApps.Columns[14].HeaderText = "Source";
            dgvRemovedApps.Columns[15].HeaderText = "Priority Endorsement";
            dgvRemovedApps.Columns[16].HeaderText = "Other Endorsements";
            dgvRemovedApps.Columns[17].HeaderText = "Mode of Endorsement";
            dgvRemovedApps.Columns[18].HeaderText = "CC/BPO Experience (in months)";
            dgvRemovedApps.Columns[19].HeaderText = "Position Applied";
            dgvRemovedApps.Columns[20].HeaderText = "Account Manager";
            dgvRemovedApps.Columns[21].HeaderText = "Account Status";
            dgvRemovedApps.Columns[22].HeaderText = "Start Date";
            dgvRemovedApps.Columns[23].Visible = false;
        }


        #region Removed Applications Controls
        private void btn_HardDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRemovedApps.SelectedRows[0].Cells[2].Value.ToString() != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to do this? The selected entry " +
                    "will be permanently deleted", "Delete Entry", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //SQLiteCommand cmd = new SQLiteCommand(delete_entry, _csDB);
                        //_csDB.Open();
                        //cmd.Parameters.AddWithValue("@DE_id", dgvRemovedApps.SelectedRows[0].Cells[1].Value.ToString());
                        //cmd.ExecuteNonQuery();

                        //_csDB.Close();
                        using (SQLiteConnection c = new SQLiteConnection(_csDB))
                        {
                            c.Open();
                            using (SQLiteCommand sql_cmd = new SQLiteCommand(delete_entry, c))
                            {
                                sql_cmd.Parameters.AddWithValue("@DE_id", dgvRemovedApps.SelectedRows[0].Cells[2].Value.ToString());
                                sql_cmd.ExecuteNonQuery();
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an entry!");
                }

                AccListHandler();
            }
            catch
            {
                MessageBox.Show("Table's not reloaded!" + "\n\n" + "Reloading entries!");
            }
            finally
            {
                EntryHandler();
            }
            

        }
        private void btn_RestoreEntry_Click(object sender, EventArgs e)
        {


            try
            {
                if (dgvRemovedApps.SelectedRows[0].Cells[2].Value.ToString() != null)
                {
                    //db.SP_StatusHandler(dgvRemovedApps.SelectedRows[0].Cells[1].Value.ToString(), "ACTIVE");

                    //SQLiteCommand cmd = new SQLiteCommand(update_status, _csDB);
                    //_csDB.Open();
                    //cmd.Parameters.AddWithValue("@rx_status", "INACTIVE");
                    //cmd.Parameters.AddWithValue("@rx_id", dgvRemovedApps.SelectedRows[0].Cells[1].Value.ToString());
                    //cmd.ExecuteNonQuery();

                    //_csDB.Close();
                    using (SQLiteConnection c = new SQLiteConnection(_csDB))
                    {
                        c.Open();
                        using (SQLiteCommand sql_cmd = new SQLiteCommand(update_status, c))
                        {
                            sql_cmd.Parameters.AddWithValue("@rx_status", "ACTIVE");
                            sql_cmd.Parameters.AddWithValue("@rx_id", dgvRemovedApps.SelectedRows[0].Cells[2].Value.ToString());
                            sql_cmd.ExecuteNonQuery();
                        }

                    }

                    EntryHandler();
                }
                else
                {
                    MessageBox.Show("Please select an entry!");
                }
            }
            catch
            {
                MessageBox.Show("Table's not reloaded!" + "\n\n" + "Reloading entries!");
            }
            finally
            {
                EntryHandler();
            }
        }
        #endregion


        #region Account Manager Controls
        private void btn_mng_DelAcc_Click(object sender, EventArgs e)
        {
            var count = dgvDisplay.Rows.Cast<DataGridViewRow>().Count(x => x.Cells[4].Value.Equals("ADMIN"));

            try
            {
                if (dgvDisplay.SelectedRows[0].Cells[1].Value.ToString() != null)
                {
                    //db.SP_DeleteAcc(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString());

                    //SQLiteCommand cmd = new SQLiteCommand(delete_acc, _csDB);
                    //_csDB.Open();
                    //cmd.Parameters.AddWithValue("@ea_authID", dgvDisplay.SelectedRows[0].Cells[1].Value.ToString());
                    //cmd.ExecuteNonQuery();

                    //_csDB.Close();

                    if (count > 1 && dgvDisplay.SelectedRows[0].Cells[4].Value.ToString() == "ADMIN" ||
                        dgvDisplay.SelectedRows[0].Cells[4].Value.ToString() == "USER")
                    {
                        using (SQLiteConnection c = new SQLiteConnection(_csDB))
                        {
                            c.Open();
                            using (SQLiteCommand sql_cmd = new SQLiteCommand(delete_acc, c))
                            {
                                sql_cmd.Parameters.AddWithValue("@ea_authID", dgvDisplay.SelectedRows[0].Cells[0].Value.ToString());
                                sql_cmd.ExecuteNonQuery();
                            }

                        }

                        AccListHandler();
                    }
                    else if (count == 1 && dgvDisplay.SelectedRows[0].Cells[4].Value.ToString() == "ADMIN")
                    {
                        MessageBox.Show("Deleting the last ADMIN account will cause unintended consequences. " +
                            "Doing this action is forbidden.", "Warning");
                    }

                }
                else
                {
                    MessageBox.Show("Please select an entry!");
                }
            }
            catch
            {
                MessageBox.Show("Odd that you're finding this. Normally there should be users in the table" + "\n\n" +
                    "Oh well ¯\\_(ツ)_/¯");
            }

        }

        private void btn_mng_EdAcc_Click(object sender, EventArgs e)
        {
            try
            {
                EditAcc EA = new EditAcc();

                if (dgvDisplay.SelectedRows[0].Cells[0].Value.ToString() != null)
                {

                    /// put variables here to retrieve selected data


                    EA.entryID = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();

                    EA.tbox_Name.Text = dgvDisplay.SelectedRows[0].Cells[1].Value.ToString();
                    EA.tbox_Username.Text = dgvDisplay.SelectedRows[0].Cells[2].Value.ToString();
                    EA.orig_name = dgvDisplay.SelectedRows[0].Cells[2].Value.ToString();
                    EA.lbl_error_notif.Visible = false;

                    EA.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select an entry!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odd that you're finding this. Normally there should be users in the table" + "\n\n" +
                    "Oh well ¯\\_(ツ)_/¯" + "\n\n\n" + "Exception: " + ex);
            }
        }

        private void btn_mng_AddAcc_Click(object sender, EventArgs e)
        {
            Registration Reg = new Registration();

            Reg.ShowDialog();
        }
        #endregion

        private void AdminServices_Activated(object sender, EventArgs e)
        {
            SourceReload();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            SourceReload();
        }
    }
}
