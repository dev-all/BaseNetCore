using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreApellido { get; set; }
        public int Documento { get; set; }
        public Boolean Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
