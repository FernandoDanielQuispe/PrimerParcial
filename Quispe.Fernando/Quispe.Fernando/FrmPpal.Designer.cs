namespace Quispe.Fernando
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónTotalDelJardínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxPpal = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPpal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Reporte,
            this.datosToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Archivo";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(73, 24);
            this.Archivo.Text = "Archivo";
            // 
            // altaDeDocenteToolStripMenuItem
            // 
            this.altaDeDocenteToolStripMenuItem.Name = "altaDeDocenteToolStripMenuItem";
            this.altaDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.altaDeDocenteToolStripMenuItem.Text = "Alta de docente";
            this.altaDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta no docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.altaAlumnoToolStripMenuItem.Text = "Alta alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.altaAulaToolStripMenuItem.Text = "Alta aula";
            this.altaAulaToolStripMenuItem.Click += new System.EventHandler(this.altaAulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Reporte
            // 
            this.Reporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudaciónPorAulaToolStripMenuItem,
            this.recaudaciónTotalDelJardínToolStripMenuItem});
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(76, 24);
            this.Reporte.Text = "Reporte";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.informacionToolStripMenuItem.Text = "Informacion padres";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo docente";
            this.sueldoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoDocenteToolStripMenuItem_Click);
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo no docente";
            this.sueldoNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoNoDocenteToolStripMenuItem_Click);
            // 
            // recaudaciónPorAulaToolStripMenuItem
            // 
            this.recaudaciónPorAulaToolStripMenuItem.Name = "recaudaciónPorAulaToolStripMenuItem";
            this.recaudaciónPorAulaToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.recaudaciónPorAulaToolStripMenuItem.Text = "Recaudación por aula";
            this.recaudaciónPorAulaToolStripMenuItem.Click += new System.EventHandler(this.recaudaciónPorAulaToolStripMenuItem_Click);
            // 
            // recaudaciónTotalDelJardínToolStripMenuItem
            // 
            this.recaudaciónTotalDelJardínToolStripMenuItem.Name = "recaudaciónTotalDelJardínToolStripMenuItem";
            this.recaudaciónTotalDelJardínToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.recaudaciónTotalDelJardínToolStripMenuItem.Text = "Recaudación total del jardín";
            this.recaudaciónTotalDelJardínToolStripMenuItem.Click += new System.EventHandler(this.recaudaciónTotalDelJardínToolStripMenuItem_Click);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarDatosToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // cargarDatosToolStripMenuItem
            // 
            this.cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            this.cargarDatosToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cargarDatosToolStripMenuItem.Text = "Cargar Datos";
            this.cargarDatosToolStripMenuItem.Click += new System.EventHandler(this.cargarDatosToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // videosToolStripMenuItem
            // 
            this.videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            this.videosToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.videosToolStripMenuItem.Text = "Videos";
            this.videosToolStripMenuItem.Click += new System.EventHandler(this.videosToolStripMenuItem_Click);
            // 
            // pictureBoxPpal
            // 
            this.pictureBoxPpal.ErrorImage = null;
            this.pictureBoxPpal.Image = global::Quispe.Fernando.Properties.Resources.Imagen;
            this.pictureBoxPpal.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxPpal.Name = "pictureBoxPpal";
            this.pictureBoxPpal.Size = new System.Drawing.Size(1159, 738);
            this.pictureBoxPpal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPpal.TabIndex = 1;
            this.pictureBoxPpal.TabStop = false;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1159, 763);
            this.Controls.Add(this.pictureBoxPpal);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin de infantes \"Los pichoncitos\"";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPpal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Reporte;
        private System.Windows.Forms.ToolStripMenuItem altaDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónTotalDelJardínToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPpal;
    }
}

