namespace Quispe.Fernando
{
    partial class FrmVideos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideos));
            this.wmpVideos = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBabyShark = new System.Windows.Forms.Button();
            this.btnPeppaPig = new System.Windows.Forms.Button();
            this.btnToyStory = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpVideos
            // 
            this.wmpVideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.wmpVideos.Enabled = true;
            this.wmpVideos.Location = new System.Drawing.Point(0, 0);
            this.wmpVideos.Name = "wmpVideos";
            this.wmpVideos.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideos.OcxState")));
            this.wmpVideos.Size = new System.Drawing.Size(760, 347);
            this.wmpVideos.TabIndex = 0;
            this.wmpVideos.Enter += new System.EventHandler(this.wmpVideos_Enter);
            // 
            // btnBabyShark
            // 
            this.btnBabyShark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBabyShark.Location = new System.Drawing.Point(86, 449);
            this.btnBabyShark.Name = "btnBabyShark";
            this.btnBabyShark.Size = new System.Drawing.Size(120, 35);
            this.btnBabyShark.TabIndex = 1;
            this.btnBabyShark.Text = "Baby Shark";
            this.btnBabyShark.UseVisualStyleBackColor = true;
            this.btnBabyShark.Click += new System.EventHandler(this.btnBabyShark_Click);
            // 
            // btnPeppaPig
            // 
            this.btnPeppaPig.Location = new System.Drawing.Point(321, 449);
            this.btnPeppaPig.Name = "btnPeppaPig";
            this.btnPeppaPig.Size = new System.Drawing.Size(120, 35);
            this.btnPeppaPig.TabIndex = 2;
            this.btnPeppaPig.Text = "Peppa Pig";
            this.btnPeppaPig.UseVisualStyleBackColor = true;
            this.btnPeppaPig.Click += new System.EventHandler(this.btnPeppaPig_Click);
            // 
            // btnToyStory
            // 
            this.btnToyStory.Location = new System.Drawing.Point(557, 449);
            this.btnToyStory.Name = "btnToyStory";
            this.btnToyStory.Size = new System.Drawing.Size(120, 35);
            this.btnToyStory.TabIndex = 3;
            this.btnToyStory.Text = "Toy Story";
            this.btnToyStory.UseVisualStyleBackColor = true;
            this.btnToyStory.Click += new System.EventHandler(this.btnToyStory_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(321, 503);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(760, 556);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnToyStory);
            this.Controls.Add(this.btnPeppaPig);
            this.Controls.Add(this.btnBabyShark);
            this.Controls.Add(this.wmpVideos);
            this.Name = "FrmVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videos";
            this.Load += new System.EventHandler(this.FrmVideos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideos;
        private System.Windows.Forms.Button btnBabyShark;
        private System.Windows.Forms.Button btnPeppaPig;
        private System.Windows.Forms.Button btnToyStory;
        private System.Windows.Forms.Button btnSalir;
    }
}