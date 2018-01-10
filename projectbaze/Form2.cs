using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace projectbaze
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ptlaptopuri frm = new ptlaptopuri(this);
            pttablete frm2 = new pttablete(this);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazinDataSet2.PTcos' table. You can move, or remove it, as needed.
            this.pTcosTableAdapter.Fill(this.magazinDataSet2.PTcos);
            // TODO: This line of code loads data into the 'magazinDataSet1.CosCumparaturi' table. You can move, or remove it, as needed.
            this.cosCumparaturiTableAdapter.Fill(this.magazinDataSet1.CosCumparaturi);
            dataGridView3.DataSource = GetCos();

        }
        private DataTable GetCos()
        {
            DataTable dtcos = new DataTable();

            string connstringg = ConfigurationManager.ConnectionStrings["projectbaze.Properties.Settings.magazinConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connstringg))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from pTcos", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtcos.Load(reader);
                }
            }
              


            return dtcos;
        }


        public void BLA()
        {
            dataGridView3.DataSource = GetCos();
            this.Show();
        }
        private void one_shown_priv(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            System.Nullable<long> totalUnitsOnOrder =(from ord in context.PTcos
                                                     select ord.Pret).Sum();
            label2.Text = totalUnitsOnOrder.ToString() + "lei";
            
        }
        public void addingrid(string nume,string pret,string cantitate)
        {
            //pTcosBindingSource.EndEdit();

            //DataTable table = new DataTable();
            //DataRow drToAdd = table.NewRow();
            //drToAdd["Nume"] = nume;
            //drToAdd["Pret"] = pret;
            //drToAdd["Cantitate"] = cantitate;
            //table.Rows.Add(drToAdd);
            //var bindingsource = new BindingSource();
            //bindingsource.DataSource = table;
            //dataGridView3.DataSource = table;
            //bindingsource.ResetBindings(true);
            // dataTable.AcceptChanges();

            int n = dataGridView2.RowCount;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView3);
            row.Cells[1].Value = nume;
            row.Cells[2].Value = pret;
            row.Cells[3].Value = cantitate;
            dataGridView3.Rows.Add(row);
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();
            final ss = new final();
            ss.Show();
            var result23 = (from t in context.comenzi3s
                            where t.id > 0
                            select t).First();
            System.Nullable<int> totalUnitsOnOrder = (from ord in context.PTcos
                                                       select ord.Pret).Sum();
            result23.suma = totalUnitsOnOrder;
            context.SubmitChanges();

            //var deleteorder = from detail in context.PTcos

            //                  select detail;
            //foreach (var detail in deleteorder)
            //{
            //    context.PTcos.DeleteOnSubmit(detail);
            //    context.SubmitChanges();
            //}
            //for (int n=0;n<dataGridView3.Rows.Count;n++)
            //dataGridView3.Rows.RemoveAt(n);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                int v = Convert.ToInt32(row.Cells[0].Value.ToString());
                dataGridView3.Rows.RemoveAt(row.Index);
                var deleteorder = from detail in context.PTcos
                                  where detail.id == v
                                  select detail;
                foreach(var detail in deleteorder)
                {
                    context.PTcos.DeleteOnSubmit(detail);
                    context.SubmitChanges();
                }
            }

        }
    }
}
