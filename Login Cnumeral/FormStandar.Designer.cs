namespace Login_Cnumeral
{
    partial class FormStandar{
    
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStandar));
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioDeSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirProductoActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Cantidates = new System.Windows.Forms.TextBox();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Entrada = new System.Windows.Forms.Label();
            this.Txt_Fecha_Entrega = new System.Windows.Forms.DateTimePicker();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Txt_Proveedor = new System.Windows.Forms.ComboBox();
            this.Btn_mas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.White;
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Ingresar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Ingresar.Location = new System.Drawing.Point(36, 210);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(231, 36);
            this.Btn_Ingresar.TabIndex = 7;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(928, 244);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.White;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Location = new System.Drawing.Point(338, 210);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(231, 36);
            this.Btn_buscar.TabIndex = 9;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioDeSesiónToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioDeSesiónToolStripMenuItem
            // 
            this.inicioDeSesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioDeSesiónToolStripMenuItem.Name = "inicioDeSesiónToolStripMenuItem";
            this.inicioDeSesiónToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.inicioDeSesiónToolStripMenuItem.Text = "Inicio de Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = global::Login_Cnumeral.Properties.Resources._041_close;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem1,
            this.imprimirProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Image = global::Login_Cnumeral.Properties.Resources.acerca;
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // imprimirProveedoresToolStripMenuItem
            // 
            this.imprimirProveedoresToolStripMenuItem.Image = global::Login_Cnumeral.Properties.Resources.Print__2_;
            this.imprimirProveedoresToolStripMenuItem.Name = "imprimirProveedoresToolStripMenuItem";
            this.imprimirProveedoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.imprimirProveedoresToolStripMenuItem.Text = "Imprimir proveedores";
            this.imprimirProveedoresToolStripMenuItem.Click += new System.EventHandler(this.imprimirProveedoresToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirProductoActualToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // imprimirProductoActualToolStripMenuItem
            // 
            this.imprimirProductoActualToolStripMenuItem.Image = global::Login_Cnumeral.Properties.Resources.Print__2_;
            this.imprimirProductoActualToolStripMenuItem.Name = "imprimirProductoActualToolStripMenuItem";
            this.imprimirProductoActualToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.imprimirProductoActualToolStripMenuItem.Text = "Imprimir Producto Actual";
            this.imprimirProductoActualToolStripMenuItem.Click += new System.EventHandler(this.imprimirProductoActualToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.nominaToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Image = global::Login_Cnumeral.Properties.Resources.Empleados__1_;
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.datosPersonalesToolStripMenuItem.Text = "Datos personales";
            this.datosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem_Click);
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.Image = global::Login_Cnumeral.Properties.Resources.Empleados__1_;
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nominaToolStripMenuItem.Text = "Nomina";
            this.nominaToolStripMenuItem.Click += new System.EventHandler(this.nominaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cantidades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(644, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha de entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(644, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Proveedor";
            // 
            // Txt_Nombre_Producto
            // 
            this.Txt_Nombre_Producto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre_Producto.Location = new System.Drawing.Point(35, 100);
            this.Txt_Nombre_Producto.Name = "Txt_Nombre_Producto";
            this.Txt_Nombre_Producto.Size = new System.Drawing.Size(240, 26);
            this.Txt_Nombre_Producto.TabIndex = 1;
            this.Txt_Nombre_Producto.TextChanged += new System.EventHandler(this.Txt_Nombre_Producto_TextChanged);
            this.Txt_Nombre_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Producto_KeyPress);
            // 
            // Txt_Cantidates
            // 
            this.Txt_Cantidates.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidates.Location = new System.Drawing.Point(337, 100);
            this.Txt_Cantidates.Name = "Txt_Cantidates";
            this.Txt_Cantidates.Size = new System.Drawing.Size(240, 26);
            this.Txt_Cantidates.TabIndex = 3;
            this.Txt_Cantidates.TextChanged += new System.EventHandler(this.Txt_Cantidates_TextChanged);
            this.Txt_Cantidates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidates_KeyPress);
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Precio.Location = new System.Drawing.Point(337, 160);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(240, 26);
            this.Txt_Precio.TabIndex = 4;
            this.Txt_Precio.TextChanged += new System.EventHandler(this.Txt_Precio_TextChanged);
            this.Txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidates_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Categoria";
            // 
            // Cmb_Categoria
            // 
            this.Cmb_Categoria.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Categoria.FormattingEnabled = true;
            this.Cmb_Categoria.Items.AddRange(new object[] {
            "Electronicos",
            "Comestibles",
            "Higienicos",
            "Mobiliario",
            "Juguetes"});
            this.Cmb_Categoria.Location = new System.Drawing.Point(35, 160);
            this.Cmb_Categoria.Name = "Cmb_Categoria";
            this.Cmb_Categoria.Size = new System.Drawing.Size(240, 27);
            this.Cmb_Categoria.TabIndex = 2;
            this.Cmb_Categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Producto_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Codigo de Entrada";
            // 
            // Lbl_Codigo_Entrada
            // 
            this.Lbl_Codigo_Entrada.AutoSize = true;
            this.Lbl_Codigo_Entrada.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo_Entrada.ForeColor = System.Drawing.Color.White;
            this.Lbl_Codigo_Entrada.Location = new System.Drawing.Point(181, 44);
            this.Lbl_Codigo_Entrada.Name = "Lbl_Codigo_Entrada";
            this.Lbl_Codigo_Entrada.Size = new System.Drawing.Size(14, 19);
            this.Lbl_Codigo_Entrada.TabIndex = 47;
            this.Lbl_Codigo_Entrada.Text = "-";
            this.Lbl_Codigo_Entrada.TextChanged += new System.EventHandler(this.Lbl_Codigo_Entrada_TextChanged);
            // 
            // Txt_Fecha_Entrega
            // 
            this.Txt_Fecha_Entrega.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fecha_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txt_Fecha_Entrega.Location = new System.Drawing.Point(647, 100);
            this.Txt_Fecha_Entrega.Name = "Txt_Fecha_Entrega";
            this.Txt_Fecha_Entrega.Size = new System.Drawing.Size(240, 26);
            this.Txt_Fecha_Entrega.TabIndex = 5;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_limpiar.ForeColor = System.Drawing.Color.Black;
            this.Btn_limpiar.Location = new System.Drawing.Point(652, 210);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(231, 36);
            this.Btn_limpiar.TabIndex = 11;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = false;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proveedor.FormattingEnabled = true;
            this.Txt_Proveedor.Location = new System.Drawing.Point(648, 159);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(189, 27);
            this.Txt_Proveedor.TabIndex = 6;
            this.Txt_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Producto_KeyPress);
            // 
            // Btn_mas
            // 
            this.Btn_mas.BackColor = System.Drawing.Color.White;
            this.Btn_mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mas.ForeColor = System.Drawing.Color.Black;
            this.Btn_mas.Location = new System.Drawing.Point(843, 154);
            this.Btn_mas.Name = "Btn_mas";
            this.Btn_mas.Size = new System.Drawing.Size(40, 36);
            this.Btn_mas.TabIndex = 13;
            this.Btn_mas.Text = "+";
            this.Btn_mas.UseVisualStyleBackColor = false;
            this.Btn_mas.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // FormStandar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(923, 498);
            this.Controls.Add(this.Btn_mas);
            this.Controls.Add(this.Txt_Proveedor);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Txt_Fecha_Entrega);
            this.Controls.Add(this.Lbl_Codigo_Entrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cmb_Categoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.Txt_Cantidates);
            this.Controls.Add(this.Txt_Nombre_Producto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormStandar";
            this.Opacity = 0.95D;
            this.Text = "Standar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Move += new System.EventHandler(this.FormAdmin_Move);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioDeSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Nombre_Producto;
        private System.Windows.Forms.TextBox Txt_Cantidates;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_Categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_Codigo_Entrada;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Entrega;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button Btn_mas;
        public System.Windows.Forms.ComboBox Txt_Proveedor;
        private System.Windows.Forms.ToolStripMenuItem imprimirProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirProductoActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}