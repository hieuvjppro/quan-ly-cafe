namespace QLQuanCaphe.FORM
{
    partial class fInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInHoaDon));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hoaDonTTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLQuanCaphe.DataSet1();
            this.hoaDonTTTableAdapter = new QLQuanCaphe.DataSet1TableAdapters.HoaDonTTTableAdapter();
            this.hoaDonTTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTTBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRP = new System.Windows.Forms.Button();
            this.dateNow = new System.Windows.Forms.DateTimePicker();
            this.numKhuyenMai = new System.Windows.Forms.NumericUpDown();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDonTTBindingSource
            // 
            this.hoaDonTTBindingSource.DataMember = "HoaDonTT";
            this.hoaDonTTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonTTTableAdapter
            // 
            this.hoaDonTTTableAdapter.ClearBeforeFill = true;
            // 
            // hoaDonTTBindingSource1
            // 
            this.hoaDonTTBindingSource1.DataMember = "HoaDonTT";
            this.hoaDonTTBindingSource1.DataSource = this.dataSet1;
            // 
            // hoaDonTTBanBindingSource
            // 
            this.hoaDonTTBanBindingSource.DataMember = "HoaDonTTBan";
            // 
            // txtRP
            // 
            this.txtRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRP.Location = new System.Drawing.Point(162, 20);
            this.txtRP.Margin = new System.Windows.Forms.Padding(2);
            this.txtRP.Name = "txtRP";
            this.txtRP.Size = new System.Drawing.Size(136, 22);
            this.txtRP.TabIndex = 14;
            this.txtRP.Text = "Bàn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập tên bàn: ";
            // 
            // btRP
            // 
            this.btRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRP.Image = ((System.Drawing.Image)(resources.GetObject("btRP.Image")));
            this.btRP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRP.Location = new System.Drawing.Point(317, 16);
            this.btRP.Margin = new System.Windows.Forms.Padding(2);
            this.btRP.Name = "btRP";
            this.btRP.Size = new System.Drawing.Size(100, 29);
            this.btRP.TabIndex = 15;
            this.btRP.Text = "In hóa đơn";
            this.btRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRP.UseVisualStyleBackColor = true;
            this.btRP.Click += new System.EventHandler(this.btRP_Click);
            // 
            // dateNow
            // 
            this.dateNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNow.CustomFormat = "dd/MM/yyyy";
            this.dateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNow.Location = new System.Drawing.Point(159, 219);
            this.dateNow.Margin = new System.Windows.Forms.Padding(2);
            this.dateNow.Name = "dateNow";
            this.dateNow.Size = new System.Drawing.Size(0, 24);
            this.dateNow.TabIndex = 19;
            this.dateNow.Value = new System.DateTime(2023, 3, 15, 0, 0, 0, 0);
            // 
            // numKhuyenMai
            // 
            this.numKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKhuyenMai.Location = new System.Drawing.Point(237, 193);
            this.numKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.numKhuyenMai.Name = "numKhuyenMai";
            this.numKhuyenMai.Size = new System.Drawing.Size(38, 22);
            this.numKhuyenMai.TabIndex = 18;
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(147, 331);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(128, 22);
            this.txtNgay.TabIndex = 17;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetHoaDon";
            reportDataSource1.Value = this.hoaDonTTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLQuanCaphe.REPORT.rpHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(434, 574);
            this.reportViewer1.TabIndex = 20;
            // 
            // fInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 634);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtRP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRP);
            this.Controls.Add(this.dateNow);
            this.Controls.Add(this.numKhuyenMai);
            this.Controls.Add(this.txtNgay);
            this.Name = "fInHoaDon";
            this.Text = "fHoaDon";
            this.Load += new System.EventHandler(this.fInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource hoaDonTTBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.HoaDonTTTableAdapter hoaDonTTTableAdapter;
        private System.Windows.Forms.BindingSource hoaDonTTBindingSource1;
        private System.Windows.Forms.BindingSource hoaDonTTBanBindingSource;
        private System.Windows.Forms.TextBox txtRP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRP;
        private System.Windows.Forms.DateTimePicker dateNow;
        private System.Windows.Forms.NumericUpDown numKhuyenMai;
        private System.Windows.Forms.TextBox txtNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}