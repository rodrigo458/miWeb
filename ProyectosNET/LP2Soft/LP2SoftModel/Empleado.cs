using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftModel
{
    public class Empleado : Persona
    {
        private Area _area;
        private String _cargo;
        private double _sueldo;

        public Area Area { get => _area; set => _area = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }
    }
}
