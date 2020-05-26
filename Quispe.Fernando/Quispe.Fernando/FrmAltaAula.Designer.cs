namespace Quispe.Fernando
{
    partial class FrmAltaAula
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
            this.ComboBoxColor = new System.Windows.Forms.ComboBox();
            this.ComboBoxTurno = new System.Windows.Forms.ComboBox();
            this.ComboBoxProf = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAlumSala = new System.Windows.Forms.Label();
            this.lblAlumSinSala = new System.Windows.Forms.Label();
            this.btnAsignarAlumno = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listViewSinAula = new System.Windows.Forms.ListView();
            this.columna1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEnSala = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.FormattingEnabled = true;
            this.ComboBoxColor.Location = new System.Drawing.Point(124, 35);
            this.ComboBoxColor.Name = "ComboBoxColor";
            this.ComboBoxColor.Size = new System.Drawing.Size(148, 24);
            this.ComboBoxColor.TabIndex = 0;
            this.ComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColor_SelectedIndexChanged);
            // 
            // ComboBoxTurno
            // 
            this.ComboBoxTurno.Location = new System.Drawing.Point(358, 35);
            this.ComboBoxTurno.Name = "ComboBoxTurno";
            this.ComboBoxTurno.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxTurno.TabIndex = 18;
            this.ComboBoxTurno.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTurno_SelectedIndexChanged_1);
            // 
            // ComboBoxProf
            // 
            this.ComboBoxProf.FormattingEnabled = true;
            this.ComboBoxProf.Location = new System.Drawing.Point(588, 36);
            this.ComboBoxProf.Name = "ComboBoxProf";
            this.ComboBoxProf.Size = new System.Drawing.Size(148, 24);
            this.ComboBoxProf.TabIndex = 3;
            this.ComboBoxProf.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProf_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(290, 39);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 17);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno";
            this.lblTurno.Click += new System.EventHandler(this.lblTurno_Click);
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(520, 38);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(62, 17);
            this.lblProfesor.TabIndex = 5;
            this.lblProfesor.Text = "Profesor";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(16, 36);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(93, 17);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color de Sala";
            // 
            // lblAlumSala
            // 
            this.lblAlumSala.AutoSize = true;
            this.lblAlumSala.Location = new System.Drawing.Point(488, 96);
            this.lblAlumSala.Name = "lblAlumSala";
            this.lblAlumSala.Size = new System.Drawing.Size(114, 17);
            this.lblAlumSala.TabIndex = 7;
            this.lblAlumSala.Text = "Alumnos en Sala";
            // 
            // lblAlumSinSala
            // 
            this.lblAlumSinSala.AutoSize = true;
            this.lblAlumSinSala.Location = new System.Drawing.Point(16, 96);
            this.lblAlumSinSala.Name = "lblAlumSinSala";
            this.lblAlumSinSala.Size = new System.Drawing.Size(116, 17);
            this.lblAlumSinSala.TabIndex = 8;
            this.lblAlumSinSala.Text = "Alumnos sin Aula";
            this.lblAlumSinSala.Click += new System.EventHandler(this.lblAlumSinSala_Click);
            // 
            // btnAsignarAlumno
            // 
            this.btnAsignarAlumno.Location = new System.Drawing.Point(352, 602);
            this.btnAsignarAlumno.Name = "btnAsignarAlumno";
            this.btnAsignarAlumno.Size = new System.Drawing.Size(127, 33);
            this.btnAsignarAlumno.TabIndex = 11;
            this.btnAsignarAlumno.Text = "Asignar Alumno";
            this.btnAsignarAlumno.UseVisualStyleBackColor = true;
            this.btnAsignarAlumno.Click += new System.EventHandler(this.btnAsignarAlumno_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(508, 602);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listViewSinAula
            // 
            this.listViewSinAula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5,
            this.columna6,
            this.columna7});
            this.listViewSinAula.HideSelection = false;
            this.listViewSinAula.Location = new System.Drawing.Point(12, 128);
            this.listViewSinAula.Name = "listViewSinAula";
            this.listViewSinAula.Size = new System.Drawing.Size(450, 431);
            this.listViewSinAula.TabIndex = 15;
            this.listViewSinAula.UseCompatibleStateImageBehavior = false;
            this.listViewSinAula.View = System.Windows.Forms.View.Details;
            this.listViewSinAula.SelectedIndexChanged += new System.EventHandler(this.listViewSinAula_SelectedIndexChanged);
            // 
            // columna1
            // 
            this.columna1.Text = "Legajo";
            this.columna1.Width = 54;
            // 
            // columna2
            // 
            this.columna2.Text = "Apellido";
            this.columna2.Width = 69;
            // 
            // columna3
            // 
            this.columna3.Text = "Nombre";
            this.columna3.Width = 66;
            // 
            // columna4
            // 
            this.columna4.Text = "DNI";
            this.columna4.Width = 59;
            // 
            // columna5
            // 
            this.columna5.Text = "Sala";
            // 
            // columna6
            // 
            this.columna6.Text = "Femenino";
            this.columna6.Width = 73;
            // 
            // columna7
            // 
            this.columna7.Text = "Cuota";
            // 
            // listViewEnSala
            // 
            this.listViewEnSala.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7});
            this.listViewEnSala.Location = new System.Drawing.Point(491, 128);
            this.listViewEnSala.Name = "listViewEnSala";
            this.listViewEnSala.Size = new System.Drawing.Size(459, 431);
            this.listViewEnSala.TabIndex = 16;
            this.listViewEnSala.UseCompatibleStateImageBehavior = false;
            this.listViewEnSala.View = System.Windows.Forms.View.Details;
            this.listViewEnSala.SelectedIndexChanged += new System.EventHandler(this.listViewEnSala_SelectedIndexChanged);
            // 
            // col1
            // 
            this.col1.Text = "Legajo";
            // 
            // col2
            // 
            this.col2.Text = "Apellido";
            this.col2.Width = 67;
            // 
            // col3
            // 
            this.col3.Text = "Nombre";
            this.col3.Width = 67;
            // 
            // col4
            // 
            this.col4.Text = "DNI";
            // 
            // col5
            // 
            this.col5.Text = "Sala";
            // 
            // col6
            // 
            this.col6.Text = "Femenino";
            this.col6.Width = 75;
            // 
            // col7
            // 
            this.col7.Text = "Cuota";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(793, 31);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(131, 31);
            this.btnCrear.TabIndex = 17;
            this.btnCrear.Text = "Asignar Profesor";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(962, 688);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.listViewEnSala);
            this.Controls.Add(this.listViewSinAula);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignarAlumno);
            this.Controls.Add(this.lblAlumSinSala);
            this.Controls.Add(this.lblAlumSala);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.ComboBoxProf);
            this.Controls.Add(this.ComboBoxTurno);
            this.Controls.Add(this.ComboBoxColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmAltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Aula";
            this.Load += new System.EventHandler(this.FrmAltaAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxColor;
        private System.Windows.Forms.ComboBox ComboBoxTurno;
        private System.Windows.Forms.ComboBox ComboBoxProf;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAlumSala;
        private System.Windows.Forms.Label lblAlumSinSala;
        private System.Windows.Forms.Button btnAsignarAlumno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView listViewSinAula;
        private System.Windows.Forms.ColumnHeader columna1;
        private System.Windows.Forms.ColumnHeader columna2;
        private System.Windows.Forms.ColumnHeader columna3;
        private System.Windows.Forms.ColumnHeader columna4;
        private System.Windows.Forms.ColumnHeader columna5;
        private System.Windows.Forms.ColumnHeader columna6;
        private System.Windows.Forms.ColumnHeader columna7;
        private System.Windows.Forms.ListView listViewEnSala;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col5;
        private System.Windows.Forms.ColumnHeader col6;
        private System.Windows.Forms.ColumnHeader col7;
        private System.Windows.Forms.Button btnCrear;
    }
}