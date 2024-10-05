// 2023-1211/GilbertoHernandez
// Clase Tardanza para representar los datos de un registro de tardanza de estudiantes.

using System;

namespace RegistroTardanzas.Shared
{
    // Modelo de datos para la tardanza de un estudiante.
    public class Tardanza
    {
        public string Matricula { get; set; }  // Número de matrícula del estudiante.
        public string Nombre { get; set; }     // Nombre del estudiante.
        public string Apellido { get; set; }   // Apellido del estudiante.
        public string Curso { get; set; }      // Curso del estudiante.
        public string Motivo { get; set; }     // Motivo de la tardanza.
        public DateTime FechaHora { get; set; } // Fecha y hora en que se registró la tardanza.
    }
}

