using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Cnumeral
{
    public partial class Imprimir2 : Form
    {
        public Imprimir2()
        {
            InitializeComponent();
        }

        private void Imprimir2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.PROVEEDORESTableAdapter.Fill(this.ALMACENDataSet3.PROVEEDORES);

        
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
