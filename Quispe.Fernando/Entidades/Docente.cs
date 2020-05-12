using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        /// <summary>
        /// atributos
        /// </summary>
        private double valorHora;

        #region PROPIEDADES
        /// <summary>
        /// get de la propiedad
        /// </summary>
        public int HorasMensuales
        {
            get
            {
                var horas = HoraSalida - HoraEntrada;
                return horas.Hours * 20;
            }
        }

        /// <summary>
        /// get y set de la propiedad
        /// </summary>
        public double ValorHora
        {
            get
            {
                return this.valorHora;
            }
            set
            {
                this.valorHora = value;
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// calculo del salario
        /// </summary>
        /// <returns></returns>
        protected override double CalcularSalario()
        {
            double salario;
            int horasDiarias = HoraSalida.Hour - HoraEntrada.Hour;

            salario = ValorHora * horasDiarias * 20;

            return salario;
        }

       /// <summary>
       /// constructor con sus datos
       /// </summary>
       /// <param name="nombre"></param>
       /// <param name="apellido"></param>
       /// <param name="dni"></param>
       /// <param name="femenino"></param>
       /// <param name="horaEntrada"></param>
       /// <param name="horaSalida"></param>
       /// <param name="valorHora"></param>
        public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora)
        : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.valorHora = valorHora;
        }

        /// <summary>
        /// datos para ser llamados desde otras clases
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} {2} {3} {4}", this.Nombre, this.Apellido, this.Dni, this.Femenino, this.HoraEntrada, this.HoraSalida);

            return sb.ToString();
        }
        #endregion
    }
}
