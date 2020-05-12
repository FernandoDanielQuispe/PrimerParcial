using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        /// <summary>
        /// atributos de personal
        /// </summary>
        private DateTime horaEntrada;
        private DateTime horaSalida;

        #region PROPIEDADES
        /// <summary>
        /// propiedad de datetime para la hora de entrada
        /// para su uso: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.hour?view=netcore-3.1
        /// </summary>
        public DateTime HoraEntrada
        {
            get
            {
                return this.horaEntrada;
            }
            set
            {
                this.horaEntrada = value;
            }
        }

        /// <summary>
        /// propiedad de datetime para la hora de salida
        /// </summary>
        public DateTime HoraSalida
        {
            get
            {
                return this.horaSalida;
            }
            set
            {
                this.horaSalida = value;
            }
        }

        /// <summary>
        /// propiedad del salario
        /// </summary>
        public double Salario
        {
            get;     
        }

        #endregion

        #region METODOS
        /// <summary>
        /// metodo de calcularsalario
        /// </summary>
        /// <returns></returns>
        protected abstract double CalcularSalario();

        /// <summary>
        /// Se ingresan los datos de personal
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida)
        : base(nombre, apellido, dni, femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }
        #endregion
    }
}
