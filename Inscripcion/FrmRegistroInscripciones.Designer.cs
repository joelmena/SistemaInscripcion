namespace SistemaInscripcion.Inscripcion
{
    partial class FrmRegistroInscripciones
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
            this.dgSeccion = new System.Windows.Forms.DataGridView();
            this.colSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.colSeccion,
            this.colAsignatura,
            this.colCreditos,
            this.colCarrera,
            this.colAula,
            this.colDia1,
            this.colHoraInicio1,
            this.colHoraFin1,
            this.colDia2,
            this.colHoraInicio2,
            this.colHoraFin2,
            this.colProfesor});
            this.dgSeccion.Location = new System.Drawing.Point(12, 176);
            this.dgSeccion.MultiSelect = false;
            this.dgSeccion.Name = "dgSeccion";
            this.dgSeccion.ReadOnly = true;
            this.dgSeccion.RowHeadersVisible = false;
            this.dgSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSeccion.Size = new System.Drawing.Size(878, 229);
            this.dgSeccion.TabIndex = 12;
            // 
            // colSeccion
            // 
            this.colSeccion.DataPropertyName = "Seccion";
            this.colSeccion.HeaderText = "Seccion";
            this.colSeccion.Name = "colSeccion";
            this.colSeccion.ReadOnly = true;
            this.colSeccion.Width = 71;
            // 
            // colAsignatura
            // 
            this.colAsignatura.DataPropertyName = "Asignatura";
            this.colAsignatura.HeaderText = "Asignatura";
            this.colAsignatura.Name = "colAsignatura";
            this.colAsignatura.ReadOnly = true;
            this.colAsignatura.Width = 82;
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
            // colAula
            // 
            this.colAula.DataPropertyName = "Aula";
            this.colAula.HeaderText = "Aula";
            this.colAula.Name = "colAula";
            this.colAula.ReadOnly = true;
            this.colAula.Width = 53;
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
            this.colHoraInicio1.HeaderText = "Hora Inicio1";
            this.colHoraInicio1.Name = "colHoraInicio1";
            this.colHoraInicio1.ReadOnly = true;
            this.colHoraInicio1.Width = 89;
            // 
            // colHoraFin1
            // 
            this.colHoraFin1.DataPropertyName = "HoraFin1";
            this.colHoraFin1.HeaderText = "Hora Fin 1";
            this.colHoraFin1.Name = "colHoraFin1";
            this.colHoraFin1.ReadOnly = true;
            this.colHoraFin1.Width = 81;
            // 
            // colDia2
            // 
            this.colDia2.DataPropertyName = "Dia2";
            this.colDia2.HeaderText = "Dia 2";
            this.colDia2.Name = "colDia2";
            this.colDia2.ReadOnly = true;
            this.colDia2.Width = 57;
            // 
            // colHoraInicio2
            // 
            this.colHoraInicio2.DataPropertyName = "HoraInicio2";
            this.colHoraInicio2.HeaderText = "Hora Inicio 2";
            this.colHoraInicio2.Name = "colHoraInicio2";
            this.colHoraInicio2.ReadOnly = true;
            this.colHoraInicio2.Width = 92;
            // 
            // colHoraFin2
            // 
            this.colHoraFin2.DataPropertyName = "HoraFin2";
            this.colHoraFin2.HeaderText = "Hora Fin 2";
            this.colHoraFin2.Name = "colHoraFin2";
            this.colHoraFin2.ReadOnly = true;
            this.colHoraFin2.Width = 81;
            // 
            // colProfesor
            // 
            this.colProfesor.DataPropertyName = "Profesor";
            this.colProfesor.HeaderText = "Profesor";
            this.colProfesor.Name = "colProfesor";
            this.colProfesor.ReadOnly = true;
            this.colProfesor.Width = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnInscribir);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSexo);
            this.groupBox2.Controls.Add(this.lbApellidos);
            this.groupBox2.Controls.Add(this.lbCategoria);
            this.groupBox2.Controls.Add(this.lbNombres);
            this.groupBox2.Controls.Add(this.lbMatricula);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 75);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // lbSexo
            // 
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbSexo.Location = new System.Drawing.Point(608, 40);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(70, 19);
            this.lbSexo.TabIndex = 9;
            // 
            // lbApellidos
            // 
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbApellidos.Location = new System.Drawing.Point(380, 40);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(70, 19);
            this.lbApellidos.TabIndex = 8;
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbCategoria.Location = new System.Drawing.Point(745, 40);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(70, 19);
            this.lbCategoria.TabIndex = 7;
            // 
            // lbNombres
            // 
            this.lbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbNombres.Location = new System.Drawing.Point(85, 40);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(70, 19);
            this.lbNombres.TabIndex = 6;
            // 
            // lbMatricula
            // 
            this.lbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbMatricula.ForeColor = System.Drawing.Color.Red;
            this.lbMatricula.Location = new System.Drawing.Point(85, 16);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(70, 19);
            this.lbMatricula.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(666, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(559, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(304, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matricula:";
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
            // 
            // btnInscribir
            // 
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnInscribir.Image = global::SistemaInscripcion.Properties.Resources.register32;
            this.btnInscribir.Location = new System.Drawing.Point(455, 22);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(101, 40);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
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
            // 
            // FrmRegistroInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgSeccion);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(918, 456);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(918, 456);
            this.Name = "FrmRegistroInscripciones";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Registrar Inscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgSeccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgSeccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfesor;
    }
}