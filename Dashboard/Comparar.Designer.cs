namespace Dashboard
{
    partial class Comparar
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
            this.label1 = new System.Windows.Forms.Label();
            this.date_ini = new System.Windows.Forms.DateTimePicker();
            this.date_reciente = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Empresa1 = new System.Windows.Forms.Label();
            this.comboBoxEmp1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEmp2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_emp1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_emp2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_prod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comparativa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // date_ini
            // 
            this.date_ini.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.date_ini.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.date_ini.CustomFormat = "MMM dd, yyyy";
            this.date_ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ini.Location = new System.Drawing.Point(208, 19);
            this.date_ini.Name = "date_ini";
            this.date_ini.Size = new System.Drawing.Size(93, 20);
            this.date_ini.TabIndex = 1;
            this.date_ini.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // date_reciente
            // 
            this.date_reciente.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.date_reciente.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.date_reciente.CustomFormat = "MMM dd, yyyy";
            this.date_reciente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_reciente.Location = new System.Drawing.Point(320, 19);
            this.date_reciente.Name = "date_reciente";
            this.date_reciente.Size = new System.Drawing.Size(93, 20);
            this.date_reciente.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Productos mas vendidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona las empresas a comparar:";
            // 
            // Empresa1
            // 
            this.Empresa1.AutoSize = true;
            this.Empresa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empresa1.Location = new System.Drawing.Point(30, 93);
            this.Empresa1.Name = "Empresa1";
            this.Empresa1.Size = new System.Drawing.Size(57, 15);
            this.Empresa1.TabIndex = 5;
            this.Empresa1.Text = "Empresa";
            // 
            // comboBoxEmp1
            // 
            this.comboBoxEmp1.FormattingEnabled = true;
            this.comboBoxEmp1.Location = new System.Drawing.Point(94, 93);
            this.comboBoxEmp1.Name = "comboBoxEmp1";
            this.comboBoxEmp1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmp1.TabIndex = 6;
            this.comboBoxEmp1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmp1_SelectedIndexChanged);
            // 
            // comboBoxEmp2
            // 
            this.comboBoxEmp2.FormattingEnabled = true;
            this.comboBoxEmp2.Location = new System.Drawing.Point(638, 87);
            this.comboBoxEmp2.Name = "comboBoxEmp2";
            this.comboBoxEmp2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmp2.TabIndex = 8;
            this.comboBoxEmp2.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmp2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empresa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 190);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dataGridView_emp1
            // 
            this.dataGridView_emp1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_emp1.Location = new System.Drawing.Point(21, 131);
            this.dataGridView_emp1.Name = "dataGridView_emp1";
            this.dataGridView_emp1.Size = new System.Drawing.Size(410, 241);
            this.dataGridView_emp1.TabIndex = 10;
            // 
            // dataGridView_emp2
            // 
            this.dataGridView_emp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_emp2.Location = new System.Drawing.Point(455, 131);
            this.dataGridView_emp2.Name = "dataGridView_emp2";
            this.dataGridView_emp2.Size = new System.Drawing.Size(410, 241);
            this.dataGridView_emp2.TabIndex = 14;
            this.dataGridView_emp2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Comparar productos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_prod
            // 
            this.cb_prod.FormattingEnabled = true;
            this.cb_prod.Location = new System.Drawing.Point(629, 18);
            this.cb_prod.Name = "cb_prod";
            this.cb_prod.Size = new System.Drawing.Size(121, 21);
            this.cb_prod.TabIndex = 17;
            this.cb_prod.SelectedIndexChanged += new System.EventHandler(this.cb_prod_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Productos";
            // 
            // Comparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 385);
            this.Controls.Add(this.cb_prod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView_emp2);
            this.Controls.Add(this.dataGridView_emp1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBoxEmp2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmp1);
            this.Controls.Add(this.Empresa1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_reciente);
            this.Controls.Add(this.date_ini);
            this.Controls.Add(this.label1);
            this.Name = "Comparar";
            this.Text = "Comparar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_ini;
        private System.Windows.Forms.DateTimePicker date_reciente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Empresa1;
        private System.Windows.Forms.ComboBox comboBoxEmp1;
        private System.Windows.Forms.ComboBox comboBoxEmp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_emp1;
        private System.Windows.Forms.DataGridView dataGridView_emp2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_prod;
        private System.Windows.Forms.Label label4;
    }
}