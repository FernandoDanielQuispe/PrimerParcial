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
    public partial class FrmBuscarAlumno : Form
    {
        private List<Alumno> listPorApellidos;
        private List<Alumno> listAux;
        string apellidos;

        public FrmBuscarAlumno(List<Alumno> listAlumnos)
        {
            InitializeComponent();
            this.listPorApellidos = listAlumnos;
        }  
        /// <summary>
        /// se busca al alumno por apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            apellidos = txtBoxApellido.Text;
            int aux = 0;
            foreach (Alumno item in listPorApellidos)
            {
                if (item.Apellido == apellidos)
                {
                    aux++;
                    listAux.Add(item);
                }
            }
            if (aux == 0)
                MessageBox.Show("No se encontro el Apellido");
            else
            {
                listViewApellido.Items.Clear();
                foreach (Alumno item in listAux)
                {
                    ListViewItem list = new ListViewItem(item.Apellido);
                    list.SubItems.Add(item.Nombre);
                    list.SubItems.Add(item.Legajo.ToString());
                    list.SubItems.Add(item.ColorSala.ToString());
                    list.SubItems.Add("$" + item.PrecioCuota.ToString());
                    listViewApellido.Items.Add(list);
                }
                listAux.Clear();
            }
        }
        private void FrmBuscarAlumno_Load(object sender, EventArgs e)
        {
            listAux = new List<Alumno>();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
