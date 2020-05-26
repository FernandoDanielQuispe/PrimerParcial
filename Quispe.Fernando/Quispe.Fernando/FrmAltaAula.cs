using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Quispe.Fernando
{
    public partial class FrmAltaAula : Form
    {
        List<Alumno> listAlumnosConSala;
        private Aula aNa;
        private Aula aRo;
        private Aula aAma;
        private Aula aVer;
        int indicePro = -1;
        int indexLstv = -1;
        private List<Alumno> alumnosSinAula;
        private List<Docente> docentes;      

        public FrmAltaAula(List<Alumno> alumnosSinAula, List<Docente> listDocentesSinAula, Aula aulaNa, Aula aulaRo, Aula aulaAma, Aula aulaVer, List<Alumno> listAlumnosConSala)
        
        {
            InitializeComponent();          

            this.alumnosSinAula = alumnosSinAula;
            this.aNa = aulaNa;
            this.aRo = aulaRo;
            this.aAma = aulaAma;
            this.aVer = aulaVer;
            this.docentes = listDocentesSinAula;
            this.listAlumnosConSala = listAlumnosConSala;
        }

        private void FrmAltaAula_Load(object sender, EventArgs e)
        {
            ingresarColores();
            ingresarTurno();
            

            foreach (Docente item in docentes)
            {
                ComboBoxProf.Items.Add(item.Apellido + " " + item.Nombre);
            }
         
            foreach (Alumno item in this.alumnosSinAula)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());
                listViewSinAula.Items.Add(lista);
            }
        }

        private void ingresarColores()
        {
           ComboBoxColor.Items.Clear();           
            foreach (int i in Enum.GetValues(typeof(EColores)))
            {
                ComboBoxColor.Items.Add((EColores)i);
            }
        }

        private void ingresarTurno()
        {
            ComboBoxTurno.Items.Clear();
            foreach (int i in Enum.GetValues(typeof(ETurno)))
            {
                ComboBoxTurno.Items.Add((ETurno)i);
            }                       
        }
        public List<Docente> Docentes
        {
            get
            { 
                return this.docentes;
            }
        }
        public Aula AulaNaranja 
        {
            get
            { 
                return this.aNa;
            }
        }
        public Aula AulaRoja
        {
            get
            {
                return this.aRo;
            }
        }
        public Aula AulaAmarilla
        {
            get
            {
                return this.aAma;
            } 
        }
        public Aula AulaVerde
        {
            get
            {
                return aVer;
            }
        }
        public List<Alumno> AlumnosEnSala
        {
            get
            {
                return this.listAlumnosConSala;
            }
        }
       
        private void lblColor_Click(object sender, EventArgs e)
        {            
        }
        private void lblTurno_Click(object sender, EventArgs e)
        {
        }     
        
        private void ComboBoxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void btnAsignarAlumno_Click(object sender, EventArgs e)
        {
            int indice = indexLstv;
            foreach (ListViewItem item in listViewSinAula.SelectedItems)
            {
                item.Remove();
                if (indice >= 0)
                {
                    switch (alumnosSinAula[indice].ColorSala)
                    {
                        case EColores.Naranja:
                            if (aNa + alumnosSinAula[indice])
                            {
                                listAlumnosConSala.Add(alumnosSinAula[indice]);
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewNaranja();

                                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                                sound.Play();

                                DialogResult resultado = new DialogResult();
                                Form mensaje = new FrmMessageBoxAsignacion();
                                resultado = mensaje.ShowDialog();                                
                                
                                this.Close();
                            }
                            else 
                            {
                                MessageBox.Show("Legajo existente/Supera los 30 Alumnos");
                            }
                            break;

                        case EColores.Rojo:
                            if (aRo + alumnosSinAula[indice])
                            {
                                listAlumnosConSala.Add(alumnosSinAula[indice]);
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewRojo();

                                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                                sound.Play();

                                DialogResult resultado = new DialogResult();
                                Form mensaje = new FrmMessageBoxAsignacion();
                                resultado = mensaje.ShowDialog();

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Legajo existente/Supera los 30 Alumnos"); 
                            }
                            break;

                        case EColores.Amarillo:
                            if (aAma + alumnosSinAula[indice])
                            {
                                listAlumnosConSala.Add(alumnosSinAula[indice]);
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewAmarillo();

                                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                                sound.Play();

                                DialogResult resultado = new DialogResult();
                                Form mensaje = new FrmMessageBoxAsignacion();
                                resultado = mensaje.ShowDialog();

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Legajo existente/Supera los 30 Alumnos"); 
                            }
                            break;

                        case EColores.Verde:
                            if (aVer + alumnosSinAula[indice])
                            {
                                listAlumnosConSala.Add(alumnosSinAula[indice]);
                                alumnosSinAula.RemoveAt(indice);
                                CargarListViewVerde();

                                SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                                sound.Play();

                                DialogResult resultado = new DialogResult();
                                Form mensaje = new FrmMessageBoxAsignacion();
                                resultado = mensaje.ShowDialog();

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Legajo existente/Supera los 30 Alumnos"); 
                            }
                            break;
                    }
                }
            }
        }

        #region combobox color
        private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxColor.Text)
            {
                case "Naranja":
                    BackColor = Color.Orange;                    
                    listViewEnSala.Items.Clear();                         
                    if (!(aNa is null))
                    {                     
                            CargarListViewNaranja();
                    }
                    break;

                case "Rojo":
                    BackColor = Color.Red;                    
                    listViewEnSala.Items.Clear();                    
                    if (!(aRo is null))
                    {
                        CargarListViewRojo();
                    }

                    break;

                case "Amarillo":
                    BackColor = Color.Yellow;                    
                    listViewEnSala.Items.Clear();
                    if (!(aAma is null))
                    {
                        CargarListViewAmarillo();
                    }
                    break;

                case "Verde":
                    BackColor = Color.Green;;
                    listViewEnSala.Items.Clear();
                    if (!(aVer is null))
                    {
                        CargarListViewVerde();
                    }
                    break;
            }
        }
        #endregion
       /// <summary>
       /// Se asigna el profesor al aula
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ComboBoxColor.Text != "" && ComboBoxTurno.Text != "" && ComboBoxProf.Text != "")
            {
                switch (ComboBoxColor.Text)
                {
                    case "Naranja":                        
                        if (indicePro >= 0)
                        {
                            Docente aux = this.docentes[ComboBoxProf.SelectedIndex];
                            aNa = new Aula((EColores)Enum.Parse(typeof(EColores), ComboBoxColor.Text), (ETurno)Enum.Parse(typeof(ETurno), ComboBoxTurno.Text), aux);
                            this.docentes.RemoveAt(indicePro);
                            this.ComboBoxProf.Items.Remove(ComboBoxProf.Items[ComboBoxProf.SelectedIndex]);

                            SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                            sound.Play();

                            DialogResult resultado = new DialogResult();
                            Form mensaje = new FrmMessageBox();
                            resultado = mensaje.ShowDialog();                            
                        }
                        break;

                    case "Rojo":
                        if (indicePro >= 0)
                        {
                            Docente aux1 = this.docentes[ComboBoxProf.SelectedIndex];
                            aRo = new Aula((EColores)Enum.Parse(typeof(EColores), ComboBoxColor.Text), (ETurno)Enum.Parse(typeof(ETurno), ComboBoxTurno.Text), aux1);
                            this.docentes.RemoveAt(indicePro);
                            this.ComboBoxProf.Items.Remove(ComboBoxProf.Items[ComboBoxProf.SelectedIndex]);

                            SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                            sound.Play();

                            DialogResult resultado = new DialogResult();
                            Form mensaje = new FrmMessageBox();
                            resultado = mensaje.ShowDialog();
                        }
                        break;

                    case "Amarillo":
                        if (indicePro >= 0)
                        {
                            Docente aux2 = this.docentes[ComboBoxProf.SelectedIndex];
                            aAma = new Aula((EColores)Enum.Parse(typeof(EColores), ComboBoxColor.Text), (ETurno)Enum.Parse(typeof(ETurno), ComboBoxTurno.Text), aux2);
                            this.docentes.RemoveAt(indicePro);
                            this.ComboBoxProf.Items.Remove(ComboBoxProf.Items[ComboBoxProf.SelectedIndex]);

                            SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                            sound.Play();

                            DialogResult resultado = new DialogResult();
                            Form mensaje = new FrmMessageBox();
                            resultado = mensaje.ShowDialog();
                        }
                        break;

                    case "Verde":
                        if (indicePro >= 0)
                        {
                            Docente aux3 = this.docentes[ComboBoxProf.SelectedIndex];
                            aVer = new Aula((EColores)Enum.Parse(typeof(EColores), ComboBoxColor.Text), (ETurno)Enum.Parse(typeof(ETurno), ComboBoxTurno.Text), aux3);
                            this.docentes.RemoveAt(indicePro);
                            this.ComboBoxProf.Items.Remove(ComboBoxProf.Items[ComboBoxProf.SelectedIndex]);

                            SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                            sound.Play();

                            DialogResult resultado = new DialogResult();
                            Form mensaje = new FrmMessageBox();
                            resultado = mensaje.ShowDialog();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("No hay Docentes/Completar los datos"); 
            }

        }
        /// <summary>
        /// combo box del profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicePro = ComboBoxProf.SelectedIndex;
            string profesor = ComboBoxProf.Items[indicePro].ToString();
        }

        #region Carga de las listas
        private void CargarListViewNaranja()
        {
            foreach (Alumno item in aNa.Alumnos)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());
                listViewEnSala.Items.Add(lista);
            }
        }
        private void CargarListViewRojo()
        {
            foreach (Alumno item in aRo.Alumnos)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());
                listViewEnSala.Items.Add(lista);
            }
        }
        private void CargarListViewAmarillo()
        {
            foreach (Alumno item in aAma.Alumnos)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());
                listViewEnSala.Items.Add(lista);
            }
        }
        private void CargarListViewVerde()
        {
            foreach (Alumno item in aVer.Alumnos)
            {
                ListViewItem lista = new ListViewItem(item.Legajo.ToString());
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.ColorSala.ToString());
                lista.SubItems.Add(item.Femenino.ToString());
                lista.SubItems.Add("$" + item.PrecioCuota.ToString());
                listViewEnSala.Items.Add(lista);
            }
        }
        #endregion

        
        private void ComboBoxTurno_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void listViewSinAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int item in this.listViewSinAula.SelectedIndices)
            {
                indexLstv = item;
            }
        }
        private void lblAlumSinSala_Click(object sender, EventArgs e)
        {
        }
        private void listViewEnSala_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }
    }
}

