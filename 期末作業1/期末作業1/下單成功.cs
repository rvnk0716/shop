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
using Microsoft.Reporting.WinForms;

namespace 期末作業1
{
    public partial class 下單成功 : Form
    {
        public 下單成功()
        {
            InitializeComponent();
        }

        private void 下單成功_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet2.購物車' 資料表。您可以視需要進行移動或移除。
            this.購物車TableAdapter.Fill(this.database1DataSet2.購物車);
            this.reportViewer1.RefreshReport();

        }
    }
}
