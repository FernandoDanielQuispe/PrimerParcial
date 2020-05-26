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
    public partial class FrmSueldoNoDocente : Form
    {
        private List<Administrativo> administrativos;
        public FrmSueldoNoDocente(List<Administrativo> listNoDocente)
        {
            InitializeComponent();
            this.administrativos = listNoDocente;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// muestra el total de los suledos administrativos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSueldoNoDocente_Load(object sender, EventArgs e)
        {  
            double sueldoNoDocente = 0;
            foreach (Administrativo item in this.administrativos)
            {
                sueldoNoDocente += item.Salario;
            }            
            txtBoxNoDocente.Text = sueldoNoDocente.ToString();
        }
    }
}
