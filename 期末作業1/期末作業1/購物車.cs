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
    public partial class 購物車 : Form
    {
        BindingSource BindingSource1;
        public 購物車()
        {
            BindingSource1 = new BindingSource();
            InitializeComponent();
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            商品 d1 = new 商品();
            d1.Show();
            this.Hide();
        }

        private void 購物車_Load(object sender, EventArgs e)
        {
           
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //第四步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 購物車", cn);
            DataSet ds = new DataSet("ds_購物車");
            oleda.Fill(ds, "ds_購物車");
         
            BindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = BindingSource1;
    
            //第六步：關閉資料庫連線
            cn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
            button3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button3.Visible = true;
            numericUpDown1.Visible = false;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {        
                int selected_row = dataGridView1.CurrentRow.Index;
                label3.Text = dataGridView1.Rows[selected_row].Cells[1].FormattedValue.ToString();         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
            String strSQL = "DELETE FROM 購物車 WHERE 商品名稱='" + label3.Text + "'";

            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn);
            cmdLiming.ExecuteNonQuery();
            //第五步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 購物車", cn);
            DataSet ds = new DataSet("ds_購物車");
            oleda.Fill(ds, "ds_購物車");

            //第六步：設定 DataSource
            BindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = BindingSource1;
           

            //第七步：關閉資料庫連線
            cn.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
              
          
            //第一步：設定連線字串
            String strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

            //第二步：建立資料庫連線物件
            OleDbConnection cn = new OleDbConnection(strConnectionString);

            //第三步：開啟資料庫連線
            cn.Open();

            //★ 第四步：利用 OleDbCommand 執行 SQL 語法
            String strSQL = "UPDATE 購物車 SET 商品數量='" + numericUpDown1.Value + "' WHERE 商品名稱='" + label3.Text + "'";

            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn);
            cmdLiming.ExecuteNonQuery();

            //第五步：取得資料並填入 DataSet
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT * FROM 購物車", cn);
            DataSet ds = new DataSet("ds_購物車");
            oleda.Fill(ds, "ds_購物車");

            //第六步：設定 DataSource
            BindingSource1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = BindingSource1;
           
            //第七步：關閉資料庫連線
            cn.Close();        
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            下單成功 r1 = new 下單成功();
            r1.ShowDialog();

             //第一步：設定連線字串
            String strConnectionString3 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
            //第二步：建立資料庫連線物件
            OleDbConnection cn3 = new OleDbConnection(strConnectionString3);
            //第三步：開啟資料庫連線
            cn3.Open();



            DateTime now = DateTime.Now;
            String strSQL = "INSERT INTO 購買紀錄(購買日期,總計) SELECT Now(),SUM(商品價格*商品數量) FROM 購物車";
            

            OleDbCommand cmdLiming = new OleDbCommand(strSQL, cn3);
         

            cmdLiming.ExecuteNonQuery();
          

            OleDbDataAdapter oleda2 = new OleDbDataAdapter("SELECT * FROM 購買紀錄", cn3);
            DataSet ds2 = new DataSet("ds購買紀錄");
            oleda2.Fill(ds2, "ds_購買紀錄");
            //第七步：關閉資料庫連線
            cn3.Close();
        }
    }
}
