using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Login_Cnumeral
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre_Producto.Text == "" || Txt_Cantidates.Text == "" || Txt_Precio.Text == ""  || Txt_Fecha_Entrega.Text == "" || Txt_Proveedor.Text == "" || Cmb_Categoria.Text == "")
            {
                MessageBox.Show("TODOS los datos son necesarios. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {

                string CMDD = string.Format("Insert into PRODUCTOS(Nombre_Producto, categoria, Cantidates, Precio, Fecha_Entrada, Proveedor) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Txt_Nombre_Producto.Text.Trim(),  Cmb_Categoria.Text.Trim(), Txt_Cantidates.Text.Trim(), Txt_Precio.Text.Trim(), Txt_Fecha_Entrega.Value.ToString(), Txt_Proveedor.Text.Trim());
            DataSet DS = utilidades.Ejecutar(CMDD);

            MessageBox.Show("Se Ingresaron los datos con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            actual();

        }
        public void actual() 
        {

            try
            {

                SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=ALMACEN;Integrated Security=True");
                conex.Open();

                DataTable DS;
                SqlDataAdapter DP = new SqlDataAdapter("select * from PRODUCTOS", conex);
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

        private void Form2_Load(object sender, EventArgs e)
        {
            actual();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string CMDD = string.Format("Delete from PRODUCTOS where Codigo_Producto ='{0}'", Lbl_Codigo_Entrada.Text.Trim());
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


                string nombree, categoria, cantidades, precio, fecha, proveedor, code;


                code = dataGridView1.CurrentRow.Cells["Codigo_Producto"].Value.ToString();
                nombree = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                categoria = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                cantidades = dataGridView1.CurrentRow.Cells["Cantidades"].Value.ToString();
                precio = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                fecha = dataGridView1.CurrentRow.Cells["Fecha_Entrega"].Value.ToString();
                proveedor = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();


                Txt_Nombre_Producto.Text = nombree;
                Cmb_Categoria.Text = categoria;
                Txt_Cantidates.Text = cantidades;
                Txt_Precio.Text = precio;
                Txt_Fecha_Entrega.Text = fecha;
                Txt_Proveedor.Text = proveedor;
                Lbl_Codigo_Entrada.Text = code;
            
             

            }
            catch (Exception ex)
            {

            }

          
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            object salir = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir.Equals(System.Windows.Forms.DialogResult.Yes))
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=ALMACEN;Integrated Security=True");
                conex.Open();

                DataTable DS;
                SqlDataAdapter DP = new SqlDataAdapter("select * from PRODUCTOS where nombre_producto = '"+ Txt_Nombre_Producto.Text+"'", conex);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
             try
            {
                string code;
                code = dataGridView1.CurrentRow.Cells["Codigo_Producto"].Value.ToString();

                string CMDD = string.Format("Update PRODUCTOS set  nombre_producto = '{0}', categoria = '{1}', cantidades ='{2}', precio='{3}', fecha_entrada= '{4}', proveedor ='{5}' where Codigo_producto = '"+ code +"'", Txt_Nombre_Producto.Text.Trim(),  Cmb_Categoria.Text.Trim(), Txt_Cantidates.Text.Trim(), Txt_Precio.Text.Trim(), Txt_Fecha_Entrega.Text.Trim(), Txt_Proveedor.Text.Trim());
                DataSet DS = utilidades.Ejecutar(CMDD);

                MessageBox.Show("Se Actualizaron los datos con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actual();
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Registro res = new Registro();
            res.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acerca = new Acercade();
            acerca.Show();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir imp = new Imprimir();
            imp.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fo1 = new Form1();
            this.Hide();
            fo1.Show();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_Nombre_Producto.Clear();
            Cmb_Categoria.Text = "";
            Txt_Cantidates.Clear();
            Txt_Precio.Clear();
            Txt_Fecha_Entrega.BringToFront();
            Txt_Proveedor.Text = "";
            Lbl_Codigo_Entrada.Text = "";
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores proo = new Proveedores();

            proo.Show();
        }

        private void Btn_Truncatear_Click(object sender, EventArgs e)
        {
            object pregu = MessageBox.Show("Se eliminaran TODOS los datos de la tabla \n¿Está seguro de que desea continuar?", "Eliminar todos los datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (pregu.Equals(System.Windows.Forms.DialogResult.Yes))
            {

                try
                {

                    string CMDD = string.Format("Truncate table PRODUCTOS");
                    DataSet DS = utilidades.Ejecutar(CMDD);

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actual();

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object salir = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir.Equals(System.Windows.Forms.DialogResult.Yes))
            {
                Application.Exit();
            }

        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        
        
   
    }
}
