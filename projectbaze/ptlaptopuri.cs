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
    public partial class ptlaptopuri : UserControl
    {
        private readonly Form2 frm1;

        public ptlaptopuri(Form2 fm)
        {
            InitializeComponent();
            frm1 = fm;
        }
        static Appdata db;
        protected static Appdata App
        {
            get
            {
                if (db == null)
                    db = new Appdata();
                return db;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Lenovo" && emp.Categorie_id == 1)
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

        private void button2_Click(object sender, EventArgs e)
        {
            //App.CosCumparaturi.AddCosCumparaturiRow(App.CosCumparaturi.NewCosCumparaturiRow());
            //produseBindingSource.MoveLast();
            //var context = new DataClasses2DataContext();

            //// string cipherText = textBox2.Text.Trim();
            //// string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            //var alex = from emp in context.Produses
            //           where (emp.Nume == "HP" && emp.Categorie_id == 1)
            //           select emp;
            //foreach(var a in alex)
            //{


            //    // string Insertstatement = "Insert into Useri values('textBox1.Text', textBox2.Text,textBox3.Text,textBox4.Text)";
            //    //data.ExecuteQuery<Useri>(Insertstatement);

            //    var employee = new CosCumparaturi
            //    {
            //        id_produs = a.Id_produs,
            //        numar_produse = 1,
            //        suma =a.Pret

            //    };
            //   context.CosCumparaturis.InsertOnSubmit(employee);
            //    context.SubmitChanges();
            //}
            //produseBindingSource.EndEdit();
            //App.CosCumparaturi.AcceptChanges();
            //App.CosCumparaturi.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "HP" && emp.Categorie_id == 1)
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
            //dataGridView1.DataSource = alex;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Asus" && emp.Categorie_id == 1)
                       select emp;
            foreach(var a in alex)
            {
                var employee = new PTco
                {
                    Nume = a.Nume.ToString(),
                    Pret = a.Pret,
                    Cantitta=1

                };
                context.PTcos.InsertOnSubmit(employee);
                context.SubmitChanges();
                frm1.BLA();
                //frm1.addingrid(a.Nume.ToString(), a.Pret.ToString(), "1");
                //frm1.Show();

            }
            

            // string Insertstatement = "Insert into Useri values('textBox1.Text', textBox2.Text,textBox3.Text,textBox4.Text)";
            //data.ExecuteQuery<Useri>(Insertstatement);

        
        }
        private void one_shown(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Asus" && emp.Categorie_id == 1)
                       select emp;
            foreach (var a in alex)
            {
                label1.Text = a.Pret.ToString() + "lei";
            }
            var alex2 = from emp in context.Produses
                        where (emp.Nume == "HP" && emp.Categorie_id == 1)
                        select emp;
            foreach (var a in alex2)
            {
                label2.Text = a.Pret.ToString() + "lei";
            }
            var alex22 = from emp in context.Produses
                         where (emp.Nume == "Lenovo" && emp.Categorie_id == 1)
                         select emp;
            foreach (var a in alex22)
            {
                label3.Text = a.Pret.ToString() + "lei";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            ss.Show();
        }
    }
}
