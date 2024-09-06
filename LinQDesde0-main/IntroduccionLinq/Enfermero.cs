using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // La clase Enfermero hereda de la clase Empleado, indicando que un enfermero es un tipo de empleado
    public class Enfermero : Empleado
    {

        // Propiedad para almacenar el nombre del enfermero, que vuelve a definirse aquí
        public string nombre { get; set; }
    }
}
