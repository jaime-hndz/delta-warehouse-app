namespace Login_Cnumeral
{
    partial class FormNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNomina));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_sueldo_Bruto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sueldo_extra = new System.Windows.Forms.TextBox();
            this.txt_prestaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Id_Empleado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Truncatear = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Txt_Puesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Informe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 350);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Txt_sueldo_Bruto
            // 
            this.Txt_sueldo_Bruto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sueldo_Bruto.Location = new System.Drawing.Point(435, 70);
            this.Txt_sueldo_Bruto.Name = "Txt_sueldo_Bruto";
            this.Txt_sueldo_Bruto.Size = new System.Drawing.Size(221, 26);
            this.Txt_sueldo_Bruto.TabIndex = 4;
            this.Txt_sueldo_Bruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_sueldo_Bruto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 89;
            this.label3.Text = "Sueldo Bruto";
            // 
            // txt_sueldo_extra
            // 
            this.txt_sueldo_extra.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sueldo_extra.Location = new System.Drawing.Point(465, 104);
            this.txt_sueldo_extra.Name = "txt_sueldo_extra";
            this.txt_sueldo_extra.Size = new System.Drawing.Size(165, 26);
            this.txt_sueldo_extra.TabIndex = 6;
            this.txt_sueldo_extra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_sueldo_Bruto_KeyPress);
            // 
            // txt_prestaciones
            // 
            this.txt_prestaciones.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prestaciones.Location = new System.Drawing.Point(126, 101);
            this.txt_prestaciones.Name = "txt_prestaciones";
            this.txt_prestaciones.Size = new System.Drawing.Size(151, 26);
            this.txt_prestaciones.TabIndex = 5;
            this.txt_prestaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_sueldo_Bruto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "Sueldo por horas extras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 86;
            this.label6.Text = "Prestaciones";
            // 
            // Lbl_Id_Empleado
            // 
            this.Lbl_Id_Empleado.AutoSize = true;
            this.Lbl_Id_Empleado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Empleado.Location = new System.Drawing.Point(130, 12);
            this.Lbl_Id_Empleado.Name = "Lbl_Id_Empleado";
            this.Lbl_Id_Empleado.Size = new System.Drawing.Size(14, 19);
            this.Lbl_Id_Empleado.TabIndex = 83;
            this.Lbl_Id_Empleado.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 82;
            this.label9.Text = "ID Empleado";
            // 
            // Btn_Truncatear
            // 
            this.Btn_Truncatear.BackColor = System.Drawing.Color.White;
            this.Btn_Truncatear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Truncatear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Truncatear.ForeColor = System.Drawing.Color.Black;
            this.Btn_Truncatear.Location = new System.Drawing.Point(492, 142);
            this.Btn_Truncatear.Name = "Btn_Truncatear";
            this.Btn_Truncatear.Size = new System.Drawing.Size(109, 36);
            this.Btn_Truncatear.TabIndex = 12;
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
            this.Btn_limpiar.Location = new System.Drawing.Point(396, 142);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(93, 36);
            this.Btn_limpiar.TabIndex = 11;
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
            this.Btn_Actualizar.Location = new System.Drawing.Point(300, 142);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(93, 36);
            this.Btn_Actualizar.TabIndex = 10;
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
            this.Btn_buscar.Location = new System.Drawing.Point(204, 142);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(93, 36);
            this.Btn_buscar.TabIndex = 9;
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(108, 142);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(93, 36);
            this.Btn_Eliminar.TabIndex = 8;
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
            this.Btn_Ingresar.Location = new System.Drawing.Point(12, 142);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(93, 36);
            this.Btn_Ingresar.TabIndex = 7;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Txt_Puesto
            // 
            this.Txt_Puesto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Puesto.Location = new System.Drawing.Point(391, 38);
            this.Txt_Puesto.Name = "Txt_Puesto";
            this.Txt_Puesto.Size = new System.Drawing.Size(221, 26);
            this.Txt_Puesto.TabIndex = 3;
            this.Txt_Puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(329, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 75;
            this.label4.Text = "Puesto";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(96, 70);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(224, 26);
            this.Txt_Apellido.TabIndex = 2;
            this.Txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(96, 38);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(224, 26);
            this.Txt_Nombre.TabIndex = 1;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nombre";
            // 
            // btn_Informe
            // 
            this.btn_Informe.BackColor = System.Drawing.Color.White;
            this.btn_Informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Informe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Informe.ForeColor = System.Drawing.Color.Black;
            this.btn_Informe.Location = new System.Drawing.Point(604, 142);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Size = new System.Drawing.Size(95, 36);
            this.btn_Informe.TabIndex = 13;
            this.btn_Informe.Text = "Informe";
            this.btn_Informe.UseVisualStyleBackColor = false;
            this.btn_Informe.Click += new System.EventHandler(this.btn_Informe_Click);
            // 
            // FormNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(721, 551);
            this.Controls.Add(this.btn_Informe);
            this.Controls.Add(this.Txt_sueldo_Bruto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sueldo_extra);
            this.Controls.Add(this.txt_prestaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbl_Id_Empleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btn_Truncatear);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.Txt_Puesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNomina";
            this.Text = "Nomina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_sueldo_Bruto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sueldo_extra;
        private System.Windows.Forms.TextBox txt_prestaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_Id_Empleado;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button Btn_Truncatear;
        public System.Windows.Forms.Button Btn_limpiar;
        public System.Windows.Forms.Button Btn_Actualizar;
        public System.Windows.Forms.Button Btn_buscar;
        public System.Windows.Forms.Button Btn_Eliminar;
        public System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.TextBox Txt_Puesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Informe;
    }
}