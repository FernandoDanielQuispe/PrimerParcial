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
    public partial class FrmRecaudacionAula : Form
    {
        List<Alumno> listAlumnoEnSala;
        public FrmRecaudacionAula(List<Alumno> listAlumnoEnSala)
        {
            InitializeComponent();
            this.listAlumnoEnSala = listAlumnoEnSala;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// se muestra la recaudacion por aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRecaudacionAula_Load(object sender, EventArgs e)
        {
            double reNaranja = 0, reRojo = 0, reAmarillo = 0, reVerde = 0;
            
            foreach (Alumno item in listAlumnoEnSala)
            {
                switch (item.ColorSala)
                {
                    case EColores.Naranja:
                        reNaranja += item.PrecioCuota;
                        break;
                    case EColores.Rojo:
                        reRojo += item.PrecioCuota;
                        break;
                    case EColores.Amarillo:
                        reAmarillo += item.PrecioCuota;
                        break;
                    case EColores.Verde:
                        reVerde += item.PrecioCuota;
                        break;
                }
            }
            txtBoxNaranja.Text = reNaranja.ToString();
            txtBoxRojo.Text = reRojo.ToString();
            txtBoxAmarillo.Text = reAmarillo.ToString();
            txtBoxVerde.Text = reVerde.ToString();
        }
    }
}
