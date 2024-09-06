using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase Habitante que representa a una persona que vive en una casa
    public class Habitante
    {

        // Propiedad para almacenar el identificador único del habitante
        public int IdHabitante {get;set;}

        // Propiedad para almacenar el nombre del habitante
        public string Nombre {get; set;}

        // Propiedad que guarda la edad del habitante
        public int Edad {get; set;}

        // Propiedad que almacena el Id de la casa en la que vive el habitante
        public int IdCasa { get; set;}

        // Método que devuelve una cadena con los datos formateados del habitante
        public string datosHabitante() {

            // Retorna una cadena con el nombre, edad y la referencia a la casa (IdCasa)
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}
