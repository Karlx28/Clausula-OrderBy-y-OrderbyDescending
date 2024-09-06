using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // La clase Medico hereda de la clase Empleado, indicando que un médico es un tipo de empleado
    public class Medico : Empleado
    {
        // Propiedad para almacenar el nombre del médico, que vuelve a definirse aquí
        public string nombre { get; set; }
    }
}