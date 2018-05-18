namespace 期末作業1
{
    partial class 購買紀錄
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.購買紀錄BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet3 = new 期末作業1.Database1DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.購買紀錄TableAdapter = new 期末作業1.Database1DataSet3TableAdapters.購買紀錄TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.購買紀錄BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // 購買紀錄BindingSource
            // 
            this.購買紀錄BindingSource.DataMember = "購買紀錄";
            this.購買紀錄BindingSource.DataSource = this.Database1DataSet3;
            // 
            // Database1DataSet3
            // 
            this.Database1DataSet3.DataSetName = "Database1DataSet3";
            this.Database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.購買紀錄BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "期末作業1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 15);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(692, 307);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // 購買紀錄TableAdapter
            // 
            this.購買紀錄TableAdapter.ClearBeforeFill = true;
            // 
            // 購買紀錄
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 380);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "購買紀錄";
            this.Text = "購買紀錄";
            this.Load += new System.EventHandler(this.購買紀錄_Load);
            ((System.ComponentModel.ISupportInitialize)(this.購買紀錄BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource 購買紀錄BindingSource;
        private Database1DataSet3 Database1DataSet3;
        private Database1DataSet3TableAdapters.購買紀錄TableAdapter 購買紀錄TableAdapter;
    }
}