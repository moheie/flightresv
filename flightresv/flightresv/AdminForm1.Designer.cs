namespace flightresv
{
    partial class AdminForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm1));
            this.aircraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flightDataSet = new flightresv.flightDataSet();
            this.aircraftBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftTableAdapter1 = new flightresv.flightDataSetTableAdapters.aircraftTableAdapter();
            this.tableAdapterManager1 = new flightresv.flightDataSetTableAdapters.TableAdapterManager();
            this.aircraftDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aircraftcapacity = new System.Windows.Forms.TextBox();
            this.aircraftmodel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aircraftIdTextBox = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aircraftBindingSource
            // 
            this.aircraftBindingSource.DataMember = "Aircraft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(298, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "manage Aircraft";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(725, 41);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Tomato;
            this.button5.Location = new System.Drawing.Point(713, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 35);
            this.button5.TabIndex = 23;
            this.button5.Text = "back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // flightDataSet
            // 
            this.flightDataSet.DataSetName = "flightDataSet";
            this.flightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aircraftBindingSource1
            // 
            this.aircraftBindingSource1.DataMember = "aircraft";
            this.aircraftBindingSource1.DataSource = this.flightDataSet;
            // 
            // aircraftTableAdapter1
            // 
            this.aircraftTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.aircraftTableAdapter = this.aircraftTableAdapter1;
            this.tableAdapterManager1.airportTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.bookingTableAdapter = null;
            this.tableAdapterManager1.flightTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = flightresv.flightDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.userTableAdapter = null;
            // 
            // aircraftDataGridView
            // 
            this.aircraftDataGridView.AutoGenerateColumns = false;
            this.aircraftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aircraftDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.aircraftDataGridView.DataSource = this.aircraftBindingSource1;
            this.aircraftDataGridView.Location = new System.Drawing.Point(276, 136);
            this.aircraftDataGridView.Name = "aircraftDataGridView";
            this.aircraftDataGridView.RowHeadersWidth = 51;
            this.aircraftDataGridView.RowTemplate.Height = 24;
            this.aircraftDataGridView.Size = new System.Drawing.Size(477, 220);
            this.aircraftDataGridView.TabIndex = 23;
            this.aircraftDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aircraftDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn2.HeaderText = "model";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "capacity";
            this.dataGridViewTextBoxColumn3.HeaderText = "capacity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "model";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "capacity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // aircraftcapacity
            // 
            this.aircraftcapacity.Location = new System.Drawing.Point(488, 91);
            this.aircraftcapacity.Name = "aircraftcapacity";
            this.aircraftcapacity.Size = new System.Drawing.Size(125, 22);
            this.aircraftcapacity.TabIndex = 54;
            // 
            // aircraftmodel
            // 
            this.aircraftmodel.Location = new System.Drawing.Point(355, 91);
            this.aircraftmodel.Name = "aircraftmodel";
            this.aircraftmodel.Size = new System.Drawing.Size(100, 22);
            this.aircraftmodel.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "aircraft ID";
            // 
            // aircraftIdTextBox
            // 
            this.aircraftIdTextBox.Location = new System.Drawing.Point(128, 318);
            this.aircraftIdTextBox.Name = "aircraftIdTextBox";
            this.aircraftIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.aircraftIdTextBox.TabIndex = 50;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(29, 303);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 37);
            this.update.TabIndex = 49;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 48;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 47;
            this.button2.Text = "insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aircraftcapacity);
            this.Controls.Add(this.aircraftmodel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aircraftIdTextBox);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aircraftDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm1";
            this.Load += new System.EventHandler(this.AdminForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private flight4321DataSet flight4321DataSet;
        private System.Windows.Forms.BindingSource aircraftBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private flightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource aircraftBindingSource1;
        private flightDataSetTableAdapters.aircraftTableAdapter aircraftTableAdapter1;
        private flightDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView aircraftDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aircraftcapacity;
        private System.Windows.Forms.TextBox aircraftmodel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aircraftIdTextBox;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}