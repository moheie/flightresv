namespace flightresv
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight4321DataSet = new flightresv.flight4321DataSet();
            this.flightTableAdapter = new flightresv.flight4321DataSetTableAdapters.flightTableAdapter();
            this.tableAdapterManager = new flightresv.flight4321DataSetTableAdapters.TableAdapterManager();
            this.aircraftTableAdapter = new flightresv.flight4321DataSetTableAdapters.AircraftTableAdapter();
            this.airportTableAdapter = new flightresv.flight4321DataSetTableAdapters.AirportTableAdapter();
            this.aircraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSet = new flightresv.flightDataSet();
            this.flightTableAdapter1 = new flightresv.flightDataSetTableAdapters.flightTableAdapter();
            this.flightBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new flightresv.flightDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.airportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.airportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.airportTableAdapter1 = new flightresv.flightDataSetTableAdapters.airportTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.aircraftBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftTableAdapter1 = new flightresv.flightDataSetTableAdapters.aircraftTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight4321DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1159, 41);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(570, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "manage flights";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "flight";
            this.flightBindingSource.DataSource = this.flight4321DataSet;
            // 
            // flight4321DataSet
            // 
            this.flight4321DataSet.DataSetName = "flight4321DataSet";
            this.flight4321DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AircraftTableAdapter = this.aircraftTableAdapter;
            this.tableAdapterManager.AirportTableAdapter = this.airportTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.FliesTableAdapter = null;
            this.tableAdapterManager.flightTableAdapter = this.flightTableAdapter;
            this.tableAdapterManager.UpdateOrder = flightresv.flight4321DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // aircraftTableAdapter
            // 
            this.aircraftTableAdapter.ClearBeforeFill = true;
            // 
            // airportTableAdapter
            // 
            this.airportTableAdapter.ClearBeforeFill = true;
            // 
            // aircraftBindingSource
            // 
            this.aircraftBindingSource.DataMember = "Aircraft";
            this.aircraftBindingSource.DataSource = this.flight4321DataSet;
            // 
            // airportBindingSource
            // 
            this.airportBindingSource.DataMember = "Airport";
            this.airportBindingSource.DataSource = this.flight4321DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 192);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // flightBindingSource1
            // 
            this.flightBindingSource1.DataMember = "flight";
            this.flightBindingSource1.DataSource = this.flightDataSetBindingSource;
            // 
            // flightDataSetBindingSource
            // 
            this.flightDataSetBindingSource.DataSource = this.flightDataSet;
            this.flightDataSetBindingSource.Position = 0;
            // 
            // flightDataSet
            // 
            this.flightDataSet.DataSetName = "flightDataSet";
            this.flightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightTableAdapter1
            // 
            this.flightTableAdapter1.ClearBeforeFill = true;
            // 
            // flightBindingSource2
            // 
            this.flightBindingSource2.DataMember = "flight";
            this.flightBindingSource2.DataSource = this.flightDataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.aircraftTableAdapter = null;
            this.tableAdapterManager1.airportTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.bookingTableAdapter = null;
            this.tableAdapterManager1.flightTableAdapter = this.flightTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = flightresv.flightDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.userTableAdapter = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "departure date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "arrival date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1022, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "aircraft ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(541, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(769, 131);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 37);
            this.button4.TabIndex = 32;
            this.button4.Text = "update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 37);
            this.button5.TabIndex = 33;
            this.button5.Text = "back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(133, 323);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.flightIdTextBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "flight ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.airportBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.ValueMember = "id";
            // 
            // airportBindingSource1
            // 
            this.airportBindingSource1.DataMember = "airport";
            this.airportBindingSource1.DataSource = this.flightDataSetBindingSource;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.airportBindingSource2;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(376, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.ValueMember = "id";
            // 
            // airportBindingSource2
            // 
            this.airportBindingSource2.DataMember = "airport";
            this.airportBindingSource2.DataSource = this.flightDataSetBindingSource;
            // 
            // airportTableAdapter1
            // 
            this.airportTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.aircraftBindingSource1;
            this.comboBox3.DisplayMember = "model";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(994, 133);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 38;
            this.comboBox3.ValueMember = "id";
            // 
            // aircraftBindingSource1
            // 
            this.aircraftBindingSource1.DataMember = "aircraft";
            this.aircraftBindingSource1.DataSource = this.flightDataSetBindingSource;
            // 
            // aircraftTableAdapter1
            // 
            this.aircraftTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1228, 628);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight4321DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private flight4321DataSet flight4321DataSet;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private flight4321DataSetTableAdapters.flightTableAdapter flightTableAdapter;
        private flight4321DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private flight4321DataSetTableAdapters.AircraftTableAdapter aircraftTableAdapter;
        private System.Windows.Forms.BindingSource aircraftBindingSource;
        private flight4321DataSetTableAdapters.AirportTableAdapter airportTableAdapter;
        private System.Windows.Forms.BindingSource airportBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource flightDataSetBindingSource;
        private flightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource flightBindingSource1;
        private flightDataSetTableAdapters.flightTableAdapter flightTableAdapter1;
        private System.Windows.Forms.BindingSource flightBindingSource2;
        private flightDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource airportBindingSource1;
        private flightDataSetTableAdapters.airportTableAdapter airportTableAdapter1;
        private System.Windows.Forms.BindingSource airportBindingSource2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource aircraftBindingSource1;
        private flightDataSetTableAdapters.aircraftTableAdapter aircraftTableAdapter1;
    }
}