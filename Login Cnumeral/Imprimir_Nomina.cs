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
    public partial class Imprimir_Nomina : Form
    {
        public Imprimir_Nomina()
        {
            InitializeComponent();
        }

        private void Imprimir_Nomina_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet1.Nomina' Puede moverla o quitarla según sea necesario.
            this.NominaTableAdapter.Fill(this.ALMACENDataSet3.Nomina);
          
            this.reportViewer1.RefreshReport();
        }
    }
}
