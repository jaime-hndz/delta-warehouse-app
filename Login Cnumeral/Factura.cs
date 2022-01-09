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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            
            try
            {
                this.PRODUCTOSTableAdapter.FillBy1(this.ALMACENDataSet3.PRODUCTOS, Login_Cnumeral.Properties.Settings.Default.Cod);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            // TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.



            
            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
