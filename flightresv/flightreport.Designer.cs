namespace flightresv
{
    partial class flightreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flightreport));
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSet = new flightresv.flightDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.flightTableAdapter = new flightresv.flightDataSetTableAdapters.flightTableAdapter();
            this.flightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.flightBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "flight";
            this.flightBindingSource.DataSource = this.flightDataSet;
            // 
            // flightDataSet
            // 
            this.flightDataSet.DataSetName = "flightDataSet";
            this.flightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(702, 24);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 37);
            this.button4.TabIndex = 28;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(638, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 53);
            this.button1.TabIndex = 29;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.flightBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "flightresv.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 296);
            this.reportViewer1.TabIndex = 32;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // flightDataSetBindingSource
            // 
            this.flightDataSetBindingSource.DataSource = this.flightDataSet;
            this.flightDataSetBindingSource.Position = 0;
            // 
            // flightBindingSource1
            // 
            this.flightBindingSource1.DataMember = "flight";
            this.flightBindingSource1.DataSource = this.flightDataSetBindingSource;
            // 
            // flightBindingSource2
            // 
            this.flightBindingSource2.DataMember = "flight";
            this.flightBindingSource2.DataSource = this.flightDataSetBindingSource;
            // 
            // flightDataSetBindingSource1
            // 
            this.flightDataSetBindingSource1.DataSource = this.flightDataSet;
            this.flightDataSetBindingSource1.Position = 0;
            // 
            // flightBindingSource3
            // 
            this.flightBindingSource3.DataMember = "flight";
            this.flightBindingSource3.DataSource = this.flightDataSetBindingSource;
            // 
            // flightDataSetBindingSource2
            // 
            this.flightDataSetBindingSource2.DataSource = this.flightDataSet;
            this.flightDataSetBindingSource2.Position = 0;
            // 
            // flightBindingSource4
            // 
            this.flightBindingSource4.DataMember = "flight";
            this.flightBindingSource4.DataSource = this.flightDataSetBindingSource1;
            // 
            // flightBindingSource5
            // 
            this.flightBindingSource5.DataMember = "flight";
            this.flightBindingSource5.DataSource = this.flightDataSetBindingSource;
            // 
            // flightreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "flightreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flightreport";
            this.Load += new System.EventHandler(this.flightreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private flightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private flightDataSetTableAdapters.flightTableAdapter flightTableAdapter;
        private System.Windows.Forms.BindingSource flightDataSetBindingSource;
        private System.Windows.Forms.BindingSource flightBindingSource1;
        private System.Windows.Forms.BindingSource flightBindingSource2;
        private System.Windows.Forms.BindingSource flightDataSetBindingSource1;
        private System.Windows.Forms.BindingSource flightBindingSource3;
        private System.Windows.Forms.BindingSource flightDataSetBindingSource2;
        private System.Windows.Forms.BindingSource flightDataSet2BindingSource;
        //private flightDataSet2 flightDataSet2;
        private System.Windows.Forms.BindingSource flightBindingSource4;
        private System.Windows.Forms.BindingSource flightBindingSource5;
    }
}