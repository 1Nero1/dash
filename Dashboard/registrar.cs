using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void abrirRegistros(object abrirf)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = abrirf as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill; 
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            abrirRegistros(new regEmpresa());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirRegistros(new regProductos());
        }
    }
}
