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
    public partial class FrmRecaudacionTotal : Form
    {
        private List<Alumno> alumnoEnSala;
        public FrmRecaudacionTotal(List<Alumno> alumnoEnSala)
        {
            InitializeComponent();
            this.alumnoEnSala = alumnoEnSala;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// se muestra el total recaudado por el jardin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRecaudacionTotal_Load(object sender, EventArgs e)
        {        
            double reTotal = 0;
            foreach (Alumno item in alumnoEnSala)
            {
                reTotal += item.PrecioCuota;
            }            
            txtBoxTotal.Text = reTotal.ToString();
        }
    }
}
