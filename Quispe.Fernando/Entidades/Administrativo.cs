using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
        /// <summary>
        /// atributos
        /// </summary>
        private ECargo cargo;
        public static double SalarioBase;

        #region PROPIEDADES
        /// <summary>
        /// get y set de la propiedad 
        /// </summary>
        public ECargo Cargo        
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }

        }
        #endregion

        #region METODOS    
        /// <summary>
        /// constructor estatico que coloca el salario en cierto numero
        /// </summary>
        static Administrativo()
        {
            SalarioBase = 30000; 
        }
        
        /// <summary>
        /// constructor donde se ingresan los datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaSalida"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="cargo"></param>
        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaSalida, DateTime horaEntrada, ECargo cargo)
            :base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.cargo = cargo;
        }

        /// <summary>
        /// se calcula el salario
        /// </summary>
        /// <returns></returns>
        protected override double CalcularSalario()
        {
            double salario;
            salario = (SalarioBase * (double)cargo )/ 100;

            return salario;
        }
        /// <summary>
        /// datos para ser llamados desde otras clases
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} {2} {3} {4} {5} {6}", this.Nombre, this.Apellido, this.Dni, this.Femenino, this.HoraEntrada, this.HoraSalida, this.cargo);

            return sb.ToString();
        }
        #endregion
    }
}
