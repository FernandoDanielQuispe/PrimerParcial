using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quispe.Fernando
{
    public partial class FrmAltaAlumno : Form
    {
        private Alumno nuevoAlumno;
        private Responsable responsable;

        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            ingresarColorSala();
            ingresarParentesco();
           
        }

        public Alumno NuevoAlumno
        {
            get
            {
                return this.nuevoAlumno;
            }
        }
        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
        }

        private void ingresarColorSala()
        {
            comboBoxParen.Items.Clear();
            foreach (EColores item in Enum.GetValues(typeof(EColores)))
            {
                comboBoxSala.Items.Add(item);
            }
        }

        private void ingresarParentesco()
        {
            comboBoxParen.Items.Clear();
            foreach (EParentesco item in Enum.GetValues(typeof(EParentesco)))
            {
                comboBoxParen.Items.Add(item);
            }
        }

        private void Limpiar()
        {
            this.txtBoxApellido.Clear();
            this.txtBoxNombre.Clear();
            this.txtBoxDNI.Clear();
            this.radioBtnFem.Checked = false;
            this.txtBoxLegajo.Clear();
            this.comboBoxSala.Text = "";
            this.txtBoxPrecio.Clear();
            this.comboBoxParen.Text = "";
            this.txtBoxApellidoR.Clear();
            this.txtBoxNombreR.Clear();
            this.txtBoxDNIR.Clear();
            this.txtBoxTel.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        /// <summary>
        /// Se agregan los datos
        /// info de datetime  https://docs.microsoft.com/es-es/dotnet/api/system.datetime?view=netcore-3.1
        /// info //this.nuevoAlumno = new Alumno(this.txtBoxNombre.Text, this.txtBoxApellido.Text, Convert.ToInt32(txtBoxDNILegajo.Text), this.radioBtnFem.Checked, Convert.ToInt64(txtBoxPrecio.Text));
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxDNI.Text, out int dniAlumno) && float.TryParse(txtBoxPrecio.Text, out float precioCuota) && int.TryParse(txtBoxLegajo.Text, out int Legajo) && int.TryParse(txtBoxDNIR.Text, out int dniResponsable))
            {
                nuevoAlumno = new Alumno(txtBoxNombre.Text, txtBoxApellido.Text, dniAlumno, radioBtnFem.Checked, (EColores)Enum.Parse(typeof(EColores), comboBoxSala.Text), Legajo, precioCuota, responsable);

                responsable = new Responsable(txtBoxNombreR.Text, txtBoxApellidoR.Text, dniResponsable, (EParentesco)Enum.Parse(typeof(EParentesco), comboBoxParen.Text), txtBoxTel.Text);
                                
                DialogResult resultado = new DialogResult();
                Form mensaje = new FrmMessageBox();
                resultado = mensaje.ShowDialog();
            }
            else
            {
                DialogResult resul = new DialogResult();
                Form msj = new FrmMessageBoxError();
                resul = msj.ShowDialog();
            }
        }

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
