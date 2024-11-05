using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origen2024.BD.DATA.Entity
{
    [Index(nameof(CDocumentoID), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]
    
    public class Persona : EntityBase
    {

        [Required(ErrorMessage = "El numero de documento es obligatorio.")]
        [MaxLength(12, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string NumDoc { get; set; }

        [Required(ErrorMessage = "El nombre de la persona es obligatorio.")]
        [MaxLength(100, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido de la persona es obligatorio.")]
        [MaxLength(100, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La direccion de la persona es obligatorio.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El telefono de la persona es obligatorio.")]
        [MaxLength(20, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La clase de documento es obligatorio.")]
        public int CDocumentoID { get; set; }
        public CDocumento CDocumento { get; set; }

        public List<Persona> Personas { get; set; }
    }
}
