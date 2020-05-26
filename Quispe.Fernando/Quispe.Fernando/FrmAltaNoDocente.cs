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
using System.Media;

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
            foreach (int i in Enum.GetValues(typeof(ECargo)))
            {
                comboBoxCargo.Items.Add((ECargo)i);
            }
        }

        public Administrativo Administrativo
        {
            get
            {
                return this.administrativo;
            }        
        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }
        /// <summary>
        /// se limpian los casilleros
        /// </summary>
        private void Limpiar()
        {
            this.txtBoxApellido.Clear();
            this.txtBoxNombre.Clear();
            this.txtBoxDNI.Clear();
            this.checkBoxFem.Checked = false;            
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

        /// <summary>
        /// agregamos a los administrativos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxDNI.Text, out int dniNoDocente) && DateTime.TryParse(txtBoxHoraIn.Text, out DateTime horaIn) && DateTime.TryParse(txtBoxHoraOut.Text, out DateTime horaOut))
            {
                administrativo = new Administrativo(txtBoxApellido.Text, txtBoxNombre.Text, dniNoDocente, checkBoxFem.Checked, horaIn, horaOut, (ECargo)Enum.Parse(typeof(ECargo), comboBoxCargo.Text));

                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                sound.Play();

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
