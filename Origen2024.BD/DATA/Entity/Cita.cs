using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origen2024.BD.DATA.Entity
{
    [Index(nameof(Fecha), Name = "Cita_UQ", IsUnique = true)]
    public class Cita : EntityBase
    {
        [Required(ErrorMessage = "La fecha es obligatorio.")]
        [MaxLength(10, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public int Fecha { get; set; }

        [Required(ErrorMessage = "La hora es obligatorio.")]
        [MaxLength(5, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public int Hora { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public int Motivo { get; set; }

        [Required(ErrorMessage = "El lugar es obligatorio.")]
        [MaxLength(45, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public int Lugar { get; set; }

        [Required(ErrorMessage = "El usuario es obligatorio.")]

        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public int Id { get; set; }



    }
}
