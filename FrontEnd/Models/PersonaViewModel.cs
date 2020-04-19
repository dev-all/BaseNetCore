using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class PersonaViewModel
    {
        
        public int Id { get; set; } 

      
        [DisplayName("Documento")]
        public string Documento { get; set; }

        [DisplayName("tipo Documento")]
        public int TipoDocumento { get; set; }

       
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

       
        [DisplayName("Apellido")]
        public string Apellido { get; set; }

        [DisplayName("Nombre y Apellido")]
        public string NombreApellido { get; set; }

        public bool Activo { get; set; }

       
        [DisplayName("fecha Creacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? FechaCreacion { get; set; }

    }

   
}
