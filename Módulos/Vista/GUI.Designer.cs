namespace DAO_Capas
{
    partial class Vista
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_Orden = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_Campo_ordenar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_Filtrar_ordenar = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBox_Busqueda_incremental = new System.Windows.Forms.TextBox();
            this.combo_Busqueda_incremental = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dGV_Busqueda = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Hasta_filtrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Desde_filtrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Campo_filtrar_vehiculos = new System.Windows.Forms.ComboBox();
            this.btn_Filtrar_vehiculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dGV_Vehiculos_cliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV_ABM_Personas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Baja_persona = new System.Windows.Forms.Button();
            this.btn_Alta_persona = new System.Windows.Forms.Button();
            this.btn_Modificar_persona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Baja_vehiculo = new System.Windows.Forms.Button();
            this.btn_Alta_vehiculo = new System.Windows.Forms.Button();
            this.btn_Modificar_vehiculo = new System.Windows.Forms.Button();
            this.dGV_ABM_Vehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Busqueda)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Vehiculos_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ABM_Personas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ABM_Vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Ordenar);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.combo_Orden);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.combo_Campo_ordenar);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.combo_Filtrar_ordenar);
            this.groupBox5.Location = new System.Drawing.Point(12, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(87, 182);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ordenar";
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.Location = new System.Drawing.Point(6, 145);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ordenar.TabIndex = 3;
            this.btn_Ordenar.Text = "Ordenar";
            this.btn_Ordenar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Orden";
            // 
            // combo_Orden
            // 
            this.combo_Orden.FormattingEnabled = true;
            this.combo_Orden.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.combo_Orden.Location = new System.Drawing.Point(6, 118);
            this.combo_Orden.Name = "combo_Orden";
            this.combo_Orden.Size = new System.Drawing.Size(75, 21);
            this.combo_Orden.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Campo";
            // 
            // combo_Campo_ordenar
            // 
            this.combo_Campo_ordenar.FormattingEnabled = true;
            this.combo_Campo_ordenar.Location = new System.Drawing.Point(6, 78);
            this.combo_Campo_ordenar.Name = "combo_Campo_ordenar";
            this.combo_Campo_ordenar.Size = new System.Drawing.Size(75, 21);
            this.combo_Campo_ordenar.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Filtrar";
            // 
            // combo_Filtrar_ordenar
            // 
            this.combo_Filtrar_ordenar.FormattingEnabled = true;
            this.combo_Filtrar_ordenar.Items.AddRange(new object[] {
            "Persona",
            "Vehiculo"});
            this.combo_Filtrar_ordenar.Location = new System.Drawing.Point(6, 36);
            this.combo_Filtrar_ordenar.Name = "combo_Filtrar_ordenar";
            this.combo_Filtrar_ordenar.Size = new System.Drawing.Size(75, 21);
            this.combo_Filtrar_ordenar.TabIndex = 14;
            this.combo_Filtrar_ordenar.TextChanged += new System.EventHandler(this.combo_Filtrar_ordenar_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtBox_Busqueda_incremental);
            this.groupBox4.Controls.Add(this.combo_Busqueda_incremental);
            this.groupBox4.Location = new System.Drawing.Point(599, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(87, 154);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda incremental de personas según";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Búsqueda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Campo";
            // 
            // txtBox_Busqueda_incremental
            // 
            this.txtBox_Busqueda_incremental.Location = new System.Drawing.Point(6, 122);
            this.txtBox_Busqueda_incremental.Name = "txtBox_Busqueda_incremental";
            this.txtBox_Busqueda_incremental.Size = new System.Drawing.Size(75, 20);
            this.txtBox_Busqueda_incremental.TabIndex = 12;
            this.txtBox_Busqueda_incremental.TextChanged += new System.EventHandler(this.txtBox_Busqueda_incremental_TextChanged);
            // 
            // combo_Busqueda_incremental
            // 
            this.combo_Busqueda_incremental.FormattingEnabled = true;
            this.combo_Busqueda_incremental.Location = new System.Drawing.Point(6, 80);
            this.combo_Busqueda_incremental.Name = "combo_Busqueda_incremental";
            this.combo_Busqueda_incremental.Size = new System.Drawing.Size(75, 21);
            this.combo_Busqueda_incremental.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Resultados de búsqueda";
            // 
            // dGV_Busqueda
            // 
            this.dGV_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Busqueda.Location = new System.Drawing.Point(352, 246);
            this.dGV_Busqueda.Name = "dGV_Busqueda";
            this.dGV_Busqueda.Size = new System.Drawing.Size(241, 212);
            this.dGV_Busqueda.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_Hasta_filtrar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_Desde_filtrar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.combo_Campo_filtrar_vehiculos);
            this.groupBox3.Controls.Add(this.btn_Filtrar_vehiculo);
            this.groupBox3.Location = new System.Drawing.Point(599, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 201);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar vehiculos según";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hasta";
            // 
            // txt_Hasta_filtrar
            // 
            this.txt_Hasta_filtrar.Location = new System.Drawing.Point(6, 145);
            this.txt_Hasta_filtrar.Name = "txt_Hasta_filtrar";
            this.txt_Hasta_filtrar.Size = new System.Drawing.Size(75, 20);
            this.txt_Hasta_filtrar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desde";
            // 
            // txt_Desde_filtrar
            // 
            this.txt_Desde_filtrar.Location = new System.Drawing.Point(6, 106);
            this.txt_Desde_filtrar.Name = "txt_Desde_filtrar";
            this.txt_Desde_filtrar.Size = new System.Drawing.Size(75, 20);
            this.txt_Desde_filtrar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Campo";
            // 
            // combo_Campo_filtrar_vehiculos
            // 
            this.combo_Campo_filtrar_vehiculos.FormattingEnabled = true;
            this.combo_Campo_filtrar_vehiculos.Location = new System.Drawing.Point(6, 64);
            this.combo_Campo_filtrar_vehiculos.Name = "combo_Campo_filtrar_vehiculos";
            this.combo_Campo_filtrar_vehiculos.Size = new System.Drawing.Size(75, 21);
            this.combo_Campo_filtrar_vehiculos.TabIndex = 4;
            // 
            // btn_Filtrar_vehiculo
            // 
            this.btn_Filtrar_vehiculo.Location = new System.Drawing.Point(6, 171);
            this.btn_Filtrar_vehiculo.Name = "btn_Filtrar_vehiculo";
            this.btn_Filtrar_vehiculo.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar_vehiculo.TabIndex = 3;
            this.btn_Filtrar_vehiculo.Text = "Filtrar";
            this.btn_Filtrar_vehiculo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(599, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vehículos de cliente seleccionado";
            // 
            // dGV_Vehiculos_cliente
            // 
            this.dGV_Vehiculos_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Vehiculos_cliente.Location = new System.Drawing.Point(105, 246);
            this.dGV_Vehiculos_cliente.Name = "dGV_Vehiculos_cliente";
            this.dGV_Vehiculos_cliente.Size = new System.Drawing.Size(241, 212);
            this.dGV_Vehiculos_cliente.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ABM de personas";
            // 
            // dGV_ABM_Personas
            // 
            this.dGV_ABM_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ABM_Personas.Location = new System.Drawing.Point(105, 28);
            this.dGV_ABM_Personas.Name = "dGV_ABM_Personas";
            this.dGV_ABM_Personas.Size = new System.Drawing.Size(241, 197);
            this.dGV_ABM_Personas.TabIndex = 20;
            this.dGV_ABM_Personas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ABM_Personas_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Baja_persona);
            this.groupBox2.Controls.Add(this.btn_Alta_persona);
            this.groupBox2.Controls.Add(this.btn_Modificar_persona);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 111);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persona";
            // 
            // btn_Baja_persona
            // 
            this.btn_Baja_persona.Location = new System.Drawing.Point(6, 77);
            this.btn_Baja_persona.Name = "btn_Baja_persona";
            this.btn_Baja_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja_persona.TabIndex = 2;
            this.btn_Baja_persona.Text = "Baja";
            this.btn_Baja_persona.UseVisualStyleBackColor = true;
            this.btn_Baja_persona.Click += new System.EventHandler(this.btn_Baja_persona_Click);
            // 
            // btn_Alta_persona
            // 
            this.btn_Alta_persona.Location = new System.Drawing.Point(6, 19);
            this.btn_Alta_persona.Name = "btn_Alta_persona";
            this.btn_Alta_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta_persona.TabIndex = 0;
            this.btn_Alta_persona.Text = "Alta";
            this.btn_Alta_persona.UseVisualStyleBackColor = true;
            this.btn_Alta_persona.Click += new System.EventHandler(this.btn_Alta_persona_Click);
            // 
            // btn_Modificar_persona
            // 
            this.btn_Modificar_persona.Location = new System.Drawing.Point(6, 48);
            this.btn_Modificar_persona.Name = "btn_Modificar_persona";
            this.btn_Modificar_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar_persona.TabIndex = 1;
            this.btn_Modificar_persona.Text = "Modificar";
            this.btn_Modificar_persona.UseVisualStyleBackColor = true;
            this.btn_Modificar_persona.Click += new System.EventHandler(this.btn_Modificar_persona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ABM de vehículos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Baja_vehiculo);
            this.groupBox1.Controls.Add(this.btn_Alta_vehiculo);
            this.groupBox1.Controls.Add(this.btn_Modificar_vehiculo);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehículo";
            // 
            // btn_Baja_vehiculo
            // 
            this.btn_Baja_vehiculo.Location = new System.Drawing.Point(6, 77);
            this.btn_Baja_vehiculo.Name = "btn_Baja_vehiculo";
            this.btn_Baja_vehiculo.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja_vehiculo.TabIndex = 2;
            this.btn_Baja_vehiculo.Text = "Baja";
            this.btn_Baja_vehiculo.UseVisualStyleBackColor = true;
            this.btn_Baja_vehiculo.Click += new System.EventHandler(this.btn_Baja_vehiculo_Click);
            // 
            // btn_Alta_vehiculo
            // 
            this.btn_Alta_vehiculo.Location = new System.Drawing.Point(6, 19);
            this.btn_Alta_vehiculo.Name = "btn_Alta_vehiculo";
            this.btn_Alta_vehiculo.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta_vehiculo.TabIndex = 0;
            this.btn_Alta_vehiculo.Text = "Alta";
            this.btn_Alta_vehiculo.UseVisualStyleBackColor = true;
            this.btn_Alta_vehiculo.Click += new System.EventHandler(this.btn_Alta_vehiculo_Click);
            // 
            // btn_Modificar_vehiculo
            // 
            this.btn_Modificar_vehiculo.Location = new System.Drawing.Point(6, 48);
            this.btn_Modificar_vehiculo.Name = "btn_Modificar_vehiculo";
            this.btn_Modificar_vehiculo.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar_vehiculo.TabIndex = 1;
            this.btn_Modificar_vehiculo.Text = "Modificar";
            this.btn_Modificar_vehiculo.UseVisualStyleBackColor = true;
            this.btn_Modificar_vehiculo.Click += new System.EventHandler(this.btn_Modificar_vehiculo_Click);
            // 
            // dGV_ABM_Vehiculos
            // 
            this.dGV_ABM_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ABM_Vehiculos.Location = new System.Drawing.Point(352, 28);
            this.dGV_ABM_Vehiculos.Name = "dGV_ABM_Vehiculos";
            this.dGV_ABM_Vehiculos.Size = new System.Drawing.Size(241, 197);
            this.dGV_ABM_Vehiculos.TabIndex = 13;
            this.dGV_ABM_Vehiculos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ABM_Vehiculos_RowEnter);
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 469);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dGV_Busqueda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dGV_Vehiculos_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGV_ABM_Personas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGV_ABM_Vehiculos);
            this.Name = "Vista";
            this.Text = "Garage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Busqueda)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Vehiculos_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ABM_Personas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ABM_Vehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combo_Orden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_Campo_ordenar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_Filtrar_ordenar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBox_Busqueda_incremental;
        private System.Windows.Forms.ComboBox combo_Busqueda_incremental;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dGV_Busqueda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Hasta_filtrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Desde_filtrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Campo_filtrar_vehiculos;
        private System.Windows.Forms.Button btn_Filtrar_vehiculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGV_Vehiculos_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGV_ABM_Personas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Baja_persona;
        private System.Windows.Forms.Button btn_Alta_persona;
        private System.Windows.Forms.Button btn_Modificar_persona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Baja_vehiculo;
        private System.Windows.Forms.Button btn_Alta_vehiculo;
        private System.Windows.Forms.Button btn_Modificar_vehiculo;
        private System.Windows.Forms.DataGridView dGV_ABM_Vehiculos;
    }
}

