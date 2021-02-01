using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace SNGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtYear_Leave(sender, e);
            }
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str = "";
            double dbl;
            string seqno;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            //check for excell and create automatically
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(AppContext.BaseDirectory + @"\2021.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            #region Original code
            //for (rCnt = 1; rCnt <= rw; rCnt++)
            //{
            //    for (cCnt = 1; cCnt <= cl; cCnt++)
            //    {
            //        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
            //        MessageBox.Show(str);
            //    }
            //}
            #endregion

            if (cl > 1)
            {
                //modification needed below
                dbl = (double)(range.Cells[rw, 5] as Excel.Range).Value2 + 1;
                txtSeqNo.Text = dbl.ToString();
                
            }
            else
            {
                txtSeqNo.Text = "1";
            }


            //for (rCnt = 1; rCnt <= rw; rCnt++)
            //{
            //    for (cCnt = 1; cCnt <= cl; cCnt++)
            //    {
            //        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
            //        MessageBox.Show(str);
            //    }
            //}

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation needed

            string str = "";
            double dbl;
            string seqno;
           
            if (txtSeqNo.Text.Length > 0 && txtPartNo.Text.Length > 0 && txtBrand.Text.Length > 0 && txtPONo.Text.Length > 0 && txtQty.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("SN");
                

                dbl = double.Parse(txtSeqNo.Text);
                for (int i = 1; i <= double.Parse(txtQty.Text.ToString()); i++)
                {
                    seqno = "00000000" + (dbl + i).ToString();
                    str = txtPartNo.Text + "_" + txtBrand.Text + "_" + txtPONo.Text + "_" + txtYear.Text.Substring(2, 2) + "_" + seqno.Substring(seqno.Length - 8, seqno.Length - (seqno.Length - 8));

                    //add str to UG
                    dt.Rows.Add(str);
                    DG.DataSource = dt;
                }
            }
        }

        private void UpdateExcel(decimal row, string partno, string model, string pono, string year, string seqno, string sn)
        {
            Microsoft.Office.Interop.Excel.Application oXL = null;
            Microsoft.Office.Interop.Excel._Workbook oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;

            try
            {
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oWB = oXL.Workbooks.Open(AppContext.BaseDirectory + @"\2021.xlsx");
                oSheet = String.IsNullOrEmpty("Sheet1") ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets["Sheet1"];

                

                oSheet.Cells[row, 1] = partno;

                oWB.Save();

                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (oWB != null)
                    oWB.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oXL = null;
            Microsoft.Office.Interop.Excel._Workbook oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;

            oXL = new Microsoft.Office.Interop.Excel.Application();
            oWB = oXL.Workbooks.Open(AppContext.BaseDirectory + @"\2021.xlsx");
            oSheet = String.IsNullOrEmpty("Sheet1") ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets["Sheet1"];

            try 
            {
                //export UG to text file
                using (TextWriter tw = new StreamWriter(AppContext.BaseDirectory + @"\SN.txt"))
                {
                    for (int x = 0; x < DG.Rows.Count - 1; x++)
                    {
                        tw.Write($"{DG.Rows[x].Cells[0].Value.ToString()}");
                        tw.WriteLine();

                        //append text fields to excell
                        //UpdateExcel(decimal.Parse(txtSeqNo.Text), txtPartNo.Text, txtBrand.Text, txtPONo.Text, txtYear.Text, DG.Rows[x].Cells[0].Value.ToString().Substring(DG.Rows[x].Cells[0].Value.ToString().Length - 8, 8), DG.Rows[x].Cells[0].Value.ToString());

                    
                        oSheet.Cells[decimal.Parse(txtSeqNo.Text) + x, 1] = txtPartNo.Text;

                        

                    }
                }
                oWB.Save();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (oWB != null)
                oWB.Close();
            }
        }
    }
}
