namespace WindowsFormsApp1
{
    partial class Alumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optUnionLibre = new System.Windows.Forms.RadioButton();
            this.optDivorciado = new System.Windows.Forms.RadioButton();
            this.optCasado = new System.Windows.Forms.RadioButton();
            this.optSoltero = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.CobCarreras = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cobmaterias = new System.Windows.Forms.ComboBox();
            this.btnAltas = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambios = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instituto Tecnologico de Nuevo Leon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catalogo de Alumnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Control";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Location = new System.Drawing.Point(192, 106);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(124, 20);
            this.txtNoControl.TabIndex = 3;
            this.txtNoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoControl_KeyPress);
            this.txtNoControl.Leave += new System.EventHandler(this.txtNoControl_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(192, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido Paterno";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(192, 172);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(271, 20);
            this.txtApePaterno.TabIndex = 7;
            this.txtApePaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApePaterno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellido Materno";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(192, 205);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(271, 20);
            this.txtApeMaterno.TabIndex = 9;
            this.txtApeMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeMaterno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(194, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optUnionLibre);
            this.groupBox1.Controls.Add(this.optDivorciado);
            this.groupBox1.Controls.Add(this.optCasado);
            this.groupBox1.Controls.Add(this.optSoltero);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // optUnionLibre
            // 
            this.optUnionLibre.AutoSize = true;
            this.optUnionLibre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optUnionLibre.Location = new System.Drawing.Point(288, 31);
            this.optUnionLibre.Name = "optUnionLibre";
            this.optUnionLibre.Size = new System.Drawing.Size(88, 20);
            this.optUnionLibre.TabIndex = 3;
            this.optUnionLibre.TabStop = true;
            this.optUnionLibre.Text = "Union Libre";
            this.optUnionLibre.UseVisualStyleBackColor = true;
            this.optUnionLibre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optUnionLibre_KeyPress);
            // 
            // optDivorciado
            // 
            this.optDivorciado.AutoSize = true;
            this.optDivorciado.Location = new System.Drawing.Point(184, 31);
            this.optDivorciado.Name = "optDivorciado";
            this.optDivorciado.Size = new System.Drawing.Size(83, 20);
            this.optDivorciado.TabIndex = 2;
            this.optDivorciado.TabStop = true;
            this.optDivorciado.Text = "Divorciado";
            this.optDivorciado.UseVisualStyleBackColor = true;
            this.optDivorciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optDivorciado_KeyPress);
            // 
            // optCasado
            // 
            this.optCasado.AutoSize = true;
            this.optCasado.Location = new System.Drawing.Point(102, 31);
            this.optCasado.Name = "optCasado";
            this.optCasado.Size = new System.Drawing.Size(66, 20);
            this.optCasado.TabIndex = 1;
            this.optCasado.TabStop = true;
            this.optCasado.Text = "Casado";
            this.optCasado.UseVisualStyleBackColor = true;
            this.optCasado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optCasado_KeyPress);
            // 
            // optSoltero
            // 
            this.optSoltero.AutoSize = true;
            this.optSoltero.Location = new System.Drawing.Point(12, 31);
            this.optSoltero.Name = "optSoltero";
            this.optSoltero.Size = new System.Drawing.Size(65, 20);
            this.optSoltero.TabIndex = 0;
            this.optSoltero.TabStop = true;
            this.optSoltero.Text = "Soltero";
            this.optSoltero.UseVisualStyleBackColor = true;
            this.optSoltero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optSoltero_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optFemenino);
            this.groupBox2.Controls.Add(this.optMasculino);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(90, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 75);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clave de Sexo";
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Location = new System.Drawing.Point(104, 33);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(78, 20);
            this.optFemenino.TabIndex = 1;
            this.optFemenino.TabStop = true;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            this.optFemenino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optFemenino_KeyPress);
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(12, 33);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(80, 20);
            this.optMasculino.TabIndex = 0;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            this.optMasculino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optMasculino_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Carreras";
            // 
            // CobCarreras
            // 
            this.CobCarreras.FormattingEnabled = true;
            this.CobCarreras.Location = new System.Drawing.Point(145, 450);
            this.CobCarreras.Name = "CobCarreras";
            this.CobCarreras.Size = new System.Drawing.Size(171, 21);
            this.CobCarreras.TabIndex = 15;
            this.CobCarreras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CobCarreras_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Materias";
            // 
            // Cobmaterias
            // 
            this.Cobmaterias.FormattingEnabled = true;
            this.Cobmaterias.Location = new System.Drawing.Point(378, 449);
            this.Cobmaterias.Name = "Cobmaterias";
            this.Cobmaterias.Size = new System.Drawing.Size(171, 21);
            this.Cobmaterias.TabIndex = 17;
            this.Cobmaterias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cobmaterias_KeyPress);
            // 
            // btnAltas
            // 
            this.btnAltas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.Location = new System.Drawing.Point(197, 492);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(75, 23);
            this.btnAltas.TabIndex = 18;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            this.btnAltas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAltas_KeyPress);
            // 
            // btnBajas
            // 
            this.btnBajas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajas.Location = new System.Drawing.Point(282, 492);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(75, 23);
            this.btnBajas.TabIndex = 19;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            this.btnBajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnBajas_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(474, 492);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSalir_KeyPress);
            // 
            // btnCambios
            // 
            this.btnCambios.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.Location = new System.Drawing.Point(378, 492);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(75, 23);
            this.btnCambios.TabIndex = 21;
            this.btnCambios.Text = "Cambios";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            this.btnCambios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCambios_KeyPress);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(90, 521);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(459, 150);
            this.dgvAlumnos.TabIndex = 22;
            this.dgvAlumnos.DoubleClick += new System.EventHandler(this.dgvAlumnos_DoubleClick);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 697);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.Cobmaterias);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CobCarreras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos 17480003 OSCAR EDUARDO ESPARZA LOZANO";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optUnionLibre;
        private System.Windows.Forms.RadioButton optDivorciado;
        private System.Windows.Forms.RadioButton optCasado;
        private System.Windows.Forms.RadioButton optSoltero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CobCarreras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cobmaterias;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}