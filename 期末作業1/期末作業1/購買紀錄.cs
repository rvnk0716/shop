using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末作業1
{
    public partial class 購買紀錄 : Form
    {
        public 購買紀錄()
        {
            InitializeComponent();
        }

        private void 購買紀錄_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'Database1DataSet3.購買紀錄' 資料表。您可以視需要進行移動或移除。
            this.購買紀錄TableAdapter.Fill(this.Database1DataSet3.購買紀錄);







            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
