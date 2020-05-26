namespace Quispe.Fernando
{
    partial class FrmSueldoNoDocente
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
            this.lblNoDocentes = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBoxNoDocente = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoDocentes
            // 
            this.lblNoDocentes.AutoSize = true;
            this.lblNoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDocentes.Location = new System.Drawing.Point(47, 185);
            this.lblNoDocentes.Name = "lblNoDocentes";
            this.lblNoDocentes.Size = new System.Drawing.Size(255, 20);
            this.lblNoDocentes.TabIndex = 0;
            this.lblNoDocentes.Text = "Sueldo Total de los No Docentes";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(338, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 30);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBoxNoDocente
            // 
            this.txtBoxNoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNoDocente.Location = new System.Drawing.Point(368, 182);
            this.txtBoxNoDocente.Name = "txtBoxNoDocente";
            this.txtBoxNoDocente.ReadOnly = true;
            this.txtBoxNoDocente.Size = new System.Drawing.Size(185, 26);
            this.txtBoxNoDocente.TabIndex = 31;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(335, 188);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(18, 20);
            this.lblPesos.TabIndex = 32;
            this.lblPesos.Text = "$";
            // 
            // FrmSueldoNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.txtBoxNoDocente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNoDocentes);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FrmSueldoNoDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sueldo No Docentes";
            this.Load += new System.EventHandler(this.FrmSueldoNoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoDocentes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBoxNoDocente;
        private System.Windows.Forms.Label lblPesos;
    }
}