using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Configuration;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using WABS_Application_Manager.AuxiliaryHandlers;

namespace WABS_Application_Manager
{
    public partial class TableWindow : Form
    {
        //AppDatabaseDataContext twdb = new AppDatabaseDataContext();
        EditWindow EW = new EditWindow();
        ExcelServices _service = new ExcelServices();
        UserAuth UA = new UserAuth();
        string searchIndex, subStrQuery;
        int _iRow, _iCol;

        public string authID, perms;

        //// This section will be changed upon deployment
        //// DB conn string will be hardcoded for this one
        SQLiteConnection _csDB = new SQLiteConnection(@"Data Source = C:\WABS Database\wabsdir.db");

        public string load_table = "SELECT * FROM _ApplicantEntry WHERE status = 'ACTIVE' ORDER BY appdate ASC, appdate DESC";
        string update_status = "UPDATE _ApplicantEntry SET status = @rx_status WHERE @rx_id = id";
        int _CT = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region UI Handler
        private void TableWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        ////////////////////////////////////////////////////////////////////
        #endregion

        #region Datagrid View Renderers
        public void SourceLoader(string x)
        {
            //dgvDisplay.DataSource = twdb._ApplicantEntries.Where(x => x.status.Equals("ACTIVE"));

            SQLiteCommand cmd = new SQLiteCommand(x, _csDB);
            _csDB.Open();
            SQLiteDataAdapter dAdapter = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            dAdapter.Fill(ds);
            dgvDisplay.DataSource = ds.Tables[0];
            _csDB.Close();
        }

        public void QueryHandler()
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {

                UpdateHandler();

            }
            else
            {
                subStrQuery = searchBox.Text;

                EntryFinder();
            };


        }

        public void EntryFinder()
        {
            (dgvDisplay.DataSource as System.Data.DataTable).DefaultView.RowFilter =
                String.Format("[" + searchIndex + "] like '" + subStrQuery + "%'");
        }

        public void UpdateHandler()
        {

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(load_table, _csDB);
                _csDB.Open();
                SQLiteDataAdapter dAdapter = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                dgvDisplay.DataSource = ds.Tables[0];
                _csDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        public void DGVhts()
        {
            dgvDisplay.Columns[0].Visible = true;
            dgvDisplay.Columns[0].HeaderText = "Application Date";
            dgvDisplay.Columns[1].Visible = false;
            dgvDisplay.Columns[1].HeaderText = "Application Date";
            dgvDisplay.Columns[2].HeaderText = "Entry ID";
            dgvDisplay.Columns[3].HeaderText = "First Name";
            dgvDisplay.Columns[4].HeaderText = "Middle Name";
            dgvDisplay.Columns[5].HeaderText = "Last Name";
            dgvDisplay.Columns[6].HeaderText = "Age";
            dgvDisplay.Columns[7].HeaderText = "Birth Date";
            dgvDisplay.Columns[8].HeaderText = "Gender";
            dgvDisplay.Columns[9].HeaderText = "Address";
            dgvDisplay.Columns[10].HeaderText = "Contact Number";
            dgvDisplay.Columns[11].HeaderText = "Email Address";
            dgvDisplay.Columns[12].HeaderText = "Educational Background";
            dgvDisplay.Columns[13].HeaderText = "Course";
            dgvDisplay.Columns[14].HeaderText = "Source";
            dgvDisplay.Columns[15].HeaderText = "Priority Endorsement";
            dgvDisplay.Columns[16].HeaderText = "Other Endorsements";
            dgvDisplay.Columns[17].HeaderText = "Mode of Endorsement";
            dgvDisplay.Columns[18].HeaderText = "CC/BPO Experience (in months)";
            dgvDisplay.Columns[19].HeaderText = "Position Applied";
            dgvDisplay.Columns[20].HeaderText = "Account Manager";
            dgvDisplay.Columns[21].HeaderText = "Account Status";
            dgvDisplay.Columns[22].HeaderText = "Start Date";
            dgvDisplay.Columns[23].Visible = false;
        }

        public void altDGVhts()
        {
            dgvDisplay.Columns[0].Visible = false;
            dgvDisplay.Columns[0].HeaderText = "Application Date";
            dgvDisplay.Columns[1].Visible = true;
            dgvDisplay.Columns[1].HeaderText = "Application Date";
            dgvDisplay.Columns[2].HeaderText = "Entry ID";
            dgvDisplay.Columns[3].HeaderText = "First Name";
            dgvDisplay.Columns[4].HeaderText = "Middle Name";
            dgvDisplay.Columns[5].HeaderText = "Last Name";
            dgvDisplay.Columns[6].HeaderText = "Age";
            dgvDisplay.Columns[7].HeaderText = "Birth Date";
            dgvDisplay.Columns[8].HeaderText = "Gender";
            dgvDisplay.Columns[9].HeaderText = "Address";
            dgvDisplay.Columns[10].HeaderText = "Contact Number";
            dgvDisplay.Columns[11].HeaderText = "Email Address";
            dgvDisplay.Columns[12].HeaderText = "Educational Background";
            dgvDisplay.Columns[13].HeaderText = "Course";
            dgvDisplay.Columns[14].HeaderText = "Source";
            dgvDisplay.Columns[15].HeaderText = "Priority Endorsement";
            dgvDisplay.Columns[16].HeaderText = "Other Endorsements";
            dgvDisplay.Columns[17].HeaderText = "Mode of Endorsement";
            dgvDisplay.Columns[18].HeaderText = "CC/BPO Experience (in months)";
            dgvDisplay.Columns[19].HeaderText = "Position Applied";
            dgvDisplay.Columns[20].HeaderText = "Account Manager";
            dgvDisplay.Columns[21].HeaderText = "Account Status";
            dgvDisplay.Columns[22].HeaderText = "Start Date";
            dgvDisplay.Columns[23].Visible = false;
        }

        public void EditPass()
        {
            EW.appdate = DateTime.ParseExact(dgvDisplay.SelectedRows[0].Cells[1].Value.ToString(), "MMM dd, yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            EW.id = dgvDisplay.SelectedRows[0].Cells[2].Value.ToString();
            EW.fname = dgvDisplay.SelectedRows[0].Cells[3].Value.ToString();
            EW.mname = dgvDisplay.SelectedRows[0].Cells[4].Value.ToString();
            EW.lname = dgvDisplay.SelectedRows[0].Cells[5].Value.ToString();
            EW.age = Convert.ToInt32(dgvDisplay.SelectedRows[0].Cells[6].Value.ToString());
            EW.bdate = DateTime.ParseExact(dgvDisplay.SelectedRows[0].Cells[7].Value.ToString(), "MMM dd, yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            EW.gender = dgvDisplay.SelectedRows[0].Cells[8].Value.ToString();
            EW.address = dgvDisplay.SelectedRows[0].Cells[9].Value.ToString();
            EW.cno = dgvDisplay.SelectedRows[0].Cells[10].Value.ToString();
            EW.email = dgvDisplay.SelectedRows[0].Cells[11].Value.ToString();
            EW.edu_bg = dgvDisplay.SelectedRows[0].Cells[12].Value.ToString();
            EW.course = dgvDisplay.SelectedRows[0].Cells[13].Value.ToString();
            EW.source = dgvDisplay.SelectedRows[0].Cells[14].Value.ToString();
            EW.prio_e = dgvDisplay.SelectedRows[0].Cells[15].Value.ToString();
            EW.othr_e = dgvDisplay.SelectedRows[0].Cells[16].Value.ToString();
            EW.moe = dgvDisplay.SelectedRows[0].Cells[17].Value.ToString();
            EW.exp_months = dgvDisplay.SelectedRows[0].Cells[18].Value.ToString();
            EW.pos_applied = dgvDisplay.SelectedRows[0].Cells[19].Value.ToString();
            EW.acc_mngr = dgvDisplay.SelectedRows[0].Cells[20].Value.ToString();
            EW.acc_status = dgvDisplay.SelectedRows[0].Cells[21].Value.ToString();
            EW.startdate = dgvDisplay.SelectedRows[0].Cells[22].Value.ToString();

        }
        #endregion


        public TableWindow()
        {
            InitializeComponent();

            SourceLoader(load_table);
            DGVhts();

            cbox_searchFilter.SelectedIndex = 0;


        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (perms == "ADMIN")
            {
                try
                {
                    EditPass();
                    EW.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured!" + "\n\n" + ex + "\n\n\n" +
                    ">>>> I don't think you've selected an entry, chief. T^T)", "Epik fail!");
                }
                
            }
            else
            {
                MessageBox.Show("You are not authorized to perform this action.");
            }

        }

        private void cbox_searchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_searchFilter.SelectedIndex)
            {

                case 0: searchIndex = "appdate";

                    break;

                case 1: searchIndex = "id";

                    break;

                case 2: searchIndex = "fname";

                    break;

                case 3: searchIndex = "mname";

                    break;

                case 4: searchIndex = "lname";

                    break;

                case 5: searchIndex = "priority_endorsement";

                    break;

                case 6: searchIndex = "other_endorsements";

                    break;

                case 7: searchIndex = "source";

                    break;

                case 8: searchIndex = "mode_of_endorsements";

                    break;

                case 9: searchIndex = "pos_applied";

                    break;

                case 10:
                    searchIndex = "account_manager";

                    break;

                case 11:
                    searchIndex = "account_status";

                    break;


                default: searchIndex = "id";

                    break;
            }

            QueryHandler();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            QueryHandler();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            //twdb.SP_StatusHandler(dgvDisplay.SelectedRows[0].Cells[1].Value.ToString(), "INACTIVE");
            try
            {
                if (dgvDisplay.SelectedRows[0].Cells[0].Value.ToString() != null)
                {
                    SQLiteCommand cmd = new SQLiteCommand(update_status, _csDB);
                    _csDB.Open();
                    cmd.Parameters.AddWithValue("@rx_status", "INACTIVE");
                    cmd.Parameters.AddWithValue("@rx_id", dgvDisplay.SelectedRows[0].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();

                    _csDB.Close();

                    SourceLoader(load_table);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured!" + "\n\n" + ex + "\n\n\n" +
                ">>>> I don't think you've selected an entry, chief. T^T)", "Epik fail!");
            }


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbox_datestyleAD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_datestyleAD.Checked == true)
            {
                _CT = 1;
                altDGVhts();
                SourceLoader(load_table);
            }
            else
            {
                _CT = 0;
                DGVhts();
                SourceLoader(load_table);
            }
        }

        public void CellSet(int row, int col)
        {
            try
            {
                dgvDisplay.CurrentCell = dgvDisplay.Rows[row].Cells[col];
            }
            catch
            {
                return;
            }
            
        }



        private void TableWindow_Activated(object sender, EventArgs e)
        {
            _iRow = dgvDisplay.CurrentCell.RowIndex;
            _iCol = dgvDisplay.CurrentCell.ColumnIndex;

            UpdateHandler();
            if (!string.IsNullOrEmpty(searchBox.Text))
            {
                QueryHandler();
            }

            CellSet(_iRow, _iCol);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                if (perms == "ADMIN")
                {
                    sfd_export.Filter = "Excel Worksheets| *.xlsx, *.xls";

                    if (sfd_export.ShowDialog() == DialogResult.OK)
                    {
                        _service._Worksheet = "Applicants";
                        _service.SaveAsLoc = sfd_export.FileName;


                        _service.WriteDataTableToExcel();
                    }
                }
                else
                {
                    MessageBox.Show("You are not authorized to perform this action.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured!" + "\n\n" + ex + "\n\n\n" +
                    ">>>> Did you export an empty table!? o~O", "Epik fail!");
            }
        }
    }
}





#region Extra Code

//// Most useful SQL Reader Code
///

//// This section will be changed upon deployment
//string _csDB = @"Data Source=ROCKET-PC;Initial Catalog=WABS_DIRECTORY;Integrated Security=True";

//try
//{
//    //sql connection object
//    using (SqlConnection conn = new SqlConnection(_csDB))
//    {

//        //retrieve the SQL Server instance version
//        string query = @"SELECT * FROM _ApplicantEntry
//	                                WHERE " + searchIndex + " LIKE " + "'" + subStrQuery + "%'";

//        //define the SqlCommand object
//        SqlCommand cmd = new SqlCommand(query, conn);


//        //Set the SqlDataAdapter object
//        SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

//        //define dataset
//        DataSet ds = new DataSet();

//        //fill dataset with query results
//        dAdapter.Fill(ds);

//        //set the DataGridView control's data source/data table
//        dgvDisplay.DataSource = ds.Tables[0];


//        //close connection
//        conn.Close();
//    }
//}
//catch (Exception ex)
//{
//    //display error message
//    MessageBox.Show("Exception: " + ex.Message);
//}

#endregion

#region ack
////// This section will be changed upon deployment
//string _csDB = @"Server=ROCKET-PC;Database=WABS_DIRECTORY;Integrated Security=True";

//try
//{
//    //sql connection object
//    using (SqlConnection conn = new SqlConnection(_csDB))
//    {
//        conn.Open();
//        //retrieve the SQL Server instance version
//        // Section needs to be parameterize as well to prevent SQLi attacks!


//        //define the SqlCommand object
//        SqlCommand cmd = new SqlCommand("SP_Query", conn);
//        cmd.CommandType = CommandType.StoredProcedure;

//        cmd.Parameters.AddWithValue("@II_column", SqlDbType.VarChar).Value = searchIndex;
//        cmd.Parameters.AddWithValue("@II_queryitem", SqlDbType.VarChar).Value = subStrQuery;

//        cmd.ExecuteNonQuery();

//        //Set the SqlDataAdapter object
//        SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

//        //define dataset
//        DataSet ds = new DataSet();

//        //fill dataset with query results
//        dAdapter.Fill(ds);

//        //set the DataGridView control's data source/data table
//        dgvDisplay.DataSource = ds.Tables[0];


//        //close connection
//        conn.Close();

//    }
//}
//catch (Exception ex)
//{
//    //display error message
//    MessageBox.Show("Exception: " + ex.Message);
//}
#endregion

