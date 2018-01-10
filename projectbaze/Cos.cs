using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbaze
{
    public partial class Cos : Form
    {
        ptlaptopuri ths;
        public Cos(ptlaptopuri frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void Cos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazinDataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.magazinDataSet1.Produse);
            // TODO: This line of code loads data into the 'magazinDataSet.CosCumparaturi' table. You can move, or remove it, as needed.
            this.cosCumparaturiTableAdapter.Fill(this.magazinDataSet.CosCumparaturi);

        }
        public void AddGridViewRows(string Nume, string Pret, string Cantitate)
        {
            // Add rows to grid view.
          
            dataGridView1.Rows.Add(Nume, Pret, Cantitate);
            

            // Refresh the grid
            dataGridView1.Update();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
