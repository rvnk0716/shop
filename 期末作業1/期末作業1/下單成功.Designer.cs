namespace 期末作業1
{
    partial class 下單成功
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.database1DataSet2 = new 期末作業1.Database1DataSet2();
            this.購物車BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.購物車TableAdapter = new 期末作業1.Database1DataSet2TableAdapters.購物車TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.購物車BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.購物車BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "期末作業1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(555, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 購物車BindingSource
            // 
            this.購物車BindingSource.DataMember = "購物車";
            this.購物車BindingSource.DataSource = this.database1DataSet2;
            // 
            // 購物車TableAdapter
            // 
            this.購物車TableAdapter.ClearBeforeFill = true;
            // 
            // 下單成功
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 307);
            this.Controls.Add(this.reportViewer1);
            this.Name = "下單成功";
            this.Text = "下單成功";
            this.Load += new System.EventHandler(this.下單成功_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.購物車BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource 購物車BindingSource;
        private Database1DataSet2TableAdapters.購物車TableAdapter 購物車TableAdapter;
    }
}