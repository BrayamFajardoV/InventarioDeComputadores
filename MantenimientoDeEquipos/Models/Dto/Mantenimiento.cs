using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MantenimientoDeEquipos.Models.Dto
{
    public class Mantenimiento
    {
        
        public int Id_Mantenimiento { get; set; }

        [Display(Name ="Computador")]
        [Required]
        public int Id_Computador { get; set; }

        [Display(Name = "Ultimo Mantenimiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime UltimoMantenimiento { get; set; }

        [Display(Name = "Proximo Mantenimiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ProximoMantenimiento { get; set; }

        [Display(Name = "Observaciones")]
        [StringLength(50)]
        public string Observaciones { get; set; }

        /*AYUDAS*/
        [Display(Name = "Computador")]
        public string NombreComputador { get; set; }
    }
}