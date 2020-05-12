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
    public partial class FrmPpal : Form
    {       
        public FrmPpal()
        {
            InitializeComponent();           
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            //pictureBoxPpal.Image = Image.FromFile("C:\\UTN PP\\Quispe.Fernando\\Quispe.Fernando\\ImagenPpal.jpg");
            //pictureBoxPpal.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAula Altaaula = new FrmAltaAula();
            Altaaula.MdiParent = this;
            Altaaula.Show();
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AltaDocente = new FrmAltaDocente();
            AltaDocente.Show();
            AltaDocente.MdiParent = this;

        }

        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AltaNoDocente = new FrmAltaNoDocente();
            AltaNoDocente.Show();
            AltaNoDocente.MdiParent = this;
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AltaAlumno = new FrmAltaAlumno();
            AltaAlumno.Show();
            AltaAlumno.MdiParent = this;
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InformacionPadres = new FrmInformacionPadres();
            InformacionPadres.Show();
            InformacionPadres.MdiParent = this;
        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SueldoDocente = new FrmSueldoDocente();
            SueldoDocente.Show();
            SueldoDocente.MdiParent = this;
        }

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SueldoNoDocente = new FrmSueldoNoDocente();
            SueldoNoDocente.Show();
            SueldoNoDocente.MdiParent = this;
        }

        private void recaudaciónPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RecaudacionAula = new FrmRecaudacionAula();
            RecaudacionAula.Show();
            RecaudacionAula.MdiParent = this;
        }

        private void recaudaciónTotalDelJardínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RecaudacionTotal = new FrmRecaudacionTotal();
            RecaudacionTotal.Show();
            RecaudacionTotal.MdiParent = this;
        }

        //private void _CloseButton_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Application.Exit();
        //}
        
    }
}
