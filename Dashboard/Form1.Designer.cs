﻿namespace Dashboard
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.charComparativa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lab_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Comparar = new System.Windows.Forms.Button();
            this.date_ini = new System.Windows.Forms.DateTimePicker();
            this.lab_dateIni = new System.Windows.Forms.Label();
            this.lab_reciente = new System.Windows.Forms.Label();
            this.date_reciente = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_dia = new System.Windows.Forms.Button();
            this.panel_producto = new System.Windows.Forms.Panel();
            this.lab_S = new System.Windows.Forms.Label();
            this.lab_precio = new System.Windows.Forms.Label();
            this.lab_data = new System.Windows.Forms.Label();
            this.label_nam_product = new System.Windows.Forms.Label();
            this.label_producto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_produ_mas_vend = new System.Windows.Forms.Label();
            this.dataGrid_prod_vendidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.charComparativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopVentas)).BeginInit();
            this.panel_producto.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_prod_vendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // charComparativa
            // 
            chartArea1.Name = "chartComparativa";
            this.charComparativa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Comparacion";
            this.charComparativa.Legends.Add(legend1);
            this.charComparativa.Location = new System.Drawing.Point(-1, 226);
            this.charComparativa.Name = "charComparativa";
            this.charComparativa.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "chartComparativa";
            series1.Legend = "Legend1";
            series1.Name = "Empresas";
            this.charComparativa.Series.Add(series1);
            this.charComparativa.Size = new System.Drawing.Size(480, 270);
            this.charComparativa.TabIndex = 1;
            this.charComparativa.Text = "chart2";
            this.charComparativa.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chartTopVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTopVentas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Productos mas vendidos";
            this.chartTopVentas.Legends.Add(legend2);
            this.chartTopVentas.Location = new System.Drawing.Point(475, 226);
            this.chartTopVentas.Name = "chartTopVentas";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopVentas.Series.Add(series2);
            this.chartTopVentas.Size = new System.Drawing.Size(480, 270);
            this.chartTopVentas.TabIndex = 2;
            this.chartTopVentas.Text = "chartTopVentas";
            // 
            // lab_Titulo
            // 
            this.lab_Titulo.AutoSize = true;
            this.lab_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Titulo.Location = new System.Drawing.Point(3, -2);
            this.lab_Titulo.Name = "lab_Titulo";
            this.lab_Titulo.Size = new System.Drawing.Size(147, 31);
            this.lab_Titulo.TabIndex = 4;
            this.lab_Titulo.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para realizar comparativas entre \r\nempresar dar click en el siguiente boton";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Comparar
            // 
            this.btn_Comparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comparar.Location = new System.Drawing.Point(735, 116);
            this.btn_Comparar.Name = "btn_Comparar";
            this.btn_Comparar.Size = new System.Drawing.Size(121, 67);
            this.btn_Comparar.TabIndex = 6;
            this.btn_Comparar.Text = "Comparar";
            this.btn_Comparar.UseVisualStyleBackColor = true;
            this.btn_Comparar.Click += new System.EventHandler(this.btn_Comparar_Click);
            // 
            // date_ini
            // 
            this.date_ini.CustomFormat = "MMM dd, yyyy";
            this.date_ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ini.Location = new System.Drawing.Point(179, 27);
            this.date_ini.Name = "date_ini";
            this.date_ini.Size = new System.Drawing.Size(99, 20);
            this.date_ini.TabIndex = 7;
            this.date_ini.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lab_dateIni
            // 
            this.lab_dateIni.AutoSize = true;
            this.lab_dateIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_dateIni.Location = new System.Drawing.Point(176, 7);
            this.lab_dateIni.Name = "lab_dateIni";
            this.lab_dateIni.Size = new System.Drawing.Size(103, 17);
            this.lab_dateIni.TabIndex = 8;
            this.lab_dateIni.Text = "Fecha de inicio";
            this.lab_dateIni.Click += new System.EventHandler(this.lab_dateIni_Click);
            // 
            // lab_reciente
            // 
            this.lab_reciente.AutoSize = true;
            this.lab_reciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_reciente.Location = new System.Drawing.Point(297, 7);
            this.lab_reciente.Name = "lab_reciente";
            this.lab_reciente.Size = new System.Drawing.Size(132, 17);
            this.lab_reciente.TabIndex = 9;
            this.lab_reciente.Text = "Fecha mas reciente";
            // 
            // date_reciente
            // 
            this.date_reciente.CustomFormat = "MMM dd, yyyy";
            this.date_reciente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_reciente.Location = new System.Drawing.Point(300, 27);
            this.date_reciente.Name = "date_reciente";
            this.date_reciente.Size = new System.Drawing.Size(107, 20);
            this.date_reciente.TabIndex = 10;
            this.date_reciente.ValueChanged += new System.EventHandler(this.date_act_ValueChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(435, 24);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_dia
            // 
            this.btn_dia.Location = new System.Drawing.Point(545, 24);
            this.btn_dia.Name = "btn_dia";
            this.btn_dia.Size = new System.Drawing.Size(118, 23);
            this.btn_dia.TabIndex = 12;
            this.btn_dia.Text = "Más detalles";
            this.btn_dia.UseVisualStyleBackColor = true;
            this.btn_dia.Click += new System.EventHandler(this.btn_dia_Click);
            // 
            // panel_producto
            // 
            this.panel_producto.BackColor = System.Drawing.SystemColors.Window;
            this.panel_producto.Controls.Add(this.lab_S);
            this.panel_producto.Controls.Add(this.lab_precio);
            this.panel_producto.Controls.Add(this.lab_data);
            this.panel_producto.Controls.Add(this.label_nam_product);
            this.panel_producto.Controls.Add(this.label_producto);
            this.panel_producto.Location = new System.Drawing.Point(9, 53);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(210, 121);
            this.panel_producto.TabIndex = 15;
            // 
            // lab_S
            // 
            this.lab_S.AutoSize = true;
            this.lab_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_S.Location = new System.Drawing.Point(44, 85);
            this.lab_S.Name = "lab_S";
            this.lab_S.Size = new System.Drawing.Size(19, 20);
            this.lab_S.TabIndex = 4;
            this.lab_S.Text = "$";
            // 
            // lab_precio
            // 
            this.lab_precio.AutoSize = true;
            this.lab_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_precio.Location = new System.Drawing.Point(68, 85);
            this.lab_precio.Name = "lab_precio";
            this.lab_precio.Size = new System.Drawing.Size(59, 20);
            this.lab_precio.TabIndex = 3;
            this.lab_precio.Text = "Precio";
            this.lab_precio.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab_data
            // 
            this.lab_data.AutoSize = true;
            this.lab_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_data.Location = new System.Drawing.Point(8, 54);
            this.lab_data.Name = "lab_data";
            this.lab_data.Size = new System.Drawing.Size(183, 15);
            this.lab_data.TabIndex = 2;
            this.lab_data.Text = "fecha de registro o actualizacion";
            // 
            // label_nam_product
            // 
            this.label_nam_product.AutoSize = true;
            this.label_nam_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nam_product.Location = new System.Drawing.Point(56, 25);
            this.label_nam_product.Name = "label_nam_product";
            this.label_nam_product.Size = new System.Drawing.Size(71, 20);
            this.label_nam_product.TabIndex = 1;
            this.label_nam_product.Text = "Nombre";
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.Location = new System.Drawing.Point(25, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(149, 17);
            this.label_producto.TabIndex = 0;
            this.label_producto.Text = "Producto mas vendido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lab_produ_mas_vend);
            this.panel1.Controls.Add(this.dataGrid_prod_vendidos);
            this.panel1.Location = new System.Drawing.Point(225, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 167);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lab_produ_mas_vend
            // 
            this.lab_produ_mas_vend.AutoSize = true;
            this.lab_produ_mas_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_produ_mas_vend.Location = new System.Drawing.Point(4, 4);
            this.lab_produ_mas_vend.Name = "lab_produ_mas_vend";
            this.lab_produ_mas_vend.Size = new System.Drawing.Size(232, 15);
            this.lab_produ_mas_vend.TabIndex = 1;
            this.lab_produ_mas_vend.Text = "Productos más vendidos por tienda";
            this.lab_produ_mas_vend.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // dataGrid_prod_vendidos
            // 
            this.dataGrid_prod_vendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_prod_vendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_prod_vendidos.Location = new System.Drawing.Point(3, 25);
            this.dataGrid_prod_vendidos.Name = "dataGrid_prod_vendidos";
            this.dataGrid_prod_vendidos.Size = new System.Drawing.Size(432, 139);
            this.dataGrid_prod_vendidos.TabIndex = 0;
            this.dataGrid_prod_vendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_prod_vendidos_CellContentClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_producto);
            this.Controls.Add(this.btn_dia);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.date_reciente);
            this.Controls.Add(this.lab_reciente);
            this.Controls.Add(this.lab_dateIni);
            this.Controls.Add(this.date_ini);
            this.Controls.Add(this.btn_Comparar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_Titulo);
            this.Controls.Add(this.chartTopVentas);
            this.Controls.Add(this.charComparativa);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charComparativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopVentas)).EndInit();
            this.panel_producto.ResumeLayout(false);
            this.panel_producto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_prod_vendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart charComparativa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopVentas;
        private System.Windows.Forms.Label lab_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Comparar;
        private System.Windows.Forms.DateTimePicker date_ini;
        private System.Windows.Forms.Label lab_dateIni;
        private System.Windows.Forms.Label lab_reciente;
        private System.Windows.Forms.DateTimePicker date_reciente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_dia;
        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Label label_nam_product;
        private System.Windows.Forms.Label lab_data;
        private System.Windows.Forms.Label lab_precio;
        private System.Windows.Forms.Label lab_S;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_prod_vendidos;
        private System.Windows.Forms.Label lab_produ_mas_vend;
    }
}

