namespace Quispe.Fernando
{
    partial class FrmMessageBoxAsignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBoxAsignacion));
            this.pictureBoxMessage = new System.Windows.Forms.PictureBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMessage
            // 
            this.pictureBoxMessage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMessage.Image")));
            this.pictureBoxMessage.Location = new System.Drawing.Point(30, 24);
            this.pictureBoxMessage.Name = "pictureBoxMessage";
            this.pictureBoxMessage.Size = new System.Drawing.Size(127, 124);
            this.pictureBoxMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMessage.TabIndex = 1;
            this.pictureBoxMessage.TabStop = false;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(188, 44);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(188, 25);
            this.lblIngreso.TabIndex = 2;
            this.lblIngreso.Text = "Se asigno Alumno";
            this.lblIngreso.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.Location = new System.Drawing.Point(215, 91);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(119, 37);
            this.btnMessage.TabIndex = 3;
            this.btnMessage.Text = "OK";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // FrmMessageBoxAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 182);
            this.ControlBox = false;
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.pictureBoxMessage);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "FrmMessageBoxAsignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMessage;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Button btnMessage;
    }
}