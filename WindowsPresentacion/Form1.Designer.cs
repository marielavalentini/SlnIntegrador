namespace WindowsPresentacion
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
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.GridMedicos = new System.Windows.Forms.DataGridView();
            this.listMedicos = new System.Windows.Forms.ListBox();
            this.GridPacientes = new System.Windows.Forms.DataGridView();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnMedicosClinicos = new System.Windows.Forms.Button();
            this.lstClinicos = new System.Windows.Forms.ListBox();
            this.btnClinicos = new System.Windows.Forms.Button();
            this.btnMostrarHabitaciones = new System.Windows.Forms.Button();
            this.lstMostrarListaHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(108, 27);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(974, 23);
            this.btnMostrarMedicos.TabIndex = 0;
            this.btnMostrarMedicos.Text = "Mostrar Medicos y pacientes";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // GridMedicos
            // 
            this.GridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMedicos.Location = new System.Drawing.Point(48, 80);
            this.GridMedicos.Name = "GridMedicos";
            this.GridMedicos.RowHeadersWidth = 51;
            this.GridMedicos.RowTemplate.Height = 24;
            this.GridMedicos.Size = new System.Drawing.Size(435, 193);
            this.GridMedicos.TabIndex = 1;
            // 
            // listMedicos
            // 
            this.listMedicos.FormattingEnabled = true;
            this.listMedicos.ItemHeight = 16;
            this.listMedicos.Location = new System.Drawing.Point(489, 80);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(114, 132);
            this.listMedicos.TabIndex = 2;
            // 
            // GridPacientes
            // 
            this.GridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPacientes.Location = new System.Drawing.Point(670, 77);
            this.GridPacientes.Name = "GridPacientes";
            this.GridPacientes.RowHeadersWidth = 51;
            this.GridPacientes.RowTemplate.Height = 24;
            this.GridPacientes.Size = new System.Drawing.Size(361, 200);
            this.GridPacientes.TabIndex = 3;
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 16;
            this.lstPacientes.Location = new System.Drawing.Point(1050, 77);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(116, 196);
            this.lstPacientes.TabIndex = 4;
            // 
            // btnMedicosClinicos
            // 
            this.btnMedicosClinicos.Location = new System.Drawing.Point(0, 0);
            this.btnMedicosClinicos.Name = "btnMedicosClinicos";
            this.btnMedicosClinicos.Size = new System.Drawing.Size(75, 23);
            this.btnMedicosClinicos.TabIndex = 8;
            // 
            // lstClinicos
            // 
            this.lstClinicos.FormattingEnabled = true;
            this.lstClinicos.ItemHeight = 16;
            this.lstClinicos.Location = new System.Drawing.Point(73, 367);
            this.lstClinicos.Name = "lstClinicos";
            this.lstClinicos.Size = new System.Drawing.Size(519, 84);
            this.lstClinicos.TabIndex = 7;
            // 
            // btnClinicos
            // 
            this.btnClinicos.Location = new System.Drawing.Point(73, 325);
            this.btnClinicos.Name = "btnClinicos";
            this.btnClinicos.Size = new System.Drawing.Size(519, 23);
            this.btnClinicos.TabIndex = 9;
            this.btnClinicos.Text = "Mostrar medicos clinicos";
            this.btnClinicos.UseVisualStyleBackColor = true;
            this.btnClinicos.Click += new System.EventHandler(this.btnClinicos_Click);
            // 
            // btnMostrarHabitaciones
            // 
            this.btnMostrarHabitaciones.Location = new System.Drawing.Point(626, 325);
            this.btnMostrarHabitaciones.Name = "btnMostrarHabitaciones";
            this.btnMostrarHabitaciones.Size = new System.Drawing.Size(543, 23);
            this.btnMostrarHabitaciones.TabIndex = 10;
            this.btnMostrarHabitaciones.Text = "Mostrar lista de habitaciones";
            this.btnMostrarHabitaciones.UseVisualStyleBackColor = true;
            this.btnMostrarHabitaciones.Click += new System.EventHandler(this.btnMostrarHabitaciones_Click);
            // 
            // lstMostrarListaHabitaciones
            // 
            this.lstMostrarListaHabitaciones.FormattingEnabled = true;
            this.lstMostrarListaHabitaciones.ItemHeight = 16;
            this.lstMostrarListaHabitaciones.Location = new System.Drawing.Point(639, 367);
            this.lstMostrarListaHabitaciones.Name = "lstMostrarListaHabitaciones";
            this.lstMostrarListaHabitaciones.Size = new System.Drawing.Size(530, 84);
            this.lstMostrarListaHabitaciones.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 558);
            this.Controls.Add(this.lstMostrarListaHabitaciones);
            this.Controls.Add(this.btnMostrarHabitaciones);
            this.Controls.Add(this.btnClinicos);
            this.Controls.Add(this.lstClinicos);
            this.Controls.Add(this.btnMedicosClinicos);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.GridPacientes);
            this.Controls.Add(this.listMedicos);
            this.Controls.Add(this.GridMedicos);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.DataGridView GridMedicos;
        private System.Windows.Forms.ListBox listMedicos;
        private System.Windows.Forms.DataGridView GridPacientes;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btnMedicosClinicos;
        private System.Windows.Forms.ListBox lstClinicos;
        private System.Windows.Forms.Button btnClinicos;
        private System.Windows.Forms.Button btnMostrarHabitaciones;
        private System.Windows.Forms.ListBox lstMostrarListaHabitaciones;
    }
}

