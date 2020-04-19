using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Contracts.Entities
{
    public class Persona
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
