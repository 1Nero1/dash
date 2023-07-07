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
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.dateReciente = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Empresa1 = new System.Windows.Forms.Label();
            this.comboBoxEmp1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEmp2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            // dateInicial
            // 
            this.dateInicial.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateInicial.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateInicial.CustomFormat = "MMM dd, yyyy";
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicial.Location = new System.Drawing.Point(208, 19);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(93, 20);
            this.dateInicial.TabIndex = 1;
            this.dateInicial.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateReciente
            // 
            this.dateReciente.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateReciente.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateReciente.CustomFormat = "MMM dd, yyyy";
            this.dateReciente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReciente.Location = new System.Drawing.Point(320, 19);
            this.dateReciente.Name = "dateReciente";
            this.dateReciente.Size = new System.Drawing.Size(93, 20);
            this.dateReciente.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.comboBoxEmp2.Location = new System.Drawing.Point(455, 93);
            this.comboBoxEmp2.Name = "comboBoxEmp2";
            this.comboBoxEmp2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmp2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 93);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 211);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(347, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 211);
            this.panel2.TabIndex = 11;
            // 
            // Comparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBoxEmp2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmp1);
            this.Controls.Add(this.Empresa1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateReciente);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.label1);
            this.Name = "Comparar";
            this.Text = "Comparar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.DateTimePicker dateReciente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Empresa1;
        private System.Windows.Forms.ComboBox comboBoxEmp1;
        private System.Windows.Forms.ComboBox comboBoxEmp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}