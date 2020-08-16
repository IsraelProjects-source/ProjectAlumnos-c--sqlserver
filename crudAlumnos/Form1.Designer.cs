namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtMatern = new System.Windows.Forms.TextBox();
            this.txtPatern = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNoCon = new System.Windows.Forms.TextBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(25, 245);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(693, 161);
            this.dgvDatos.TabIndex = 25;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(52, 205);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(69, 20);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Materia";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(52, 167);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 20);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Carrera";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // TxtMatern
            // 
            this.TxtMatern.Location = new System.Drawing.Point(157, 131);
            this.TxtMatern.Name = "TxtMatern";
            this.TxtMatern.Size = new System.Drawing.Size(179, 20);
            this.TxtMatern.TabIndex = 22;
            this.TxtMatern.TextChanged += new System.EventHandler(this.TxtMatern_TextChanged);
            this.TxtMatern.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMatern_KeyPress);
            // 
            // txtPatern
            // 
            this.txtPatern.Location = new System.Drawing.Point(157, 98);
            this.txtPatern.Name = "txtPatern";
            this.txtPatern.Size = new System.Drawing.Size(179, 20);
            this.txtPatern.TabIndex = 21;
            this.txtPatern.TextChanged += new System.EventHandler(this.txtPatern_TextChanged);
            this.txtPatern.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatern_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(157, 66);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(179, 20);
            this.txtNom.TabIndex = 20;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtNoCon
            // 
            this.txtNoCon.Location = new System.Drawing.Point(157, 43);
            this.txtNoCon.Name = "txtNoCon";
            this.txtNoCon.Size = new System.Drawing.Size(133, 20);
            this.txtNoCon.TabIndex = 19;
            this.txtNoCon.TextChanged += new System.EventHandler(this.txtNoCon_TextChanged);
            this.txtNoCon.VisibleChanged += new System.EventHandler(this.l);
            this.txtNoCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoCon_KeyPress);
            this.txtNoCon.Leave += new System.EventHandler(this.txtNoCon_Leave);
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(157, 204);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(154, 21);
            this.cmbMateria.TabIndex = 18;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            this.cmbMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMateria_KeyPress);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(157, 166);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(154, 21);
            this.cmbCarrera.TabIndex = 17;
            this.cmbCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbCarrera_SelectedIndexChanged);
            this.cmbCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCarrera_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(52, 131);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 20);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "A. Materno";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(52, 98);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 20);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "A. Paterno";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(52, 69);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 20);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Nombre";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(52, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 20);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Id Control";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(475, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(597, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(475, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "Cambia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button3_KeyPress);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(597, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 32);
            this.button4.TabIndex = 29;
            this.button4.Text = "Lista";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button4_KeyPress);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(475, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 32);
            this.button5.TabIndex = 30;
            this.button5.Text = "Reporte";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button5_KeyPress);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(597, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 32);
            this.button6.TabIndex = 31;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button6_KeyPress);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Location = new System.Drawing.Point(475, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 32);
            this.button7.TabIndex = 32;
            this.button7.Text = "Carrera";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button7_KeyPress);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Location = new System.Drawing.Point(597, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 32);
            this.button8.TabIndex = 33;
            this.button8.Text = "Materia";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button8_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(328, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Alumnos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 418);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TxtMatern);
            this.Controls.Add(this.txtPatern);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNoCon);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvDatos;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtMatern;
        internal System.Windows.Forms.TextBox txtPatern;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.TextBox txtNoCon;
        internal System.Windows.Forms.ComboBox cmbMateria;
        internal System.Windows.Forms.ComboBox cmbCarrera;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
    }
}

