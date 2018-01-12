using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Web;
using System.Configuration;
using Microsoft.Office.Interop.Excel;

namespace projectbaze
{
    public partial class admin : Form
    {
        public void GeneratePdf(string htmlPdf)
        {
            var pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            var htmlparser = new HTMLWorker(pdfDoc);
            using (var memoryStream = new MemoryStream())
            {
                var writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                htmlparser.Parse(new StringReader(htmlPdf));
                pdfDoc.Close();

                byte[] bytes = memoryStream.ToArray();
                File.WriteAllBytes(@"D:\\file.pdf", bytes);


                memoryStream.Close();
            }
        }


        public admin()
        {
            InitializeComponent();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void CSVExport(string filename)
        {
            try
            {
                var csv = new StringBuilder();
                using (var context = new DataClasses2DataContext())
                {
                    var query = from emp in context.Useris
                                join o in context.comenzi3s
                                on emp.ID equals o.user_id
                                select new
                                {
                                    emp.Username,
                                    emp.adresa,
                                    o.suma
                                };


                    foreach (var row in query)
                    {
                        var newline = string.Format("{0},{1},{2}", row.Username.Trim(), row.adresa.Trim(), row.suma);
                        csv.AppendLine(newline);
                    }
                    File.WriteAllText(filename, csv.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //PENTRU PDF
            try
            {
            var pdf = new StringBuilder();
                using (var context = new DataClasses2DataContext())
                {
                    var query = from emp in context.Useris
                                join o in context.comenzi3s
                                on emp.ID equals o.user_id
                                select new
                                {
                                    emp.Username,
                                    emp.adresa,
                                    o.suma
                                };


                    foreach (var row in query)
                    {
                        var newline = string.Format("{0}  {1}  {2} ", row.Username.Trim(), row.adresa.Trim(), row.suma);
                        newline += "\r\n";
                        pdf.AppendLine(newline);
                    }
                    GeneratePdf(pdf.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Raport pdf creat!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //pt Excel!!!!!
            try
            {
                SqlConnection cnn;
                string connectionString = null;
                string sql = null;
                string data = null;
                int i = 0;
                int j = 0;

                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                connectionString = "Server=.;Database=magazin;Trusted_Connection=true";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                sql = "SELECT Useri.Username,Useri.adresa,comenzi3.suma FROM Useri INNER JOIN comenzi3 ON comenzi3.user_id=Useri.ID";
                SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
                DataSet ds = new DataSet();
                dscmd.Fill(ds);

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                    {
                        data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                        xlWorkSheet.Cells[i + 1, j + 1] = data;
                    }
                }

                xlWorkBook.SaveAs("D:\\raport-comenzi.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Raport excel creat!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PENTRU CSV
            try
            {
                CSVExport(@"D:\\raport-csv");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Raport csv creat!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form ModificaPret = new Form();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
