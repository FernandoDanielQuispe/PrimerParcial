using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        /// <summary>
        /// atributos
        /// </summary>
        private string apellido;
        private int dni;
        private bool femenino;
        private string nombre;

        /// <summary>
        /// datos de Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        protected Persona(string nombre, string apellido, int dni)            
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }       

        /// <summary>
        /// datos de persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        protected Persona(string nombre, string apellido, int dni, bool femenino)  
            :this(nombre, apellido, dni)
        {
            this.femenino = femenino;
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set 
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public bool Femenino
        {
            get
            {
                return this.femenino;
            }
            set
            {
                this.femenino = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }       
    }
}
