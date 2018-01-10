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
    public partial class final : Form
    {
        public final()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox4.Checked==true)
            {
                panel1.Enabled = false;
            }
            if(checkBox1.Enabled==true)
            {
                DataClasses2DataContext data = new DataClasses2DataContext();
                var result23 = (from t in data.comenzi3s
                              where t.id>0
                             select t).First();

                var res = (from t in data.Shippers
                          where t.Nume == "Posta"
                          select t).First();
                result23.shipper_id = res.ID_shipper;
                data.SubmitChanges();
            }
            if (checkBox2.Checked == true)
            {
                DataClasses2DataContext data = new DataClasses2DataContext();
                var result23 = (from t in data.comenzi3s
                                where t.user_id > 0
                                select t).First();

                var res = (from t in data.Shippers
                           where t.Nume == "FanCourier"
                           select t).First();
                result23.shipper_id = res.ID_shipper;
                data.SubmitChanges();
            }
            if (checkBox3.Checked == true)
            {
                DataClasses2DataContext data = new DataClasses2DataContext();
                var result23 = (from t in data.comenzi2s
                                where t.user_id > 0
                                select t).First();

                var res = (from t in data.Shippers
                           where t.Nume == "DHL"
                           select t).First();
             data.UPDATESHIPPER(res.ID_shipper);
                data.SubmitChanges();
            }
            var context = new DataClasses2DataContext();
            var deleteorder = from detail in context.PTcos

                              select detail;
            foreach (var detail in deleteorder)
            {
                context.PTcos.DeleteOnSubmit(detail);
                context.SubmitChanges();
            }
            MessageBox.Show("MUltumim ca ati cumparat de la noi");
        }
    }
}
