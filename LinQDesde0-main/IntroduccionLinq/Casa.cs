using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase Casa, que representa una casa con diferentes propiedades
    public class Casa
    {
        // Propiedad para almacenar el Id único de la casa
        public int Id {  get; set; }

        // Propiedad para almacenar la dirección de la casa
        public string Direccion { get; set;}

        // Propiedad para almacenar la ciudad donde está ubicada la casa
        public string Ciudad { get; set;}

        // Propiedad que indica el número de habitaciones de la casa
        public int numeroHabitaciones {  get; set;}

        // Método que devuelve una cadena con los datos de la casa formateados
        public string dameDatosCasa () {

            // Retorna una cadena que incluye la dirección, la ciudad y el número de habitaciones
            return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}"; 
        }

    }
}
