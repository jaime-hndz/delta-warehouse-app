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
using GUI_V_2;

namespace Login_Cnumeral
{
    public partial class FormStandar : Form
    {
        public FormStandar()
        {
            InitializeComponent();
        }

        public bool cerrao = true;
        int identity_fake;
        string time;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre_Producto.Text == "" || Txt_Cantidates.Text == "" || Txt_Precio.Text == "" || Txt_Fecha_Entrega.Text == "" || Txt_Proveedor.Text == "" || Cmb_Categoria.Text == "")
            {
                MessageBox.Show("TODOS los datos son necesarios. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    time = Txt_Fecha_Entrega.Value.ToString();

                    string CMDD = string.Format("Insert into PRODUCTOS  values ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')", Txt_Nombre_Producto.Text.Trim(), Cmb_Categoria.Text.Trim(), Txt_Cantidates.Text.Trim(), Txt_Precio.Text.Trim(), time, Txt_Proveedor.Text.Trim(), identity_fake);
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
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select * from PRODUCTOS", conex);
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
            actualprove();
            brrr();
        }
        public void actualprove()
        {
            try
            {


                Txt_Proveedor.Items.Clear();
                SqlCeConnection conex = new SqlCeConnection("Data Source=|DataDirectory|\\ALMACEN.sdf");
                SqlCeCommand DC = new SqlCeCommand("select proveedor from proveedores", conex);
                conex.Open();

                SqlCeDataReader dr = DC.ExecuteReader();
                while (dr.Read() == true)
                {


                    Txt_Proveedor.Items.Add(dr[0]);
                }

                conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha sucedido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                nombree = dataGridView1.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
                categoria = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                cantidades = dataGridView1.CurrentRow.Cells["Cantidades"].Value.ToString();
                precio = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                fecha = dataGridView1.CurrentRow.Cells["Fecha_Entrega"].Value.ToString();
                proveedor = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();


                Txt_Nombre_Producto.Text = nombree;
                Cmb_Categoria.Text = categoria;
                Txt_Cantidates.Text = cantidades;
                Txt_Precio.Text = precio;
                
                Txt_Proveedor.Text = proveedor;
                Lbl_Codigo_Entrada.Text = code;
            
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCeConnection conex = new SqlCeConnection("Data Source=|DataDirectory|\\ALMACEN.sdf");
                conex.Open();

                DataTable DS;
                SqlCeDataAdapter DP = new SqlCeDataAdapter("select * from PRODUCTOS where nombre_producto = '"+ Txt_Nombre_Producto.Text+"'", conex);
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

        private void limpia()
        {
            Txt_Nombre_Producto.Clear();
            Cmb_Categoria.Text = "";
            Txt_Cantidates.Clear();
            Txt_Precio.Clear();
            Txt_Fecha_Entrega.BringToFront();
            Txt_Proveedor.Text = "";
            Lbl_Codigo_Entrada.Text = "-";
            Txt_Nombre_Producto.Focus();
            brrr();

        }
        public void brrr()
        {
            if (Lbl_Codigo_Entrada.Text.Equals("-"))
            {
                imprimirProductoActualToolStripMenuItem.Enabled = false;

            }
            else
            {
                imprimirProductoActualToolStripMenuItem.Enabled = true;
            }
        }
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores proo = new Proveedores();
            proo.Btn_Eliminar.Enabled = false;
            proo.Btn_Actualizar.Enabled = false;
            proo.Btn_Truncatear.Enabled = false;
            proo.viene_de = 2;
            this.Hide();
            proo.Show();
        }

        private void Btn_Truncatear_Click(object sender, EventArgs e)
        {
            object pregu = MessageBox.Show("Se eliminaran TODOS los datos de la tabla \n¿Está seguro de que desea continuar?", "Eliminar todos los datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (pregu.Equals(System.Windows.Forms.DialogResult.Yes))
            {

                try
                {

                    string CMDD = string.Format("Delete from  PRODUCTOS");
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
            Application.Exit();
         
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FormAdmin_Move(object sender, EventArgs e)
        {

      

        }

        private void imprimirProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir2 i2 = new Imprimir2();
            i2.Show();
            i2.Focus();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados emp = new FormEmpleados();
            emp.Btn_Eliminar.Enabled = false;
            emp.Btn_Truncatear.Enabled = false;
            emp.Btn_Actualizar.Enabled = false;
            
            emp.Show();

        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNomina emp = new FormNomina();
            emp.Btn_Eliminar.Enabled = false;
            emp.Btn_Truncatear.Enabled = false;
            emp.Btn_Actualizar.Enabled = false;

            emp.Show();
        }

        private void Txt_Nombre_Producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.RevisaLetras(sender, e);
        
        }

        private void Txt_Cantidates_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cantidates_KeyPress(object sender, KeyPressEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.RevisaNumeros(sender, e);
        
        }

        private void imprimirProductoActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura fac = new Factura();

            Login_Cnumeral.Properties.Settings.Default.Cod = Convert.ToInt32(Lbl_Codigo_Entrada.Text);

            fac.Show();
        }

        private void Lbl_Codigo_Entrada_TextChanged(object sender, EventArgs e)
        {
            brrr();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ayuda aa = new Ayuda();
            aa.Show();
        }
   
    }
}
