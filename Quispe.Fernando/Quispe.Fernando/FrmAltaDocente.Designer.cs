namespace Quispe.Fernando
{
    partial class FrmAltaDocente
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDefecto = new System.Windows.Forms.Label();
            this.txtBoxHoraIn = new System.Windows.Forms.TextBox();
            this.txtBoxHoraOut = new System.Windows.Forms.TextBox();
            this.lblHoraIn = new System.Windows.Forms.Label();
            this.lblHoraOut = new System.Windows.Forms.Label();
            this.txtBoxValorHora = new System.Windows.Forms.TextBox();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(122, 65);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(189, 22);
            this.txtBoxApellido.TabIndex = 0;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(405, 65);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(255, 22);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(122, 130);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(189, 22);
            this.txtBoxDNI.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(25, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(23, 129);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 17);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(338, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(338, 132);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 17);
            this.lblSex.TabIndex = 9;
            this.lblSex.Text = "Sexo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(456, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 30);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(292, 296);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 30);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblDefecto
            // 
            this.lblDefecto.AutoSize = true;
            this.lblDefecto.Location = new System.Drawing.Point(502, 130);
            this.lblDefecto.Name = "lblDefecto";
            this.lblDefecto.Size = new System.Drawing.Size(167, 17);
            this.lblDefecto.TabIndex = 13;
            this.lblDefecto.Text = "Por defecto es Masculino";
            // 
            // txtBoxHoraIn
            // 
            this.txtBoxHoraIn.Location = new System.Drawing.Point(122, 196);
            this.txtBoxHoraIn.Name = "txtBoxHoraIn";
            this.txtBoxHoraIn.Size = new System.Drawing.Size(71, 22);
            this.txtBoxHoraIn.TabIndex = 17;
            // 
            // txtBoxHoraOut
            // 
            this.txtBoxHoraOut.Location = new System.Drawing.Point(335, 193);
            this.txtBoxHoraOut.Name = "txtBoxHoraOut";
            this.txtBoxHoraOut.Size = new System.Drawing.Size(74, 22);
            this.txtBoxHoraOut.TabIndex = 18;
            // 
            // lblHoraIn
            // 
            this.lblHoraIn.AutoSize = true;
            this.lblHoraIn.Location = new System.Drawing.Point(23, 196);
            this.lblHoraIn.Name = "lblHoraIn";
            this.lblHoraIn.Size = new System.Drawing.Size(93, 17);
            this.lblHoraIn.TabIndex = 19;
            this.lblHoraIn.Text = "Hora Entrada";
            // 
            // lblHoraOut
            // 
            this.lblHoraOut.AutoSize = true;
            this.lblHoraOut.Location = new System.Drawing.Point(229, 196);
            this.lblHoraOut.Name = "lblHoraOut";
            this.lblHoraOut.Size = new System.Drawing.Size(82, 17);
            this.lblHoraOut.TabIndex = 20;
            this.lblHoraOut.Text = "Hora Salida";
            // 
            // txtBoxValorHora
            // 
            this.txtBoxValorHora.Location = new System.Drawing.Point(592, 193);
            this.txtBoxValorHora.Name = "txtBoxValorHora";
            this.txtBoxValorHora.Size = new System.Drawing.Size(68, 22);
            this.txtBoxValorHora.TabIndex = 21;
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Location = new System.Drawing.Point(478, 199);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(108, 17);
            this.lblValorHora.TabIndex = 22;
            this.lblValorHora.Text = "Valor Hora      $";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(132, 176);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(50, 17);
            this.lblFormato.TabIndex = 23;
            this.lblFormato.Text = "hh:mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "hh:mm";
            // 
            // checkBoxFem
            // 
            this.checkBoxFem.AutoSize = true;
            this.checkBoxFem.Location = new System.Drawing.Point(404, 130);
            this.checkBoxFem.Name = "checkBoxFem";
            this.checkBoxFem.Size = new System.Drawing.Size(92, 21);
            this.checkBoxFem.TabIndex = 36;
            this.checkBoxFem.Text = "Femenino";
            this.checkBoxFem.UseVisualStyleBackColor = true;
            // 
            // FrmAltaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxFem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.txtBoxValorHora);
            this.Controls.Add(this.lblHoraOut);
            this.Controls.Add(this.lblHoraIn);
            this.Controls.Add(this.txtBoxHoraOut);
            this.Controls.Add(this.txtBoxHoraIn);
            this.Controls.Add(this.lblDefecto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxApellido);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FrmAltaDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Alta de Docente";
            this.Load += new System.EventHandler(this.FrmAltaDocente_Load);
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblDefecto;
        private System.Windows.Forms.TextBox txtBoxHoraIn;
        private System.Windows.Forms.TextBox txtBoxHoraOut;
        private System.Windows.Forms.Label lblHoraIn;
        private System.Windows.Forms.Label lblHoraOut;
        private System.Windows.Forms.TextBox txtBoxValorHora;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFem;
    }
}