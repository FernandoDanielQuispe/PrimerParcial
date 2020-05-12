namespace Quispe.Fernando
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblFotoCandado = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblFotoPass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(196, 108);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(162, 22);
            this.txtBoxUsuario.TabIndex = 1;
            this.txtBoxUsuario.TextChanged += new System.EventHandler(this.txtBoxUsuario_TextChanged);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(195, 174);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(163, 22);
            this.txtBoxPass.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "candado.png");
            // 
            // lblFotoCandado
            // 
            this.lblFotoCandado.ImageIndex = 0;
            this.lblFotoCandado.ImageList = this.imageList1;
            this.lblFotoCandado.Location = new System.Drawing.Point(125, 160);
            this.lblFotoCandado.Name = "lblFotoCandado";
            this.lblFotoCandado.Size = new System.Drawing.Size(41, 51);
            this.lblFotoCandado.TabIndex = 4;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "rostro.png");
            // 
            // lblFotoPass
            // 
            this.lblFotoPass.ImageIndex = 0;
            this.lblFotoPass.ImageList = this.imageList2;
            this.lblFotoPass.Location = new System.Drawing.Point(129, 100);
            this.lblFotoPass.Name = "lblFotoPass";
            this.lblFotoPass.Size = new System.Drawing.Size(30, 30);
            this.lblFotoPass.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Location = new System.Drawing.Point(165, 33);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(221, 43);
            this.lblInicioSesion.TabIndex = 7;
            this.lblInicioSesion.Text = "Inicio de Sesion";
            this.lblInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(534, 383);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFotoPass);
            this.Controls.Add(this.lblFotoCandado);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUsuario);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblFotoCandado;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lblFotoPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInicioSesion;
    }
}