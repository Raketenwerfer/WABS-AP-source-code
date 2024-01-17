using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using WABS_Application_Manager;
using System.Data;

namespace WABS_Application_Manager.AuxiliaryHandlers
{
    public class ExcelServices
    {
        public string SaveAsLoc { get; set; }
        public string _Worksheet { get; set; }

        public bool WriteDataTableToExcel()
        {
            TableWindow TW = new TableWindow();

            Microsoft.Office.Interop.Excel.Application e;
            Workbook ex_wb;
            Worksheet ex_ws;
            Range ex_cr;


            try
            {
                //  get Application object.
                e = new Microsoft.Office.Interop.Excel.Application();
                e.Visible = false;
                e.DisplayAlerts = false;

                // Creation a new Workbook
                ex_wb = e.Workbooks.Add(Type.Missing);
                

                // Workk sheet
                ex_ws = (Microsoft.Office.Interop.Excel.Worksheet)ex_wb.ActiveSheet;
                ex_ws.Name = _Worksheet;
                ex_ws.Cells.ColumnWidth = 12.5;
                ex_ws.Cells.Font.FontStyle = "Calibri Light";
                ex_ws.Cells.Font.Size = 11;
                ex_ws.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // Set date format for birthdate, application date, and start date
                ex_ws.Cells.Columns[2].NumberFormat = "MMM dd, yyyy";
                ex_ws.Cells.Columns[8].NumberFormat = "MMM dd, yyyy";

                // Set Header colors
                ex_ws.Cells.Rows[1].Interior.Color = System.Drawing.ColorTranslator.FromHtml("#63db63");

                // loop through each row and add values to our sheet
                int rowcount = 1;

                foreach (DataGridViewRow datarow in TW.dgvDisplay.Rows)
                {
                    for (int x = 2; x < TW.dgvDisplay.Columns.Count; x++)
                    {
                        ex_ws.Cells[1, x] = TW.dgvDisplay.Columns[x - 1].HeaderText;
                    }

                    rowcount += 1;
                    for (int i = 1; i <= TW.dgvDisplay.Columns.Count - 1; i++)
                    {

                        //// on the first iteration we add the column headers
                        //if (rowcount == 1)
                        //{
                        //    ex_ws.Cells[1, i] = TW.dgvDisplay.Columns[i - 1].HeaderText;
                        //}


                        // Filling the excel file 
                        ex_ws.Cells[rowcount, i] = datarow.Cells[i - 1].Value.ToString();
                    }

                }

                ex_ws.Columns["A"].Delete();
                ex_ws.Columns["B"].Delete();


                //for (int i = 0; i < TW.dgvDisplay.Rows.Count; i++)
                //{
                //    for (int j = 0; j < TW.dgvDisplay.Columns.Count; j++)
                //    {
                //        ex_ws.Cells[i + 2, j + 1] = TW.dgvDisplay.Rows[i].Cells[j].Value.ToString();
                //    }
                //}



                //now save the workbook and exit Excel
                ex_wb.SaveAs(SaveAsLoc); ;
                ex_wb.Close();
                e.Quit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                e = null;
                ex_cr = null;
                ex_wb = null;
            }

        }

    }
}
