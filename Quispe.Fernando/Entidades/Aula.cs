using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        /// <summary>
        /// atributos
        /// </summary>
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno turno;

        #region PROPIEDADES
        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public EColores ColorSala
        {
            get
            {
                return this.colorSala;
            }
            set
            {
                this.colorSala = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public Docente Docente
        {
            get
            {
                return this.docente;
            }
            set
            {
                this.docente = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public ETurno Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                this.turno = value;
            }
        }
        #endregion


        #region METODOS
        /// <summary>
        /// datos del metodo
        /// </summary>
        public Aula()
        {
            alumnos = new List<Alumno>();
        }

        /// <summary>
        /// metodos con los datos a utilizar
        /// </summary>
        /// <param name="colorSala"></param>
        /// <param name="turno"></param>
        /// <param name="docente"></param>
        public Aula(EColores colorSala, ETurno turno, Docente docente)
            :this()
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }
        
        /// <summary>
        /// sobrecarga del operador +
        /// </summary>
        /// <param name="au"></param>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public static bool operator +(Aula au, Alumno alumno)
        {
           
            if (au.alumnos.Count < 30)
            {
                foreach (Alumno a in au.alumnos)
                {
                    if (a == alumno)
                        return false;
                    
                }
                au.alumnos.Add(alumno);
                return true;
                
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// datos para ser llamados desde otras clases
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} {2}", this.colorSala, this.docente, this.turno);

            return sb.ToString();
        }
        #endregion
    }
}
