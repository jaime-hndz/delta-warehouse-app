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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }
        string hijo = "False", pareja = "False", edad;
        public int viene_de;
        int identity_fake;
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {

            if ( Txt_Nombre.Text == "" || Txt_Apellido.Text == "" || Txt_Puesto.Text == "" || Cmb_Sexo.Text == "" || Txt_Direccion.Text == "" || Txt_TelefonoCasa.Text == "" || Txt_TelefonoPerso.Text == "" || Lbox_Edad.Text == "0")
            {
                MessageBox.Show("TODOS los datos son necesarios. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    edad = Lbox_Edad.Text;
                    string CMDD = string.Format("Insert into Empleados  values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}', '{9}', '{10}')", identity_fake, Txt_Nombre.Text.Trim(), Txt_Apellido.Text.Trim(), Txt_Puesto.Text.Trim(), Cmb_Sexo.Text.Trim(), edad, Txt_Direccion.Text, Txt_TelefonoCasa.Text, Txt_TelefonoPerso.Text, hijo, pareja);
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
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select * from Empleados", conex);
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


                string nombree, ape, puesto, sex, edad, direccion, telcasa, telperso, code;


                code = dataGridView1.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                nombree = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                ape = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                puesto = dataGridView1.CurrentRow.Cells["Puesto"].Value.ToString();
                sex = dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString();
                edad = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                direccion = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                telcasa = dataGridView1.CurrentRow.Cells["Telefono_Casa"].Value.ToString();
                telperso = dataGridView1.CurrentRow.Cells["Telefono_Personal"].Value.ToString();

                Txt_Nombre.Text = nombree;
                Txt_Apellido.Text = ape;
                Lbl_Id_Empleado.Text = code;
                Txt_Puesto.Text = puesto;
                Cmb_Sexo.Text = sex;
                Lbox_Edad.Text = edad;
                Txt_Direccion.Text = direccion;
                Txt_TelefonoCasa.Text = telcasa;
                Txt_TelefonoPerso.Text = telperso;


                if (hijo == "True")
                {
                    checkBox1.Checked = true;

                }
                else if (hijo == "False")
                {
                    checkBox1.Checked = false; 
                }

                if (pareja== "True")
                {
                    checkBox2.Checked = true;

                }
                else if (pareja == "False")
                {
                    checkBox2.Checked = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                hijo = "True";


            }
            else
            {
               hijo = "False";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                pareja = "True";


            }
            else
            {
                pareja = "False";

            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            
            try
            {

                string CMDD = string.Format("Delete from Empleados where ID_Empleado ='{0}'", Lbl_Id_Empleado.Text.Trim());
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
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select * from Empleados where Nombre = '" + Txt_Nombre.Text + "'", conex);
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

                string CMDD = string.Format("Update Empleados set  nombre = '{0}', apellido='{1}', puesto = '{2}', sexo = '{3}', edad = '{4}', direccion = '{5}', Telefono_Casa ='{6}', Telefono_Personal='{7}', Tiene_Hijos = '{8}', Tiene_Pareja = '{9}' where ID_Empleado = '"+ code +"'", Txt_Nombre.Text.Trim(), Txt_Apellido.Text.Trim(), Txt_Puesto.Text.Trim(), Cmb_Sexo.Text.Trim(), edad, Txt_Direccion.Text, Txt_TelefonoCasa.Text, Txt_TelefonoPerso.Text, hijo, pareja);
                DataSet DS = utilidades.Ejecutar(CMDD);

                MessageBox.Show("Se Actualizaron los datos con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actual();
        

        }
        public void limpia()
        {
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Puesto.Text = "";
            Cmb_Sexo.Text = "";
            Lbox_Edad.Text = "";
            Txt_Direccion.Text = "";
            Txt_TelefonoCasa.Text = "";
            Txt_TelefonoPerso.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
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

                    string CMDD = string.Format("Delete from  Empleados");
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

        private void Txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.RevisaLetras(sender, e);
        
        }

        private void Lbox_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.RevisaNumeros(sender, e);
        
        }
    }
}
