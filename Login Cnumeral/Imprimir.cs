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
    public partial class Imprimir : Form
    {
        public Imprimir()
        {
            InitializeComponent();
        }

        private void Imprimir_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet3.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.PRODUCTOSTableAdapter.Fill(this.ALMACENDataSet3.PRODUCTOS);
            // TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet3.Nomina' Puede moverla o quitarla según sea necesario.


            this.reportViewer1.RefreshReport();
        }

        private void Cmb_Tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
