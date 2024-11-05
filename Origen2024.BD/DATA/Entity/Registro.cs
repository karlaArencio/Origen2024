using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origen2024.BD.DATA.Entity
{
    [Index(nameof(Codigo), Name = " Registro_UQ", IsUnique = true)]
    public class Registro : EntityBase
    {
        [Required(ErrorMessage = "El codigo es obligatorio.")]
        [MaxLength(4, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "La fecha es obligatorio.")]
        [MaxLength(10, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio.")]
        [MaxLength(20, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Estado { get; set; }


        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        public List<Cita> Citas { get; set; }
        public List<Usuario> Usuarios { get; set; }






    }
}
