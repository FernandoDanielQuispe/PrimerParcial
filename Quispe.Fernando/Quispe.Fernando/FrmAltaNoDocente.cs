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
    public partial class FrmAltaNoDocente : Form
    {
        private Administrativo administrativo;
        public FrmAltaNoDocente()
        {
            InitializeComponent();
        }

        private void FrmAltaNoDocente_Load(object sender, EventArgs e)
        {
            ingresarCargo();
        }

        public Administrativo Administrativo
        {
            get
            {
                return this.administrativo;
            }        
        }

        private void ingresarCargo()
        {
            comboBoxCargo.Items.Clear();
            foreach (ECargo item in Enum.GetValues(typeof(ECargo)))
            {
                comboBoxCargo.Items.Add(item);
            }
        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Limpiar()
        {
            this.txtBoxApellido.Clear();
            this.txtBoxNombre.Clear();
            this.txtBoxDNI.Clear();
            this.radioBtnFem.Checked = false;            
            this.comboBoxCargo.Text = "";
            this.txtBoxHoraIn.Clear();
            this.txtBoxHoraOut.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxDNI.Text, out int dniNoDocente) && DateTime.TryParse(txtBoxHoraIn.Text, out DateTime horaIn) && DateTime.TryParse(txtBoxHoraOut.Text, out DateTime horaOut))
            {
                administrativo = new Administrativo(txtBoxApellido.Text, txtBoxNombre.Text, dniNoDocente, radioBtnFem.Checked, horaIn, horaOut, (ECargo)Enum.Parse(typeof(ECargo), comboBoxCargo.Text));

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
    }
}
