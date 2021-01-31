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
            string str = "";
            double dbl;
            string seqno;
           
            if (txtSeqNo.Text.Length > 1)
            {
                dbl = double.Parse(txtSeqNo.Text);
                for (int i = 1; i <= double.Parse(txtQty.Text.ToString()); i++)
                {
                    seqno = "00000000" + (dbl + i).ToString();
                    str = txtPartNo.Text + "_" + txtBrand.Text + "_" + txtPONo.Text + "_" + txtYear.Text.Substring(2, 2) + "_" + seqno.Substring(seqno.Length - 8, seqno.Length - (seqno.Length - 8));

                }
            }
        }
    }
}
