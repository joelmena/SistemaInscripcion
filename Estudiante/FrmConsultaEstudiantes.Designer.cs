namespace SistemaInscripcion.Estudiante
{
    partial class FrmConsultaEstudiantes
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
            this.dgEstudiantes = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonoCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonoMovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtFiltro.Location = new System.Drawing.Point(15, 41);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(248, 21);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.Tag = "";
            // 
            // dgEstudiantes
            // 
            this.dgEstudiantes.AllowUserToAddRows = false;
            this.dgEstudiantes.AllowUserToDeleteRows = false;
            this.dgEstudiantes.AllowUserToResizeColumns = false;
            this.dgEstudiantes.AllowUserToResizeRows = false;
            this.dgEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colMatricula,
            this.colNombre,
            this.colApellido,
            this.colCedula,
            this.colSexo,
            this.colFechaNacimiento,
            this.colEstadoCivil,
            this.colTelefonoCasa,
            this.colTelefonoMovil,
            this.colDireccion,
            this.colEmail,
            this.colCarrera,
            this.colCategoria,
            this.colRegistrado});
            this.dgEstudiantes.Location = new System.Drawing.Point(12, 102);
            this.dgEstudiantes.MultiSelect = false;
            this.dgEstudiantes.Name = "dgEstudiantes";
            this.dgEstudiantes.ReadOnly = true;
            this.dgEstudiantes.RowHeadersVisible = false;
            this.dgEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstudiantes.Size = new System.Drawing.Size(776, 310);
            this.dgEstudiantes.TabIndex = 6;
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
            // colMatricula
            // 
            this.colMatricula.DataPropertyName = "Matricula";
            this.colMatricula.HeaderText = "Matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.ReadOnly = true;
            this.colMatricula.Width = 75;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 69;
            // 
            // colApellido
            // 
            this.colApellido.DataPropertyName = "Apellido";
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Width = 69;
            // 
            // colCedula
            // 
            this.colCedula.DataPropertyName = "Cedula";
            this.colCedula.HeaderText = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            this.colCedula.Width = 65;
            // 
            // colSexo
            // 
            this.colSexo.DataPropertyName = "Sexo";
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Width = 56;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.colFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.ReadOnly = true;
            this.colFechaNacimiento.Width = 122;
            // 
            // colEstadoCivil
            // 
            this.colEstadoCivil.DataPropertyName = "EstadoCivil";
            this.colEstadoCivil.HeaderText = "Estado Civil";
            this.colEstadoCivil.Name = "colEstadoCivil";
            this.colEstadoCivil.ReadOnly = true;
            this.colEstadoCivil.Visible = false;
            this.colEstadoCivil.Width = 80;
            // 
            // colTelefonoCasa
            // 
            this.colTelefonoCasa.DataPropertyName = "TelefonoCasa";
            this.colTelefonoCasa.HeaderText = "Telefono Casa";
            this.colTelefonoCasa.Name = "colTelefonoCasa";
            this.colTelefonoCasa.ReadOnly = true;
            this.colTelefonoCasa.Visible = false;
            this.colTelefonoCasa.Width = 93;
            // 
            // colTelefonoMovil
            // 
            this.colTelefonoMovil.DataPropertyName = "TelefonoMovil";
            this.colTelefonoMovil.HeaderText = "Telefono Movil";
            this.colTelefonoMovil.Name = "colTelefonoMovil";
            this.colTelefonoMovil.ReadOnly = true;
            this.colTelefonoMovil.Visible = false;
            this.colTelefonoMovil.Width = 94;
            // 
            // colDireccion
            // 
            this.colDireccion.DataPropertyName = "Direccion";
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Visible = false;
            this.colDireccion.Width = 77;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            this.colEmail.Width = 60;
            // 
            // colCarrera
            // 
            this.colCarrera.DataPropertyName = "Carrera";
            this.colCarrera.HeaderText = "Carrera";
            this.colCarrera.Name = "colCarrera";
            this.colCarrera.ReadOnly = true;
            this.colCarrera.Width = 66;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "TipoEstudiante";
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 77;
            // 
            // colRegistrado
            // 
            this.colRegistrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRegistrado.DataPropertyName = "CreatedAt";
            this.colRegistrado.HeaderText = "Registrado";
            this.colRegistrado.Name = "colRegistrado";
            this.colRegistrado.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTotal.Location = new System.Drawing.Point(688, 418);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(643, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // btnFiltro
            // 
            this.btnFiltro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnFiltro.Image = global::SistemaInscripcion.Properties.Resources.lupa32;
            this.btnFiltro.Location = new System.Drawing.Point(279, 31);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(101, 40);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::SistemaInscripcion.Properties.Resources.print16;
            this.btnPrint.Location = new System.Drawing.Point(12, 421);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEliminar.Image = global::SistemaInscripcion.Properties.Resources.delete32;
            this.btnEliminar.Location = new System.Drawing.Point(669, 31);
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
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(562, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnNuevo.Image = global::SistemaInscripcion.Properties.Resources.add32;
            this.btnNuevo.Location = new System.Drawing.Point(455, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 40);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmConsultaEstudiantes
            // 
            this.AcceptButton = this.btnFiltro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgEstudiantes);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmConsultaEstudiantes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Consultar Estudiantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgEstudiantes;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoMovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegistrado;
        private System.Windows.Forms.Button btnPrint;
    }
}