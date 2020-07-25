namespace SistemaInscripcion.Caja
{
    partial class FrmCaja
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
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lbMontoDevuelto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgInscripciones = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.colIdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnFiltro.Image = global::SistemaInscripcion.Properties.Resources.lupa32;
            this.btnFiltro.Location = new System.Drawing.Point(327, 21);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(101, 40);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtFiltro.Location = new System.Drawing.Point(63, 30);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(258, 21);
            this.txtFiltro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto recibido";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMonto.Location = new System.Drawing.Point(115, 62);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(147, 21);
            this.txtMonto.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCobrar);
            this.groupBox2.Controls.Add(this.lbMontoDevuelto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbBalance);
            this.groupBox2.Controls.Add(this.lbNombre);
            this.groupBox2.Controls.Add(this.lbMatricula);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCobrar.Location = new System.Drawing.Point(583, 52);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(101, 40);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lbMontoDevuelto
            // 
            this.lbMontoDevuelto.BackColor = System.Drawing.SystemColors.Info;
            this.lbMontoDevuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbMontoDevuelto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbMontoDevuelto.Location = new System.Drawing.Point(341, 65);
            this.lbMontoDevuelto.Name = "lbMontoDevuelto";
            this.lbMontoDevuelto.Size = new System.Drawing.Size(134, 21);
            this.lbMontoDevuelto.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(268, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Devuelto:";
            // 
            // lbBalance
            // 
            this.lbBalance.BackColor = System.Drawing.SystemColors.Info;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbBalance.ForeColor = System.Drawing.Color.Lime;
            this.lbBalance.Location = new System.Drawing.Point(586, 16);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(89, 21);
            this.lbBalance.TabIndex = 10;
            this.lbBalance.Text = "00.00";
            // 
            // lbNombre
            // 
            this.lbNombre.BackColor = System.Drawing.SystemColors.Info;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbNombre.Location = new System.Drawing.Point(253, 16);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(258, 21);
            this.lbNombre.TabIndex = 9;
            // 
            // lbMatricula
            // 
            this.lbMatricula.BackColor = System.Drawing.SystemColors.Info;
            this.lbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbMatricula.Location = new System.Drawing.Point(83, 16);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(96, 21);
            this.lbMatricula.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(517, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(185, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matricula:";
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
            this.colIdEstudiante,
            this.colIdInscripcion,
            this.colMatricula,
            this.colNombre,
            this.colBalance,
            this.colObservaciones});
            this.dgInscripciones.Location = new System.Drawing.Point(12, 205);
            this.dgInscripciones.MultiSelect = false;
            this.dgInscripciones.Name = "dgInscripciones";
            this.dgInscripciones.ReadOnly = true;
            this.dgInscripciones.RowHeadersVisible = false;
            this.dgInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInscripciones.Size = new System.Drawing.Size(690, 192);
            this.dgInscripciones.TabIndex = 2;
            this.dgInscripciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInscripciones_CellContentClick);
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.Info;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbTotal.ForeColor = System.Drawing.Color.Lime;
            this.lbTotal.Location = new System.Drawing.Point(634, 400);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(68, 21);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(589, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total";
            // 
            // colIdEstudiante
            // 
            this.colIdEstudiante.DataPropertyName = "IdEstudiante";
            this.colIdEstudiante.HeaderText = "IdEstudiante";
            this.colIdEstudiante.Name = "colIdEstudiante";
            this.colIdEstudiante.ReadOnly = true;
            this.colIdEstudiante.Visible = false;
            this.colIdEstudiante.Width = 72;
            // 
            // colIdInscripcion
            // 
            this.colIdInscripcion.DataPropertyName = "IdInscripcion";
            this.colIdInscripcion.HeaderText = "IdInscripcion";
            this.colIdInscripcion.Name = "colIdInscripcion";
            this.colIdInscripcion.ReadOnly = true;
            this.colIdInscripcion.Visible = false;
            this.colIdInscripcion.Width = 73;
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
            // colBalance
            // 
            this.colBalance.DataPropertyName = "Balance";
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            this.colBalance.Width = 71;
            // 
            // colObservaciones
            // 
            this.colObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObservaciones.DataPropertyName = "Observaciones";
            this.colObservaciones.HeaderText = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.ReadOnly = true;
            // 
            // FrmCaja
            // 
            this.AcceptButton = this.btnFiltro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 430);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dgInscripciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 469);
            this.Name = "FrmCaja";
            this.Text = "Caja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lbMontoDevuelto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgInscripciones;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
    }
}