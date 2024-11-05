using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origen2024.BD.DATA.Entity
{
    [Index(nameof(Codigo), Name = "CDocumento_UQ", IsUnique = true)]
    public class CDocumento : EntityBase
    {
        [Required(ErrorMessage = "El codigo de clase de documento es obligatorio.")]
        [MaxLength(4, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre de la clase de documento es obligatorio.")]
        [MaxLength(100, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Nombre { get; set; }

        
    }
}
