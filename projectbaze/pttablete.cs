using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbaze
{
    public partial class pttablete : UserControl
    {
        private readonly Form2 frm1;
        public pttablete(Form2 fm)
        {
            InitializeComponent();
            frm1 = fm;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Acer" && emp.Categorie_id == 2)
                       select emp;
            foreach (var a in alex)
            {
                var employee = new PTco
                {
                    Nume = a.Nume.ToString(),
                    Pret = a.Pret,
                    Cantitta = 1

                };
                context.PTcos.InsertOnSubmit(employee);
                context.SubmitChanges();
                frm1.BLA();
            }
        }
        private void one_shown(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Acer" && emp.Categorie_id == 2)
                       select emp;
            foreach (var a in alex)
            {
                label1.Text = a.Pret.ToString()+"lei";
            }
            var alex2 = from emp in context.Produses
                       where (emp.Nume == "Apple" && emp.Categorie_id == 2)
                       select emp;
            foreach (var a in alex2)
            {
                label2.Text = a.Pret.ToString() + "lei";
            }
            var alex22= from emp in context.Produses
                       where (emp.Nume == "Samsung" && emp.Categorie_id == 2)
                       select emp;
            foreach (var a in alex22)
            {
                label3.Text = a.Pret.ToString() + "lei";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Apple" && emp.Categorie_id == 2)
                       select emp;
            foreach (var a in alex)
            {
                var employee = new PTco
                {
                    Nume = a.Nume.ToString(),
                    Pret = a.Pret,
                    Cantitta = 1

                };
                context.PTcos.InsertOnSubmit(employee);
                context.SubmitChanges();
                frm1.BLA();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Samsung" && emp.Categorie_id == 2)
                       select emp;
            foreach (var a in alex)
            {
                var employee = new PTco
                {
                    Nume = a.Nume.ToString(),
                    Pret = a.Pret,
                    Cantitta = 1

                };
                context.PTcos.InsertOnSubmit(employee);
                context.SubmitChanges();
                frm1.BLA();
            }
        }
    }
}
