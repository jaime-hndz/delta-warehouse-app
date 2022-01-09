namespace Login_Cnumeral
{
    partial class FormEmpleados
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.Txt_TelefonoPerso = new System.Windows.Forms.TextBox();
            this.Txt_TelefonoCasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Puesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Truncatear = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Lbl_Id_Empleado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbox_Edad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 288);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Cambria", 12F);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(499, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 23);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Tiene pareja";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cambria", 12F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(27, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 23);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Tiene hijos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cmb_Sexo
            // 
            this.Cmb_Sexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cmb_Sexo.FormattingEnabled = true;
            this.Cmb_Sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "-"});
            this.Cmb_Sexo.Location = new System.Drawing.Point(385, 72);
            this.Cmb_Sexo.Name = "Cmb_Sexo";
            this.Cmb_Sexo.Size = new System.Drawing.Size(114, 21);
            this.Cmb_Sexo.TabIndex = 4;
            this.Cmb_Sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellido_KeyPress);
            // 
            // Txt_TelefonoPerso
            // 
            this.Txt_TelefonoPerso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_TelefonoPerso.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TelefonoPerso.Location = new System.Drawing.Point(462, 142);
            this.Txt_TelefonoPerso.Name = "Txt_TelefonoPerso";
            this.Txt_TelefonoPerso.Size = new System.Drawing.Size(158, 26);
            this.Txt_TelefonoPerso.TabIndex = 8;
            this.Txt_TelefonoPerso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lbox_Edad_KeyPress);
            // 
            // Txt_TelefonoCasa
            // 
            this.Txt_TelefonoCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_TelefonoCasa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TelefonoCasa.Location = new System.Drawing.Point(162, 142);
            this.Txt_TelefonoCasa.Name = "Txt_TelefonoCasa";
            this.Txt_TelefonoCasa.Size = new System.Drawing.Size(158, 26);
            this.Txt_TelefonoCasa.TabIndex = 7;
            this.Txt_TelefonoCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lbox_Edad_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(326, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Telefono personal";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Telefono de Casa";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Direccion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Direccion.Location = new System.Drawing.Point(107, 104);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(513, 26);
            this.Txt_Direccion.TabIndex = 6;
            this.Txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellido_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(505, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Edad";
            // 
            // Txt_Puesto
            // 
            this.Txt_Puesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Puesto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Puesto.Location = new System.Drawing.Point(399, 35);
            this.Txt_Puesto.Name = "Txt_Puesto";
            this.Txt_Puesto.Size = new System.Drawing.Size(221, 26);
            this.Txt_Puesto.TabIndex = 3;
            this.Txt_Puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellido_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(337, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Puesto";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Apellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(107, 67);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(224, 26);
            this.Txt_Apellido.TabIndex = 2;
            this.Txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellido_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Nombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(107, 35);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(224, 26);
            this.Txt_Nombre.TabIndex = 1;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellido_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre";
            // 
            // Btn_Truncatear
            // 
            this.Btn_Truncatear.BackColor = System.Drawing.Color.White;
            this.Btn_Truncatear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Truncatear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Truncatear.ForeColor = System.Drawing.Color.Black;
            this.Btn_Truncatear.Location = new System.Drawing.Point(521, 205);
            this.Btn_Truncatear.Name = "Btn_Truncatear";
            this.Btn_Truncatear.Size = new System.Drawing.Size(133, 36);
            this.Btn_Truncatear.TabIndex = 61;
            this.Btn_Truncatear.Text = "Eliminar todo";
            this.Btn_Truncatear.UseVisualStyleBackColor = false;
            this.Btn_Truncatear.Click += new System.EventHandler(this.Btn_Truncatear_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.ForeColor = System.Drawing.Color.Black;
            this.Btn_limpiar.Location = new System.Drawing.Point(424, 205);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(93, 36);
            this.Btn_limpiar.TabIndex = 60;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = false;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.White;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Actualizar.Location = new System.Drawing.Point(327, 205);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(93, 36);
            this.Btn_Actualizar.TabIndex = 59;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.White;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Location = new System.Drawing.Point(230, 205);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(93, 36);
            this.Btn_buscar.TabIndex = 58;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.Location = new System.Drawing.Point(133, 205);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(93, 36);
            this.Btn_Eliminar.TabIndex = 57;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.White;
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Ingresar.Location = new System.Drawing.Point(36, 205);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(93, 36);
            this.Btn_Ingresar.TabIndex = 56;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Lbl_Id_Empleado
            // 
            this.Lbl_Id_Empleado.AutoSize = true;
            this.Lbl_Id_Empleado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Empleado.ForeColor = System.Drawing.Color.White;
            this.Lbl_Id_Empleado.Location = new System.Drawing.Point(139, 9);
            this.Lbl_Id_Empleado.Name = "Lbl_Id_Empleado";
            this.Lbl_Id_Empleado.Size = new System.Drawing.Size(14, 19);
            this.Lbl_Id_Empleado.TabIndex = 63;
            this.Lbl_Id_Empleado.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "ID Empleado";
            // 
            // Lbox_Edad
            // 
            this.Lbox_Edad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbox_Edad.FormattingEnabled = true;
            this.Lbox_Edad.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.Lbox_Edad.Location = new System.Drawing.Point(555, 70);
            this.Lbox_Edad.Name = "Lbox_Edad";
            this.Lbox_Edad.Size = new System.Drawing.Size(48, 21);
            this.Lbox_Edad.TabIndex = 5;
            this.Lbox_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lbox_Edad_KeyPress);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(696, 551);
            this.Controls.Add(this.Lbox_Edad);
            this.Controls.Add(this.Lbl_Id_Empleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btn_Truncatear);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Cmb_Sexo);
            this.Controls.Add(this.Txt_TelefonoPerso);
            this.Controls.Add(this.Txt_TelefonoCasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Direccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Puesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmpleados";
            this.Opacity = 0.95D;
            this.Text = "Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox Cmb_Sexo;
        private System.Windows.Forms.TextBox Txt_TelefonoPerso;
        private System.Windows.Forms.TextBox Txt_TelefonoCasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Puesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Id_Empleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Lbox_Edad;
        public System.Windows.Forms.Button Btn_Truncatear;
        public System.Windows.Forms.Button Btn_limpiar;
        public System.Windows.Forms.Button Btn_Actualizar;
        public System.Windows.Forms.Button Btn_buscar;
        public System.Windows.Forms.Button Btn_Eliminar;
        public System.Windows.Forms.Button Btn_Ingresar;
    }
}