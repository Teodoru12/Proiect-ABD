using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace projectbaze
{
   
    public partial class Form1 : Form
    {
        Inregistrare frm;
        public Form1()
        {
            InitializeComponent();
            frm = new Inregistrare(this);
            textBox2.PasswordChar = '#';
            textBox2.MaxLength = 50;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string decryptedText;
            try
            {
                var context = new DataClasses2DataContext();

                // string cipherText = textBox2.Text.Trim();
                // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
                var alex = from emp in context.Useris
                                 where (emp.Username==textBox1.Text) 
                                   select emp;
                if (alex.Any())
                {
                    foreach(var a in alex)
                    {
                        decryptedText = CryptorEngine.Decrypt(a.Parola, true);
                        var employees = from emp in context.Useris
                                        where (emp.Username == textBox1.Text) && (decryptedText == textBox2.Text && emp.Administrator.StartsWith("da"))
                                        select emp;
                        var employees2 = from emp in context.Useris
                                         where (emp.Username.Contains(textBox1.Text)) && (decryptedText == textBox2.Text) //&& emp.Administrator.StartsWith("nu"))
                                         select emp;


                        if (employees.Any())
                        {
                            this.Hide();
                            admin administrare = new admin();
                            administrare.Show();
                        }
                        else if (employees2.Any())
                        {
                            this.Hide();
                            Main ss = new Main();
                            ss.Show();
                            var context3 = new DataClasses2DataContext();
                            Random rnd = new Random();
                            foreach (var al in alex)
                            {
                                //    var emp = new comenzi2
                                //    {
                                //        id = rnd.Next(50000),
                                //        user_id = al.ID
                             
                                context3.inserare(rnd.Next(50000), al.ID, 1, 1);
                                context3.SubmitChanges();
                               
                            }
                            //    };
                            //    context3.comenzi2s.InsertOnSubmit(emp);
                            //    context3.SubmitChanges();}
                           
                            
                            //  frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("USER sau PAROLA incorecta");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("USER incorect");
                }

                //        string decryptedText = CryptorEngine.Decrypt(alex, true);
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inregistrare sss = new Inregistrare(this);
            sss = new Inregistrare(this);
            sss.Show();
        }
    }
}
