using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace 期末作業1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                string constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdDataBase = new OleDbCommand("Select * from login where username='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "';", conDataBase);
                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("登入成功!");
                    this.Hide();                 
                    user f2 = new user();
                    f2.Owner = this;
                    f2.ShowDialog();                                   
                   
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username or Password");
                }
                else
                    MessageBox.Show("帳號或密碼錯誤!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
