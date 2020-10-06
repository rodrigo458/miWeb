using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//f
namespace LP2SoftModel
{
    public class Area
    {
        private int _idArea;
        private string _nombre;

        public Area()
        {
        }

        public Area(string nombre)
        {
            _nombre = nombre;
        }

        public int IdArea { get => _idArea; set => _idArea = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
