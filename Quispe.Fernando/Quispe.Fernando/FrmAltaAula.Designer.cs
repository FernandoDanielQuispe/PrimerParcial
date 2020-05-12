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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.listBoxEnSala = new System.Windows.Forms.ListBox();
            this.listBoxSinAula = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.FormattingEnabled = true;
            this.ComboBoxColor.Location = new System.Drawing.Point(124, 35);
            this.ComboBoxColor.Name = "ComboBoxColor";
            this.ComboBoxColor.Size = new System.Drawing.Size(148, 24);
            this.ComboBoxColor.TabIndex = 0;
            this.ComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ComboBoxTurno
            // 
            this.ComboBoxTurno.FormattingEnabled = true;
            this.ComboBoxTurno.Location = new System.Drawing.Point(357, 36);
            this.ComboBoxTurno.Name = "ComboBoxTurno";
            this.ComboBoxTurno.Size = new System.Drawing.Size(148, 24);
            this.ComboBoxTurno.TabIndex = 2;
            this.ComboBoxTurno.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTurno_SelectedIndexChanged);
            // 
            // ComboBoxProf
            // 
            this.ComboBoxProf.FormattingEnabled = true;
            this.ComboBoxProf.Location = new System.Drawing.Point(588, 36);
            this.ComboBoxProf.Name = "ComboBoxProf";
            this.ComboBoxProf.Size = new System.Drawing.Size(148, 24);
            this.ComboBoxProf.TabIndex = 3;
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
            this.lblAlumSala.Location = new System.Drawing.Point(16, 96);
            this.lblAlumSala.Name = "lblAlumSala";
            this.lblAlumSala.Size = new System.Drawing.Size(114, 17);
            this.lblAlumSala.TabIndex = 7;
            this.lblAlumSala.Text = "Alumnos en Sala";
            // 
            // lblAlumSinSala
            // 
            this.lblAlumSinSala.AutoSize = true;
            this.lblAlumSinSala.Location = new System.Drawing.Point(389, 96);
            this.lblAlumSinSala.Name = "lblAlumSinSala";
            this.lblAlumSinSala.Size = new System.Drawing.Size(116, 17);
            this.lblAlumSinSala.TabIndex = 8;
            this.lblAlumSinSala.Text = "Alumnos sin Aula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(471, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 33);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // listBoxEnSala
            // 
            this.listBoxEnSala.FormattingEnabled = true;
            this.listBoxEnSala.ItemHeight = 16;
            this.listBoxEnSala.Location = new System.Drawing.Point(18, 125);
            this.listBoxEnSala.Name = "listBoxEnSala";
            this.listBoxEnSala.Size = new System.Drawing.Size(342, 308);
            this.listBoxEnSala.TabIndex = 12;
            // 
            // listBoxSinAula
            // 
            this.listBoxSinAula.FormattingEnabled = true;
            this.listBoxSinAula.ItemHeight = 16;
            this.listBoxSinAula.Location = new System.Drawing.Point(390, 125);
            this.listBoxSinAula.Name = "listBoxSinAula";
            this.listBoxSinAula.Size = new System.Drawing.Size(345, 308);
            this.listBoxSinAula.TabIndex = 13;
            this.listBoxSinAula.SelectedIndexChanged += new System.EventHandler(this.listBoxSinAula_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(617, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(765, 494);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.listBoxSinAula);
            this.Controls.Add(this.listBoxEnSala);
            this.Controls.Add(this.btnGuardar);
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox listBoxEnSala;
        private System.Windows.Forms.ListBox listBoxSinAula;
        private System.Windows.Forms.Button btnCancelar;
    }
}