namespace Quispe.Fernando
{
    partial class FrmAltaNoDocente
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
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.radioBtnFem = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxHoraIn = new System.Windows.Forms.TextBox();
            this.txtBoxHoraOut = new System.Windows.Forms.TextBox();
            this.lblHoraIn = new System.Windows.Forms.Label();
            this.lblHoraOut = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(111, 65);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(180, 22);
            this.txtBoxApellido.TabIndex = 0;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(439, 65);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(227, 22);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(111, 130);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(180, 22);
            this.txtBoxDNI.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(18, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(18, 132);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 17);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(321, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(321, 132);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 17);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sexo:";
            // 
            // radioBtnFem
            // 
            this.radioBtnFem.AutoSize = true;
            this.radioBtnFem.Location = new System.Drawing.Point(390, 130);
            this.radioBtnFem.Name = "radioBtnFem";
            this.radioBtnFem.Size = new System.Drawing.Size(91, 21);
            this.radioBtnFem.TabIndex = 7;
            this.radioBtnFem.TabStop = true;
            this.radioBtnFem.Text = "Femenino";
            this.radioBtnFem.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(111, 338);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(284, 338);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 30);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(462, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(18, 197);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 17);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.Text = "Cargo";
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(111, 197);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(180, 24);
            this.comboBoxCargo.TabIndex = 14;
            this.comboBoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCargo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Masculino por defecto";
            // 
            // txtBoxHoraIn
            // 
            this.txtBoxHoraIn.Location = new System.Drawing.Point(420, 201);
            this.txtBoxHoraIn.Name = "txtBoxHoraIn";
            this.txtBoxHoraIn.Size = new System.Drawing.Size(71, 22);
            this.txtBoxHoraIn.TabIndex = 16;
            // 
            // txtBoxHoraOut
            // 
            this.txtBoxHoraOut.Location = new System.Drawing.Point(587, 201);
            this.txtBoxHoraOut.Name = "txtBoxHoraOut";
            this.txtBoxHoraOut.Size = new System.Drawing.Size(79, 22);
            this.txtBoxHoraOut.TabIndex = 17;
            // 
            // lblHoraIn
            // 
            this.lblHoraIn.AutoSize = true;
            this.lblHoraIn.Location = new System.Drawing.Point(321, 204);
            this.lblHoraIn.Name = "lblHoraIn";
            this.lblHoraIn.Size = new System.Drawing.Size(93, 17);
            this.lblHoraIn.TabIndex = 18;
            this.lblHoraIn.Text = "Hora Entrada";
            // 
            // lblHoraOut
            // 
            this.lblHoraOut.AutoSize = true;
            this.lblHoraOut.Location = new System.Drawing.Point(502, 204);
            this.lblHoraOut.Name = "lblHoraOut";
            this.lblHoraOut.Size = new System.Drawing.Size(82, 17);
            this.lblHoraOut.TabIndex = 19;
            this.lblHoraOut.Text = "Hora Salida";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(431, 181);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(50, 17);
            this.lblFormato.TabIndex = 20;
            this.lblFormato.Text = "hh:mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "hh:mm";
            // 
            // FrmAltaNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblHoraOut);
            this.Controls.Add(this.lblHoraIn);
            this.Controls.Add(this.txtBoxHoraOut);
            this.Controls.Add(this.txtBoxHoraIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.radioBtnFem);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxApellido);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FrmAltaNoDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta No Docente";
            this.Load += new System.EventHandler(this.FrmAltaNoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton radioBtnFem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxHoraIn;
        private System.Windows.Forms.TextBox txtBoxHoraOut;
        private System.Windows.Forms.Label lblHoraIn;
        private System.Windows.Forms.Label lblHoraOut;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label label2;
    }
}