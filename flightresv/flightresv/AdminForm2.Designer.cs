namespace flightresv
{
    partial class AdminForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm2));
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportTableAdapter = new flightresv.flight4321DataSetTableAdapters.AirportTableAdapter();
            this.tableAdapterManager = new flightresv.flight4321DataSetTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flightDataSet = new flightresv.flightDataSet();
            this.airportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airportTableAdapter1 = new flightresv.flightDataSetTableAdapters.airportTableAdapter();
            this.tableAdapterManager1 = new flightresv.flightDataSetTableAdapters.TableAdapterManager();
            this.airportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.airportIdTextBox = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.airportNameTextBox = new System.Windows.Forms.TextBox();
            this.airportCityTextBox = new System.Windows.Forms.TextBox();
            this.airportCountryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airportBindingSource
            // 
            this.airportBindingSource.DataMember = "Airport";
            // 
            // airportTableAdapter
            // 
            this.airportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AircraftTableAdapter = null;
            this.tableAdapterManager.AirportTableAdapter = this.airportTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.FliesTableAdapter = null;
            this.tableAdapterManager.flightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = flightresv.flight4321DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(321, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "manage Airports";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(726, 45);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 34);
            this.button3.TabIndex = 21;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(680, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 35);
            this.button5.TabIndex = 22;
            this.button5.Text = "back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // flightDataSet
            // 
            this.flightDataSet.DataSetName = "flightDataSet";
            this.flightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportBindingSource1
            // 
            this.airportBindingSource1.DataMember = "airport";
            this.airportBindingSource1.DataSource = this.flightDataSet;
            // 
            // airportTableAdapter1
            // 
            this.airportTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.aircraftTableAdapter = null;
            this.tableAdapterManager1.airportTableAdapter = this.airportTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.bookingTableAdapter = null;
            this.tableAdapterManager1.flightTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = flightresv.flightDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.userTableAdapter = null;
            // 
            // airportDataGridView
            // 
            this.airportDataGridView.AutoGenerateColumns = false;
            this.airportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.airportDataGridView.DataSource = this.airportBindingSource1;
            this.airportDataGridView.Location = new System.Drawing.Point(227, 138);
            this.airportDataGridView.Name = "airportDataGridView";
            this.airportDataGridView.RowHeadersWidth = 51;
            this.airportDataGridView.RowTemplate.Height = 24;
            this.airportDataGridView.Size = new System.Drawing.Size(548, 220);
            this.airportDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn3.HeaderText = "city";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn4.HeaderText = "country";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "airport ID";
            // 
            // airportIdTextBox
            // 
            this.airportIdTextBox.Location = new System.Drawing.Point(111, 294);
            this.airportIdTextBox.Name = "airportIdTextBox";
            this.airportIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.airportIdTextBox.TabIndex = 39;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 279);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 37);
            this.update.TabIndex = 38;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 36;
            this.button2.Text = "insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // airportNameTextBox
            // 
            this.airportNameTextBox.Location = new System.Drawing.Point(274, 104);
            this.airportNameTextBox.Name = "airportNameTextBox";
            this.airportNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.airportNameTextBox.TabIndex = 41;
            // 
            // airportCityTextBox
            // 
            this.airportCityTextBox.Location = new System.Drawing.Point(425, 104);
            this.airportCityTextBox.Name = "airportCityTextBox";
            this.airportCityTextBox.Size = new System.Drawing.Size(100, 22);
            this.airportCityTextBox.TabIndex = 42;
            // 
            // airportCountryTextBox
            // 
            this.airportCountryTextBox.Location = new System.Drawing.Point(567, 104);
            this.airportCountryTextBox.Name = "airportCountryTextBox";
            this.airportCountryTextBox.Size = new System.Drawing.Size(125, 22);
            this.airportCountryTextBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "city";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "country";
            // 
            // AdminForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.airportCountryTextBox);
            this.Controls.Add(this.airportCityTextBox);
            this.Controls.Add(this.airportNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.airportIdTextBox);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.airportDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm2";
            this.Load += new System.EventHandler(this.AdminForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private flight4321DataSet flight4321DataSet;
        private System.Windows.Forms.BindingSource airportBindingSource;
        private flight4321DataSetTableAdapters.AirportTableAdapter airportTableAdapter;
        private flight4321DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private flightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource airportBindingSource1;
        private flightDataSetTableAdapters.airportTableAdapter airportTableAdapter1;
        private flightDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView airportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox airportIdTextBox;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox airportNameTextBox;
        private System.Windows.Forms.TextBox airportCityTextBox;
        private System.Windows.Forms.TextBox airportCountryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}