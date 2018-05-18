using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 期末作業1
{

    public partial class user : Form
    {

      
        public user()
        {
            InitializeComponent();
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            商品 d1 = new 商品();
            d1.Show();
            this.Hide();
        }

        private void user_Load(object sender, EventArgs e)
        {
            try
            {
                string text1 = ((Form1)this.Owner).textBox1.Text;
                label1.Text = "登入者帳號:" + text1;
            }
            catch (Exception ex)
            {
                label1.Visible = false;
            }



            Button[] boxes = { button1, button2, button3 };
            for (int i = 0; i < boxes.Length; i++)
            {
                GraphicsPath gp3 = new GraphicsPath();

                gp3.AddEllipse(boxes[i].ClientRectangle);

                Region region3 = new Region(gp3);

                boxes[i].Region = region3;

                gp3.Dispose();

                region3.Dispose();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            購物車 c1 = new 購物車();
            c1.Show();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            購買紀錄 r1 = new 購買紀錄();
            r1.Show();
        }
    }
}
