﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origen2024.Shared.DTO
{
    public class CrearUsuarioDTO
    {

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [MaxLength(20, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatorio.")]
        [MaxLength(8, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "El mail es obligatorio.")]
        [MaxLength(45, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Mail { get; set; }
    }
}
