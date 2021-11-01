namespace WindowsFormsApp1
{
    partial class Materias
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNoMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNomDMateria = new System.Windows.Forms.TextBox();
            this.DgvMaterias = new System.Windows.Forms.DataGridView();
            this.BtnAltas = new System.Windows.Forms.Button();
            this.BtnBajas = new System.Windows.Forms.Button();
            this.BtnCambios = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSTITUTO TECNOLOGICO DE NUEVO LEON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(332, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catalogo de Materias";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(119, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. Materia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtNoMateria
            // 
            this.TxtNoMateria.Location = new System.Drawing.Point(286, 88);
            this.TxtNoMateria.Name = "TxtNoMateria";
            this.TxtNoMateria.Size = new System.Drawing.Size(100, 20);
            this.TxtNoMateria.TabIndex = 4;
            this.TxtNoMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNoMateria_KeyPress);
            this.TxtNoMateria.Leave += new System.EventHandler(this.TxtNoMateria_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(119, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre de la Materia";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtNomDMateria
            // 
            this.TxtNomDMateria.Location = new System.Drawing.Point(286, 127);
            this.TxtNomDMateria.Name = "TxtNomDMateria";
            this.TxtNomDMateria.Size = new System.Drawing.Size(270, 20);
            this.TxtNomDMateria.TabIndex = 6;
            this.TxtNomDMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomDMateria_KeyPress);
            // 
            // DgvMaterias
            // 
            this.DgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaterias.Location = new System.Drawing.Point(122, 162);
            this.DgvMaterias.Name = "DgvMaterias";
            this.DgvMaterias.Size = new System.Drawing.Size(602, 150);
            this.DgvMaterias.TabIndex = 7;
            this.DgvMaterias.DoubleClick += new System.EventHandler(this.DgvMaterias_DoubleClick);
            // 
            // BtnAltas
            // 
            this.BtnAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAltas.Location = new System.Drawing.Point(358, 343);
            this.BtnAltas.Name = "BtnAltas";
            this.BtnAltas.Size = new System.Drawing.Size(75, 23);
            this.BtnAltas.TabIndex = 8;
            this.BtnAltas.Text = "Altas";
            this.BtnAltas.UseVisualStyleBackColor = true;
            this.BtnAltas.Click += new System.EventHandler(this.BtnAltas_Click);
            this.BtnAltas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnAltas_KeyPress);
            // 
            // BtnBajas
            // 
            this.BtnBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBajas.Location = new System.Drawing.Point(439, 343);
            this.BtnBajas.Name = "BtnBajas";
            this.BtnBajas.Size = new System.Drawing.Size(75, 23);
            this.BtnBajas.TabIndex = 9;
            this.BtnBajas.Text = "Bajas";
            this.BtnBajas.UseVisualStyleBackColor = true;
            this.BtnBajas.Click += new System.EventHandler(this.BtnBajas_Click);
            this.BtnBajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnBajas_KeyPress);
            // 
            // BtnCambios
            // 
            this.BtnCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambios.Location = new System.Drawing.Point(520, 343);
            this.BtnCambios.Name = "BtnCambios";
            this.BtnCambios.Size = new System.Drawing.Size(85, 23);
            this.BtnCambios.TabIndex = 10;
            this.BtnCambios.Text = "Cambios";
            this.BtnCambios.UseVisualStyleBackColor = true;
            this.BtnCambios.Click += new System.EventHandler(this.BtnCambios_Click);
            this.BtnCambios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnCambios_KeyPress);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(612, 343);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnSalir_KeyPress);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCambios);
            this.Controls.Add(this.BtnBajas);
            this.Controls.Add(this.BtnAltas);
            this.Controls.Add(this.DgvMaterias);
            this.Controls.Add(this.TxtNomDMateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNoMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "17480003_OscarEduardo_Esparza_Lozano";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNoMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNomDMateria;
        private System.Windows.Forms.DataGridView DgvMaterias;
        private System.Windows.Forms.Button BtnAltas;
        private System.Windows.Forms.Button BtnBajas;
        private System.Windows.Forms.Button BtnCambios;
        private System.Windows.Forms.Button BtnSalir;
    }
}