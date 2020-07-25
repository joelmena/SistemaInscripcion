namespace SistemaInscripcion.Inscripcion
{
    partial class FrmConsultaInscripciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgInscripciones = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxEstudiantes = new System.Windows.Forms.ListBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnInscribir);
            this.groupBox1.Controls.Add(this.dgInscripciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbxEstudiantes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(255, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inscripciones";
            // 
            // dgInscripciones
            // 
            this.dgInscripciones.AllowUserToAddRows = false;
            this.dgInscripciones.AllowUserToDeleteRows = false;
            this.dgInscripciones.AllowUserToResizeColumns = false;
            this.dgInscripciones.AllowUserToResizeRows = false;
            this.dgInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colSeccion,
            this.colAula,
            this.colAsignatura,
            this.colDia1,
            this.colHoraInicio1,
            this.colHoraFin1,
            this.colDia2,
            this.colHoraInicio2,
            this.colHoraFin2});
            this.dgInscripciones.Location = new System.Drawing.Point(255, 34);
            this.dgInscripciones.Name = "dgInscripciones";
            this.dgInscripciones.RowHeadersVisible = false;
            this.dgInscripciones.Size = new System.Drawing.Size(709, 379);
            this.dgInscripciones.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            this.colID.Width = 24;
            // 
            // colSeccion
            // 
            this.colSeccion.DataPropertyName = "Seccion";
            this.colSeccion.HeaderText = "Seccion";
            this.colSeccion.Name = "colSeccion";
            this.colSeccion.Width = 71;
            // 
            // colAula
            // 
            this.colAula.DataPropertyName = "Aula";
            this.colAula.HeaderText = "Aula";
            this.colAula.Name = "colAula";
            this.colAula.Width = 53;
            // 
            // colAsignatura
            // 
            this.colAsignatura.DataPropertyName = "Asignatura";
            this.colAsignatura.HeaderText = "Asignatura";
            this.colAsignatura.Name = "colAsignatura";
            this.colAsignatura.Width = 82;
            // 
            // colDia1
            // 
            this.colDia1.DataPropertyName = "Dia1";
            this.colDia1.HeaderText = "Dia1";
            this.colDia1.Name = "colDia1";
            this.colDia1.Width = 54;
            // 
            // colHoraInicio1
            // 
            this.colHoraInicio1.DataPropertyName = "HoraInicio1";
            this.colHoraInicio1.HeaderText = "HoraInicio1";
            this.colHoraInicio1.Name = "colHoraInicio1";
            this.colHoraInicio1.Width = 86;
            // 
            // colHoraFin1
            // 
            this.colHoraFin1.DataPropertyName = "HoraFin1";
            this.colHoraFin1.HeaderText = "HoraFin1";
            this.colHoraFin1.Name = "colHoraFin1";
            this.colHoraFin1.Width = 75;
            // 
            // colDia2
            // 
            this.colDia2.HeaderText = "Dia2";
            this.colDia2.Name = "colDia2";
            this.colDia2.Width = 54;
            // 
            // colHoraInicio2
            // 
            this.colHoraInicio2.DataPropertyName = "HoraInicio2";
            this.colHoraInicio2.HeaderText = "HoraInicio2";
            this.colHoraInicio2.Name = "colHoraInicio2";
            this.colHoraInicio2.Width = 86;
            // 
            // colHoraFin2
            // 
            this.colHoraFin2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoraFin2.DataPropertyName = "HoraFin2";
            this.colHoraFin2.HeaderText = "HoraFin2";
            this.colHoraFin2.Name = "colHoraFin2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estudiantes";
            // 
            // lbxEstudiantes
            // 
            this.lbxEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbxEstudiantes.FormattingEnabled = true;
            this.lbxEstudiantes.ItemHeight = 15;
            this.lbxEstudiantes.Location = new System.Drawing.Point(9, 34);
            this.lbxEstudiantes.Name = "lbxEstudiantes";
            this.lbxEstudiantes.Size = new System.Drawing.Size(240, 334);
            this.lbxEstudiantes.TabIndex = 0;
            this.lbxEstudiantes.Click += new System.EventHandler(this.lbxEstudiantes_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnInscribir.Image = global::SistemaInscripcion.Properties.Resources.register32;
            this.btnInscribir.Location = new System.Drawing.Point(148, 373);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(101, 40);
            this.btnInscribir.TabIndex = 4;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // FrmConsultaInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1010, 489);
            this.Name = "FrmConsultaInscripciones";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Consultar Incripciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInscripciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxEstudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInscripciones;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin2;
    }
}