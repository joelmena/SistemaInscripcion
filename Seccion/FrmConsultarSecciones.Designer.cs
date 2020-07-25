namespace SistemaInscripcion.Seccion
{
    partial class FrmConsultarSecciones
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dgSeccion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(673, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbTotal.Location = new System.Drawing.Point(718, 391);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 19);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgSeccion
            // 
            this.dgSeccion.AllowUserToAddRows = false;
            this.dgSeccion.AllowUserToDeleteRows = false;
            this.dgSeccion.AllowUserToResizeColumns = false;
            this.dgSeccion.AllowUserToResizeRows = false;
            this.dgSeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colAula,
            this.colProfesor,
            this.colCapacidad,
            this.colDia1,
            this.colHoraInicio1,
            this.colHoraFin1,
            this.colObservaciones});
            this.dgSeccion.Location = new System.Drawing.Point(12, 112);
            this.dgSeccion.MultiSelect = false;
            this.dgSeccion.Name = "dgSeccion";
            this.dgSeccion.ReadOnly = true;
            this.dgSeccion.RowHeadersVisible = false;
            this.dgSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSeccion.Size = new System.Drawing.Size(776, 276);
            this.dgSeccion.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEliminar.Image = global::SistemaInscripcion.Properties.Resources.delete32;
            this.btnEliminar.Location = new System.Drawing.Point(669, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 40);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEditar.Image = global::SistemaInscripcion.Properties.Resources.edit322;
            this.btnEditar.Location = new System.Drawing.Point(562, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnNuevo.Image = global::SistemaInscripcion.Properties.Resources.addDoc32;
            this.btnNuevo.Location = new System.Drawing.Point(455, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 40);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::SistemaInscripcion.Properties.Resources.lupa32;
            this.btnFiltrar.Location = new System.Drawing.Point(273, 22);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(101, 40);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtFiltro.Location = new System.Drawing.Point(63, 31);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(204, 21);
            this.txtFiltro.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "Seccion";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 71;
            // 
            // colAula
            // 
            this.colAula.DataPropertyName = "Aula";
            this.colAula.HeaderText = "Aula";
            this.colAula.Name = "colAula";
            this.colAula.ReadOnly = true;
            this.colAula.Width = 53;
            // 
            // colProfesor
            // 
            this.colProfesor.DataPropertyName = "Profesor";
            this.colProfesor.HeaderText = "Profesor";
            this.colProfesor.Name = "colProfesor";
            this.colProfesor.ReadOnly = true;
            this.colProfesor.Width = 71;
            // 
            // colCapacidad
            // 
            this.colCapacidad.DataPropertyName = "Capacidad";
            this.colCapacidad.HeaderText = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.ReadOnly = true;
            this.colCapacidad.Width = 83;
            // 
            // colDia1
            // 
            this.colDia1.DataPropertyName = "Dia1";
            this.colDia1.HeaderText = "Dia 1";
            this.colDia1.Name = "colDia1";
            this.colDia1.ReadOnly = true;
            this.colDia1.Width = 57;
            // 
            // colHoraInicio1
            // 
            this.colHoraInicio1.DataPropertyName = "HoraInicio1";
            this.colHoraInicio1.HeaderText = "Hora Inicio";
            this.colHoraInicio1.Name = "colHoraInicio1";
            this.colHoraInicio1.ReadOnly = true;
            this.colHoraInicio1.Width = 83;
            // 
            // colHoraFin1
            // 
            this.colHoraFin1.DataPropertyName = "HoraFin1";
            this.colHoraFin1.HeaderText = "Hora Finalizacion";
            this.colHoraFin1.Name = "colHoraFin1";
            this.colHoraFin1.ReadOnly = true;
            this.colHoraFin1.Width = 104;
            // 
            // colObservaciones
            // 
            this.colObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObservaciones.DataPropertyName = "Observaciones";
            this.colObservaciones.HeaderText = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.ReadOnly = true;
            // 
            // FrmConsultarSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dgSeccion);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarSecciones";
            this.Text = "FrmConsultarSecciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgSeccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dgSeccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
    }
}