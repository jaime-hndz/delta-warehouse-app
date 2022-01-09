using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient; using System.Data.SqlServerCe;

namespace Login_Cnumeral
{
    public partial class FormNomina : Form
    {
        public FormNomina()
        {
            InitializeComponent();
        }
        public int viene_de;
        int identity_fake;
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {

            if ( Txt_Nombre.Text == "" || Txt_Apellido.Text == "" || Txt_Puesto.Text == "" || txt_prestaciones.Text == "" || txt_sueldo_extra.Text == "" || Txt_sueldo_Bruto.Text == "")
            {
                MessageBox.Show("TODOS los datos son necesarios. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                 try
                 {
   
                    string CMDD = string.Format("Insert into Nomina  values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",identity_fake, Txt_Nombre.Text.Trim(), Txt_Apellido.Text.Trim(), Txt_Puesto.Text.Trim(), Txt_sueldo_Bruto.Text, txt_prestaciones.Text, txt_sueldo_extra.Text);
                    DataSet DS = utilidades.Ejecutar(CMDD);

                    MessageBox.Show("Se Ingresaron los datos con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actual();
                    limpia();
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

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
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select ID_Empleado, Nombre, Apellido, puesto, Sueldo_Bruto, Prestaciones, Sueldo_Horas_Extras, ((Sueldo_Bruto+Sueldo_Horas_Extras)-Prestaciones) as Sueldo_Neto from Nomina  ", conex);
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

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            actual();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                string nombree, ape, puesto, bruto, pres, extra, code;


                code = dataGridView1.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                nombree = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                ape = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                puesto = dataGridView1.CurrentRow.Cells["Puesto"].Value.ToString();
                bruto = dataGridView1.CurrentRow.Cells["Sueldo_Bruto"].Value.ToString();
                pres = dataGridView1.CurrentRow.Cells["Prestaciones"].Value.ToString();
                extra = dataGridView1.CurrentRow.Cells["Sueldo_Horas_Extras"].Value.ToString();
                
                Txt_Nombre.Text = nombree;
                Txt_Apellido.Text = ape;
                Lbl_Id_Empleado.Text = code;
                Txt_Puesto.Text = puesto;
                Txt_sueldo_Bruto.Text = bruto;
                txt_prestaciones.Text = pres;
                txt_sueldo_extra.Text = extra;

             


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            
            try
            {

                string CMDD = string.Format("Delete from Nomina where ID_Empleado ='{0}'", Lbl_Id_Empleado.Text.Trim());
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
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select ID_Empleado, Nombre, Apellido, puesto, Sueldo_Bruto, Prestaciones, Sueldo_Horas_Extras, ((Sueldo_Bruto+Sueldo_Horas_Extras)-Prestaciones) as Sueldo_Neto from Nomina where Nombre = '" + Txt_Nombre.Text + "'", conex);
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

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string code;
                code = dataGridView1.CurrentRow.Cells["ID_Empleado"].Value.ToString();

                string CMDD = string.Format("Update Nomina set  nombre = '{0}', apellido='{1}', puesto = '{2}', Sueldo_Bruto = '{3}', Prestaciones = '{4}', Sueldo_horas_extras = '{5}' where ID_Empleado = '" + code + "'", Txt_Nombre.Text.Trim(), Txt_Apellido.Text.Trim(), Txt_Puesto.Text.Trim(), Txt_sueldo_Bruto.Text, txt_prestaciones.Text, txt_sueldo_extra.Text);
                DataSet DS = utilidades.Ejecutar(CMDD);

                MessageBox.Show("Se Actualizaron los datos con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actual();
        

        }
        private void limpia()
        {
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Puesto.Text = "";
            Txt_sueldo_Bruto.Text = "";
            txt_sueldo_extra.Text = "";
            txt_prestaciones.Text = "";
            Txt_Nombre.Focus();


        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void Btn_Truncatear_Click(object sender, EventArgs e)
        {
            object pregu = MessageBox.Show("Se eliminaran TODOS los datos de la tabla \n¿Está seguro de que desea continuar?", "Eliminar todos los datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (pregu.Equals(System.Windows.Forms.DialogResult.Yes))
            {

                try
                {

                    string CMDD = string.Format("Delete from  Nomina");
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

        private void FormEmpleados_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Informe_Click(object sender, EventArgs e)
        {
            Imprimir_Nomina imn = new Imprimir_Nomina();
            imn.Show();
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.RevisaLetras(sender, e);
        
        }

        private void Txt_sueldo_Bruto_KeyPress(object sender, KeyPressEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.RevisaNumeros(sender, e);
        
        }
    }
}
