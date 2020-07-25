namespace SistemaInscripcion.Asignatura
{
    partial class FrmConsultaAsignatura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgAsignaturas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(63, 30);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(241, 21);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::SistemaInscripcion.Properties.Resources.delete32;
            this.btnEliminar.Location = new System.Drawing.Point(670, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 40);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SistemaInscripcion.Properties.Resources.edit322;
            this.btnEditar.Location = new System.Drawing.Point(564, 20);
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
            this.btnNuevo.Image = global::SistemaInscripcion.Properties.Resources.addDoc32;
            this.btnNuevo.Location = new System.Drawing.Point(458, 20);
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
            this.btnFiltrar.Location = new System.Drawing.Point(310, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(101, 40);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgAsignaturas
            // 
            this.dgAsignaturas.AllowUserToAddRows = false;
            this.dgAsignaturas.AllowUserToDeleteRows = false;
            this.dgAsignaturas.AllowUserToResizeColumns = false;
            this.dgAsignaturas.AllowUserToResizeRows = false;
            this.dgAsignaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCodigo,
            this.colNombre,
            this.colCreditos,
            this.colCarrera,
            this.colObservaciones});
            this.dgAsignaturas.Location = new System.Drawing.Point(12, 100);
            this.dgAsignaturas.MultiSelect = false;
            this.dgAsignaturas.Name = "dgAsignaturas";
            this.dgAsignaturas.ReadOnly = true;
            this.dgAsignaturas.RowHeadersVisible = false;
            this.dgAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsignaturas.Size = new System.Drawing.Size(776, 250);
            this.dgAsignaturas.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 24;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 65;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Descripcion";
            this.colNombre.HeaderText = "Nombre Asignatura";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 112;
            // 
            // colCreditos
            // 
            this.colCreditos.DataPropertyName = "Creditos";
            this.colCreditos.HeaderText = "Creditos";
            this.colCreditos.Name = "colCreditos";
            this.colCreditos.ReadOnly = true;
            this.colCreditos.Width = 70;
            // 
            // colCarrera
            // 
            this.colCarrera.DataPropertyName = "Carrera";
            this.colCarrera.HeaderText = "Carrera";
            this.colCarrera.Name = "colCarrera";
            this.colCarrera.ReadOnly = true;
            this.colCarrera.Width = 66;
            // 
            // colObservaciones
            // 
            this.colObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObservaciones.DataPropertyName = "Observaciones";
            this.colObservaciones.HeaderText = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(673, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbTotal.Location = new System.Drawing.Point(718, 353);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 19);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConsultaAsignatura
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAsignaturas);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(816, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 417);
            this.Name = "FrmConsultaAsignatura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmConsultaAsignatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgAsignaturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
    }
}