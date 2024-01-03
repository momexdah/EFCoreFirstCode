﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEFCore.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //[RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6 }$", ErrorMessage = "Ingrese un email válido")]
        [EmailAddress(ErrorMessage = "Por favor ingrese un email válido")]
        public string? Email { get; set; }
        [Display(Name = "Dirección del usuario")]
        public string Direccion { get; set; }
        [NotMapped]
        public int Edad { get; set; }
    }
}
