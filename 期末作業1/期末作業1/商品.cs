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
using System.Drawing.Drawing2D;

namespace 期末作業1
{
    public partial class 商品 : Form
    {
        BindingSource BindingSource1;
        BindingSource BindingSource2;
        public 商品()
        {
            InitializeComponent();
            BindingSource1 = new BindingSource();
            BindingSource2 = new BindingSource();
            dataGridView2.SelectionChanged += new EventHandler(dataGridView2_SelectionChanged);
        }

        private void 商品_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\123.png");
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //第四步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 商品資料表", cn);
            DataSet ds = new DataSet("ds_商品資料表");
            oleda.Fill(ds, "ds_商品資料表");

            OleDbDataAdapter oleda2 = new OleDbDataAdapter("SELECT * FROM 收尋紀錄", cn);
            DataSet ds2 = new DataSet("ds_收尋紀錄");
            oleda2.Fill(ds2, "ds_收尋紀錄");

            BindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = BindingSource1;

            BindingSource2.DataSource = ds2.Tables[0];
            dataGridView2.DataSource = BindingSource2;
            //第六步：關閉資料庫連線
            cn.Close();
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" || textBox2.Text != "")
            {
                if (textBox2.Text == "")
                {
                    //第一步：設定連線字串
                    String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

                    //第二步：建立資料庫連線物件
                    OleDbConnection cn = new OleDbConnection(strConnectionString);

                    //第三步：開啟資料庫連線
                    cn.Open();

                    //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                    String sql = "SELECT * FROM 商品資料表 WHERE 商品名稱 LIKE '%" + textBox1.Text + "%'";
                    //第五步：取得資料並填入 DataSet
                    OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                    DataSet ds = new DataSet("ds_商品資料表");
                    oleda.Fill(ds, "ds_商品資料表");

                    //第六步：設定 DataSource
                    BindingSource1.DataSource = ds.Tables[0];
                    dataGridView1.DataSource = BindingSource1;
                }
                else
                {
                    //第一步：設定連線字串
                    String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

                    //第二步：建立資料庫連線物件
                    OleDbConnection cn = new OleDbConnection(strConnectionString);

                    //第三步：開啟資料庫連線
                    cn.Open();

                    //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                    String sql = "SELECT * FROM 商品資料表 WHERE 商品價格 = '" + textBox2.Text + "'";
                    //第五步：取得資料並填入 DataSet
                    OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                    DataSet ds = new DataSet("ds_商品資料表");
                    oleda.Fill(ds, "ds_商品資料表");

                    //第六步：設定 DataSource
                    BindingSource1.DataSource = ds.Tables[0];
                    dataGridView1.DataSource = BindingSource1;
                }
            }          
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            //第一步：設定連線字串
                            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

                            //第二步：建立資料庫連線物件
                            OleDbConnection cn = new OleDbConnection(strConnectionString);

                            //第三步：開啟資料庫連線
                            cn.Open();

                            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                            String sql = "SELECT * FROM 商品資料表 WHERE 商品名稱 LIKE '%" + textBox1.Text + "%'";
                            sql += " AND 商品價格 ='" + textBox2.Text + "'";
                            //第五步：取得資料並填入 DataSet
                            OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                            DataSet ds = new DataSet("ds_商品資料表");
                            oleda.Fill(ds, "ds_商品資料表");

                            //第六步：設定 DataSource
                            BindingSource1.DataSource = ds.Tables[0];
                            dataGridView1.DataSource = BindingSource1;

                            break;
                        }
                    case 1:
                        {
                            //第一步：設定連線字串
                            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

                            //第二步：建立資料庫連線物件
                            OleDbConnection cn = new OleDbConnection(strConnectionString);

                            //第三步：開啟資料庫連線
                            cn.Open();

                            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                            String sql = "SELECT * FROM 商品資料表 WHERE 商品名稱 LIKE '%" + textBox1.Text + "%'AND 商品價格<'" + textBox2.Text + "'";
                            //第五步：取得資料並填入 DataSet
                            OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                            DataSet ds = new DataSet("ds_商品資料表");
                            oleda.Fill(ds, "ds_商品資料表");

                            //第六步：設定 DataSource
                            BindingSource1.DataSource = ds.Tables[0];
                            dataGridView1.DataSource = BindingSource1;

                            break;
                        }            
            }


            //第一步：設定連線字串
            String strConnectionString2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn2 = new OleDbConnection(strConnectionString2);

            //第三步：開啟資料庫連線
            cn2.Open();

            String strSQL = "INSERT INTO 收尋紀錄(商品名稱,條件,商品價格) VALUES('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "')";

            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn2);
            cmdLiming.ExecuteNonQuery();
            OleDbDataAdapter oleda2 = new OleDbDataAdapter("SELECT * FROM 收尋紀錄", cn2);
            DataSet ds2 = new DataSet("ds_收尋紀錄");
            oleda2.Fill(ds2, "ds_收尋紀錄");
        
            BindingSource2.DataSource = ds2.Tables[0];
            dataGridView2.DataSource = BindingSource2;

            //第七步：關閉資料庫連線
            cn2.Close();
            dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[0];
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Selected = true;
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selected_row = dataGridView2.CurrentRow.Index;
                textBox1.Text = dataGridView2.Rows[selected_row].Cells[1].FormattedValue.ToString();
                comboBox1.Text = dataGridView2.Rows[selected_row].Cells[2].FormattedValue.ToString();
                textBox2.Text = dataGridView2.Rows[selected_row].Cells[3].FormattedValue.ToString();

                
            }
            catch (Exception ee)
            {
                textBox1.Text = "";
                comboBox1.Text = "";
                textBox2.Text = "";

              
            }
        }
       
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle Rtg_LT = new Rectangle();
            Rectangle Rtg_RT = new Rectangle();
            Rectangle Rtg_LB = new Rectangle();
            Rectangle Rtg_RB = new Rectangle();
            Rtg_LT.X = 0; Rtg_LT.Y = 7; Rtg_LT.Width = 10; Rtg_LT.Height = 10;
            Rtg_RT.X = e.ClipRectangle.Width - 11; Rtg_RT.Y = 7; Rtg_RT.Width = 10; Rtg_RT.Height = 10;
            Rtg_LB.X = 0; Rtg_LB.Y = e.ClipRectangle.Height - 11; Rtg_LB.Width = 10; Rtg_LB.Height = 10;
            Rtg_RB.X = e.ClipRectangle.Width - 11; Rtg_RB.Y = e.ClipRectangle.Height - 11; Rtg_RB.Width = 10; Rtg_RB.Height = 10;

            Color color = Color.FromArgb(51, 94, 168);
            Pen Pen_AL = new Pen(color, 1);
            Pen_AL.Color = color;
            Brush brush = new HatchBrush(HatchStyle.Divot, color);

            e.Graphics.DrawString(groupBox1.Text, groupBox1.Font, brush, 6, 0);
            e.Graphics.DrawArc(Pen_AL, Rtg_LT, 180, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_RT, 270, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_LB, 90, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_RB, 0, 90);
            e.Graphics.DrawLine(Pen_AL, 5, 7, 6, 7);
            e.Graphics.DrawLine(Pen_AL, e.Graphics.MeasureString(groupBox1.Text, groupBox1.Font).Width + 3, 7, e.ClipRectangle.Width - 7, 7);
            e.Graphics.DrawLine(Pen_AL, 0, 13, 0, e.ClipRectangle.Height - 7);
            e.Graphics.DrawLine(Pen_AL, 6, e.ClipRectangle.Height - 1, e.ClipRectangle.Width - 7, e.ClipRectangle.Height - 1);
            e.Graphics.DrawLine(Pen_AL, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 7, e.ClipRectangle.Width - 1, 13);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            購物車 c1 = new 購物車();
            c1.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        //第一步：設定連線字串
                        String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
                        //第二步：建立資料庫連線物件
                        OleDbConnection cn = new OleDbConnection(strConnectionString);
                        //第三步：開啟資料庫連線
                        cn.Open();
                        //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                        String sql = "SELECT * FROM 商品資料表 WHERE 商品編號 LIKE 'A%'";
                        //第五步：取得資料並填入 DataSet
                        OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                        DataSet ds = new DataSet("ds_商品資料表");
                        oleda.Fill(ds, "ds_商品資料表");
                        //第六步：設定 DataSource
                        BindingSource1.DataSource = ds.Tables[0];
                        dataGridView1.DataSource = BindingSource1;
                        //第七步：關閉資料庫連線
                        cn.Close();                
                        break;
                    }
                case 1:
                    {
                        //第一步：設定連線字串
                        String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
                        //第二步：建立資料庫連線物件
                        OleDbConnection cn = new OleDbConnection(strConnectionString);
                        //第三步：開啟資料庫連線
                        cn.Open();
                        //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                        String sql = "SELECT * FROM 商品資料表 WHERE 商品編號 LIKE 'B%'";
                        //第五步：取得資料並填入 DataSet
                        OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                        DataSet ds = new DataSet("ds_商品資料表");
                        oleda.Fill(ds, "ds_商品資料表");
                        //第六步：設定 DataSource
                        BindingSource1.DataSource = ds.Tables[0];
                        dataGridView1.DataSource = BindingSource1;
                        //第七步：關閉資料庫連線
                        cn.Close();                     
                        break;
                    }
                case 2:
                    {
                        //第一步：設定連線字串
                        String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
                        //第二步：建立資料庫連線物件
                        OleDbConnection cn = new OleDbConnection(strConnectionString);
                        //第三步：開啟資料庫連線
                        cn.Open();
                        //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                        String sql = "SELECT * FROM 商品資料表 WHERE 商品編號 LIKE 'C%'";
                        //第五步：取得資料並填入 DataSet
                        OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                        DataSet ds = new DataSet("ds_商品資料表");
                        oleda.Fill(ds, "ds_商品資料表");
                        //第六步：設定 DataSource
                        BindingSource1.DataSource = ds.Tables[0];
                        dataGridView1.DataSource = BindingSource1;
                        //第七步：關閉資料庫連線
                        cn.Close();
                        break;
                    }
                case 3:
                    {
                        //第一步：設定連線字串
                        String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
                        //第二步：建立資料庫連線物件
                        OleDbConnection cn = new OleDbConnection(strConnectionString);
                        //第三步：開啟資料庫連線
                        cn.Open();
                        //★ 第四步：利用 OleDbCommand 執行 SQL 語法
                        String sql = "SELECT * FROM 商品資料表 WHERE 商品編號 LIKE 'D%'";
                        //第五步：取得資料並填入 DataSet
                        OleDbDataAdapter oleda = new OleDbDataAdapter(sql, cn);
                        DataSet ds = new DataSet("ds_商品資料表");
                        oleda.Fill(ds, "ds_商品資料表");
                        //第六步：設定 DataSource
                        BindingSource1.DataSource = ds.Tables[0];
                        dataGridView1.DataSource = BindingSource1;
                        //第七步：關閉資料庫連線
                        cn.Close();
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //第一步：設定連線字串
            String strConnectionString3 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
            //第二步：建立資料庫連線物件
            OleDbConnection cn3 = new OleDbConnection(strConnectionString3);
            //第三步：開啟資料庫連線
            cn3.Open();           
            int selected_row = dataGridView1.CurrentRow.Index;
            String strSQL = "INSERT INTO 購物車(商品編號,商品名稱,商品價格,商品數量) VALUES('" + dataGridView1.Rows[selected_row].Cells[0].Value + "','" + dataGridView1.Rows[selected_row].Cells[1].Value + "','" + dataGridView1.Rows[selected_row].Cells[2].Value + "','" + "1" + "')";
            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn3);
            cmdLiming.ExecuteNonQuery();
            OleDbDataAdapter oleda2 = new OleDbDataAdapter("SELECT * FROM 購物車", cn3);
            DataSet ds2 = new DataSet("ds購物車");
            oleda2.Fill(ds2, "ds_購物車");
            //第七步：關閉資料庫連線
            cn3.Close();
            MessageBox.Show("加入成功!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            user f2 = new user();
            f2.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
