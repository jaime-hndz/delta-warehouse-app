using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; using System.Data.SqlServerCe;
using System.Data.Sql;
using System.Globalization;

namespace Login_Cnumeral
{
    public partial class Proveedores : Form
    {
        List<string> culturelist = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;
        public Proveedores()
        {
            InitializeComponent();
        }

        string tiene= "True";
        public int viene_de;
        int identity_fake;
        private void Proveedores_Load(object sender, EventArgs e)
        {
            actual();
            foreach (CultureInfo culture in cultures)
            {
                
                region = new RegionInfo(culture.LCID);
                if (!(culturelist.Contains(region.EnglishName)))
                {
                    culturelist.Add(region.EnglishName);
                    Cmb_Pais.Items.Add(region.DisplayName );
                }
            }
            Cmb_Pais.Sorted = true;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (Txt_Proveedor.Text == "" || Txt_Direccion.Text == "" || Cmb_Pais.Text == "")
            {
                MessageBox.Show("TODOS los datos son necesarios. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {

                    string CMDD = string.Format("Insert into PROVEEDORES values ('{0}','{1}','{2}','{3}','{4}')", identity_fake, Txt_Proveedor.Text.Trim(), Txt_Direccion.Text, Cmb_Pais.Text, tiene);
                    DataSet DS = utilidades.Ejecutar(CMDD);

                    MessageBox.Show("Se Ingresaron los datos con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                actual();
                limpia();

            }     
        }
        public void identidades()
        {
            try
            {


                identity_fake = 1;
                SqlCeConnection conex = new SqlCeConnection("Data Source=|DataDirectory|\\ALMACEN.sdf");
                SqlCeCommand DC = new SqlCeCommand("select Codigo_Producto from PRODUCTOS", conex);
                conex.Open();

                SqlCeDataReader dr = DC.ExecuteReader();
                while (dr.Read() == true)
                {


                    identity_fake++;
                }

                conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha sucedido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void actual()
        {

            try
            {

                SqlCeConnection conex = new SqlCeConnection("Data Source=|DataDirectory|\\ALMACEN.sdf");
                conex.Open();

                DataTable DS;
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select * from PROVEEDORES", conex);
                DS = new DataTable();
                DP.Fill(DS);
                dataGridView1.DataSource = DS;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            identidades();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                tiene = "True";
                

            }
            else
            {
                tiene = "False";
               
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            
            
            
            try
            {

                string CMDD = string.Format("Delete from PROVEEDORES where Codigo_Proveedor ='{0}'", Lbl_Codigo_Proveedores.Text.Trim());
                DataSet DS = utilidades.Ejecutar(CMDD);

                MessageBox.Show("Se Eliminaron los datos con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actual();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCeConnection conex = new SqlCeConnection("Data Source=|DataDirectory|\\ALMACEN.sdf");
                conex.Open();

                DataTable DS;
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select * from PROVEEDORES where Proveedor = '" + Txt_Proveedor.Text + "'", conex);
                DS = new DataTable();
                DP.Fill(DS);
                dataGridView1.DataSource = DS;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        public void limpia()
        {
            Txt_Proveedor.Text = "";

            Txt_Direccion.Text = "";
            Lbl_Codigo_Proveedores.Text = "-";
            Cmb_Pais.Text = "";
            checkBox1.Checked = true;
            Txt_Proveedor.Focus();
        }
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
             try
            {
                string code;
                code = dataGridView1.CurrentRow.Cells["Codigo_Proveedor"].Value.ToString();

                string CMDD = string.Format("Update PROVEEDOR set  nombre_proveedor = '{0}', direccion = '{1}', Pais_procedencia ='{2}', Sucursal_rd='{3}' where Codigo_Proveedor = '"+ code +"'",Txt_Proveedor.Text.Trim(),  Txt_Direccion.Text,  Cmb_Pais.Text, tiene);
                DataSet DS = utilidades.Ejecutar(CMDD);

                MessageBox.Show("Se Actualizaron los datos con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actual();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                string  proveedor, code, dire, pais;


                code = dataGridView1.CurrentRow.Cells["Codigo_Proveedor"].Value.ToString();
                dire = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                pais = dataGridView1.CurrentRow.Cells["Pais_procedencia"].Value.ToString();
                tiene = dataGridView1.CurrentRow.Cells["Sucursal_rd"].Value.ToString();
                proveedor = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();


                Cmb_Pais.Text = pais;
                Txt_Direccion.Text = dire;
                Txt_Proveedor.Text = proveedor;
                Lbl_Codigo_Proveedores.Text = code;

                if (tiene == "True")
                {
                    checkBox1.Checked = true;
                    


                }
                else
                {
                    checkBox1.Checked = false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Truncatear_Click(object sender, EventArgs e)
        {
            object pregu = MessageBox.Show("Se eliminaran TODOS los datos de la tabla \n¿Está seguro de que desea continuar?", "Eliminar todos los datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (pregu.Equals(System.Windows.Forms.DialogResult.Yes))
            {

                try
                {

                    string CMDD = string.Format("Delete from  PROVEEDORES");
                    DataSet DS = utilidades.Ejecutar(CMDD);

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actual();
                limpia();

            }
        }

        private void Proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (viene_de.Equals(1))
            {
                FormAdmin fora = new FormAdmin();
                this.Hide();
                fora.Show();
            }
            else if (viene_de.Equals(2))
            {
                FormStandar fors = new FormStandar();
                this.Hide();
                fors.Show();
            }

        }

        private void Btn_Informe_Click(object sender, EventArgs e)
        {
            Imprimir2 i2 = new Imprimir2();
            i2.Show();
            i2.Focus();
        }

        private void Proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Cmb_Pais_KeyPress(object sender, KeyPressEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.RevisaLetras(sender, e);
        
        }

        private void Txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        
        }
        
        
   
    
}
