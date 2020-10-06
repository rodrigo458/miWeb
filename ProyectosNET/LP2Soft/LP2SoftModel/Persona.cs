using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftModel
{
    public abstract class Persona
    {
        private int _idPersona;
        private string _nombre;
        private string _apellidoPaterno;
        private string _DNI;
        private DateTime _fechaNacimiento;
        private char _genero;

        protected Persona()
        {
        }

        public Persona(string nombre, string apellidoPaterno, string dNI, DateTime fechaNacimiento, char genero)
        {
            _nombre = nombre;
            _apellidoPaterno = apellidoPaterno;
            _DNI = dNI;
            _fechaNacimiento = fechaNacimiento;
            _genero = genero;
        }

        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public char Genero { get => _genero; set => _genero = value; }
    }
}
