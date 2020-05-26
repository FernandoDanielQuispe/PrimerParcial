using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Quispe.Fernando
{
    public partial class FrmInformacionPadres : Form
    {
        private List<Alumno> alumnoEnSala;

        public FrmInformacionPadres(List<Alumno> alumnoEnSala)
        {
            InitializeComponent();
            this.alumnoEnSala = alumnoEnSala;
            foreach (Alumno item in alumnoEnSala)
            {
                richTextBoxPadres.AppendText(item.Responsable.ToString() + "\n");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmInformacionPadres_Load(object sender, EventArgs e)
        {
        }
        private void richTextBoxPadres_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
