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
    public partial class FrmAltaDocente : Form
    {
        private Docente docente;
        private List<Docente> listaDocente;


        public FrmAltaDocente()
        {
            InitializeComponent();
        }

        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {
            listaDocente = new List<Docente>();
        }

        public Docente Docente
        {
            get
            {
                return this.docente;
            }            
        }
        public List<Docente> ListaDocente
        {
            get
            {
                return this.listaDocente;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            this.txtBoxApellido.Clear();
            this.txtBoxNombre.Clear();
            this.txtBoxDNI.Clear();
            this.radioBtnFem.Checked = false;
            this.txtBoxHoraIn.Clear();
            this.txtBoxHoraOut.Clear();
            this.txtBoxValorHora.Clear();            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }


        /// <summary>
        /// Se agregan los datos
        /// Informacion de datetime  https://docs.microsoft.com/es-es/dotnet/api/system.datetime?view=netcore-3.1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxDNI.Text, out int dniDocente) && DateTime.TryParse(txtBoxHoraIn.Text, out DateTime horaIn) && DateTime.TryParse(txtBoxHoraOut.Text, out DateTime horaOut) && float.TryParse(txtBoxValorHora.Text, out float valorHora))
            {
                docente = new Docente(txtBoxNombre.Text, txtBoxApellido.Text, dniDocente, radioBtnFem.Checked, horaIn, horaOut, valorHora);
                
                listaDocente.Add(docente);

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
