using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        /// <summary>
        /// atributos
        /// </summary>
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;

        #region PROPIEDADES
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
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public float PrecioCuota
        {
            get
            {
                return this.precioCuota;
            }
            set
            {
                this.precioCuota = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
            set
            {
                this.responsable = value;
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// constructor con la informacion de los datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="colorSala"></param>
        /// <param name="legajo"></param>
        /// <param name="precioCuota"></param>
        /// <param name="responsable"></param>
        public Alumno(string nombre, string apellido, int dni, bool femenino, EColores colorSala, int legajo, float precioCuota, Responsable responsable)
            : base(nombre, apellido, dni, femenino)
        {
            this.colorSala = colorSala;
            this.legajo = legajo;
            this.precioCuota = precioCuota;
            this.responsable = responsable;
        }

        /// <summary>
        /// sobrecarga del operador
        /// </summary>
        /// <param name="a1"></param>
        public static implicit operator Responsable(Alumno a)
        {            
            return a.responsable;
        }

        /// <summary>
        /// sobrecarga del operador
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator == (Alumno a1, Alumno a2)
        {
            //return a1.legajo == a2.legajo;
            if (!(a1 is null))
            {
                return a1.legajo == a2.legajo;
            }
            return false;

        }

        /// <summary>
        /// sobrecarga del operador 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        /// <summary>
        /// datos para ser llamados desde otras clases
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} {2} {3} {4}", this.Nombre, this.Apellido, this.Dni, this.Femenino, this.legajo);

            return sb.ToString();                        
        }
        #endregion
    }
}
