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
using Entidades;

namespace Quispe.Fernando
{
    public partial class FrmPpal : Form
    {
        private List<Alumno> listAlumnosConAula = new List<Alumno>();
        private List<Alumno> listAlumnosSinAula = new List<Alumno>();
        private List<Docente> listDocentesConAula = new List<Docente>();
        private List<Docente> listDocentesSinAula = new List<Docente>();
        private List<Administrativo> listAdministrativo = new List<Administrativo>();
        private List<Responsable> listResponsables = new List<Responsable>();
        private List<Aula> listAulas = new List<Aula>();
        private Aula aula;
        private Aula aulaNa;
        private Aula aulaRo;
        private Aula aulaAma;
        private Aula aulaVer;

        public FrmPpal()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// carga de informacion de listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_Load(object sender, EventArgs e)
        {                      
            listAlumnosSinAula = new List<Alumno>();
            listAlumnosConAula = new List<Alumno>();
            listDocentesSinAula = new List<Docente>();
            listAdministrativo = new List<Administrativo>();
            aula = new Aula();
            aulaNa = new Aula();
            aulaRo = new Aula();
            aulaAma = new Aula();
            aulaVer = new Aula();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }   
        /// <summary>
        /// Ingreso para el alta del aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAula AltaAula = new FrmAltaAula(listAlumnosSinAula, listDocentesSinAula, aulaNa, aulaRo, aulaAma, aulaVer, listAlumnosConAula);
                      
            if (AltaAula.ShowDialog() == DialogResult.OK)
            {
                aulaNa = AltaAula.AulaNaranja;
                aulaRo = AltaAula.AulaRoja;
                aulaAma = AltaAula.AulaAmarilla;
                aulaVer = AltaAula.AulaVerde;
                listDocentesSinAula = AltaAula.Docentes;
                listAlumnosConAula = AltaAula.AlumnosEnSala;
            }
        }
        /// <summary>
        /// salir del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\Windows Logoff Sound.wav");
            sound.Play();

            this.Close();
            Application.Exit();
        }
        /// <summary>
        /// Se da de alta al docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaDocente AltaDocente = new FrmAltaDocente();                   
            AltaDocente.ShowDialog();
            if (AltaDocente.DialogResult == DialogResult.OK)
            {
                this.listDocentesSinAula.Add(AltaDocente.Docente);
            }           
        }

        /// <summary>
        /// Se da de alta el administrativo, el no docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaNoDocente AltaNoDocente = new FrmAltaNoDocente();
            AltaNoDocente.ShowDialog();
            if (AltaNoDocente.DialogResult == DialogResult.OK)
            {
                this.listAdministrativo.Add(AltaNoDocente.Administrativo);                 
            }            
        }

        /// <summary>
        /// Se da de alta un alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FrmAltaAlumno AltaAlumno = new FrmAltaAlumno();         
            if (AltaAlumno.ShowDialog() == DialogResult.OK)
            {
                if (aula + AltaAlumno.NuevoAlumno)
                {
                    this.listAlumnosSinAula = aula.Alumnos;
                    MessageBox.Show("Se ingreso en lista de espera");
                }
                else
                {
                    MessageBox.Show("El legajo ya existe");
                }
            }
        }

        /// <summary>
        /// Informacion de los padres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InformacionPadres = new FrmInformacionPadres(listAlumnosConAula);
            InformacionPadres.ShowDialog();
        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SueldoDocente = new FrmSueldoDocente(listDocentesSinAula);
            SueldoDocente.ShowDialog();
        }

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SueldoNoDocente = new FrmSueldoNoDocente(listAdministrativo);
            SueldoNoDocente.ShowDialog();
        }

        private void recaudaciónPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RecaudacionAula = new FrmRecaudacionAula(listAlumnosConAula);
            RecaudacionAula.ShowDialog();
        }

        private void recaudaciónTotalDelJardínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RecaudacionTotal = new FrmRecaudacionTotal(listAlumnosConAula);
            RecaudacionTotal.ShowDialog();
        }

        /// <summary>
        /// cargar datos desde la clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
            sound.Play();

            CargarDatos cargarDatos = new CargarDatos();
            cargarDatos.CargarInfo();
            listAlumnosSinAula = cargarDatos.listAlumnos;
            listDocentesSinAula = cargarDatos.Docentes;
            listAdministrativo = cargarDatos.Administrativo;

            DialogResult resultado = new DialogResult();
            Form mensaje = new FrmMessageBox();
            resultado = mensaje.ShowDialog();            
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarAlumno frmBuscarPorApellido = new FrmBuscarAlumno(listAlumnosConAula);
            frmBuscarPorApellido.ShowDialog();
        }

        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVideos frmVideos = new FrmVideos();
            frmVideos.ShowDialog();
        }
    }
}
