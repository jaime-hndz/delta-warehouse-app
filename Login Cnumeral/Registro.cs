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

namespace Login_Cnumeral
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        public void actual()
        {

            try
            {

                SqlCeConnection conex = new SqlCeConnection("Data Source=|DataDirectory|\\ALMACEN.sdf");
                conex.Open();

                DataTable DS;
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select * from Usuarios", conex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Txt_Contraseña.Text == Txt_contraseña2.Text)
            {
                try
                {

                    string CMDD = string.Format("Insert into Usuarios values ('{0}','{1}','{2}' ,'{3}' ,'{4}')", Txt_Nombre.Text.Trim(), Txt_Apellido.Text.Trim(), Txt_NombreUsu.Text.Trim(), Txt_Contraseña.Text.Trim(), Cmb_Tipo.Text.Trim());
                    DataSet DS = utilidades.Ejecutar(CMDD);

                    MessageBox.Show("Se Ingresaron los datos con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no corresponden", "Error registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            actual();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            actual();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string CMDD = string.Format("Delete from Usuarios where Usuario ='{0}'", Txt_NombreUsu.Text.Trim());
                DataSet DS = utilidades.Ejecutar(CMDD);

                MessageBox.Show("Se Eliminaron los datos con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


            string nombree, apellido, usuario, tipo, contraseñaa;

            nombree = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            usuario = dataGridView1.CurrentRow.Cells["usuario"].Value.ToString();
            tipo = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
            contraseñaa = dataGridView1.CurrentRow.Cells["contraseña"].Value.ToString();

            Txt_Nombre.Text = nombree;
            Txt_Apellido.Text = apellido;
            Txt_NombreUsu.Text = usuario;
            Cmb_Tipo.Text = tipo;
            Txt_Contraseña.Text = contraseñaa;
            Txt_contraseña2.Text = contraseñaa;

              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          

        

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Nombre.Clear();
            Txt_Apellido.Clear();
            Txt_NombreUsu.Clear();
            Cmb_Tipo.Text = "Standar";
            Txt_Contraseña.Clear();
            Txt_contraseña2.Clear();

            Txt_Nombre.Focus();
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
