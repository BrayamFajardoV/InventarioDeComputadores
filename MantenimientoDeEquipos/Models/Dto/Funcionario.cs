using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MantenimientoDeEquipos.Models.Dto
{
    public class Funcionario
    {
        public int Id_Funcionario { get; set; }

        [Display(Name = "Nombre del funcionario")]
        [Required]
        public string NombreCompleto { get; set; }

    }
}