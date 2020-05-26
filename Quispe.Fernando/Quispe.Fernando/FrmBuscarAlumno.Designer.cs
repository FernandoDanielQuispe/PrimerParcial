namespace Quispe.Fernando
{
    partial class FrmBuscarAlumno
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listViewApellido = new System.Windows.Forms.ListView();
            this.columna1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(26, 49);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(128, 20);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Ingrese Apellido";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(186, 47);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(169, 22);
            this.txtBoxApellido.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(421, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(305, 444);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 31);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listViewApellido
            // 
            this.listViewApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewApellido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5});
            this.listViewApellido.HideSelection = false;
            this.listViewApellido.Location = new System.Drawing.Point(19, 92);
            this.listViewApellido.Name = "listViewApellido";
            this.listViewApellido.Size = new System.Drawing.Size(725, 328);
            this.listViewApellido.TabIndex = 5;
            this.listViewApellido.UseCompatibleStateImageBehavior = false;
            this.listViewApellido.View = System.Windows.Forms.View.Details;
            // 
            // columna1
            // 
            this.columna1.Text = "Apellido";
            this.columna1.Width = 145;
            // 
            // columna2
            // 
            this.columna2.Text = "Nombre";
            this.columna2.Width = 143;
            // 
            // columna3
            // 
            this.columna3.Text = "Legajo";
            this.columna3.Width = 93;
            // 
            // columna4
            // 
            this.columna4.Text = "Aula";
            this.columna4.Width = 98;
            // 
            // columna5
            // 
            this.columna5.Text = "Cuota";
            this.columna5.Width = 100;
            // 
            // FrmBuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.listViewApellido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblApellido);
            this.Name = "FrmBuscarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Alumno";
            this.Load += new System.EventHandler(this.FrmBuscarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView listViewApellido;
        private System.Windows.Forms.ColumnHeader columna1;
        private System.Windows.Forms.ColumnHeader columna2;
        private System.Windows.Forms.ColumnHeader columna3;
        private System.Windows.Forms.ColumnHeader columna4;
        private System.Windows.Forms.ColumnHeader columna5;
    }
}