using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsable : Persona
    {
        /// <summary>
        /// atributos
        /// </summary>
        private EParentesco parentesco;
        private string telefono;

        #region PROPIEDADES
        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        protected EParentesco Parentesco
        {
            get 
            {
                return this.parentesco;
            }
            set 
            {
                this.parentesco = value;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        protected string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }
        #endregion

        #region METODOS  
        /// <summary>
        /// constructor con sus datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="parentesco"></param>
        /// <param name="telefono"></param>
        public Responsable(string nombre, string apellido, int dni, EParentesco parentesco, string telefono)
            : base(nombre, apellido, dni)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }

        /// <summary>
        /// datos para ser llamados desde otras clases
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} {2} {3} {4}", this.Nombre, this.Apellido, this.Dni, this.parentesco, this.telefono);

            return sb.ToString();
        }        
        #endregion

    }
}
