namespace Dashboard
{
    partial class registrar
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
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(1, 0);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(104, 35);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Marca";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Unidad Medida";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Producto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "venta";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(111, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(570, 359);
            this.panelContenedor.TabIndex = 5;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 361);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEmpresa);
            this.Name = "registrar";
            this.Text = "registrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelContenedor;
    }
}