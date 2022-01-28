using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MantenimientoDeEquipos.Models.Dto
{
    public class TipoComputador
    {

        public int Id_TipoComputador { get; set; }

        [Required]
        [Display(Name ="Tipo de Computador")]
        [StringLength(50)]
        public string tipoComputador { get; set; }

    }
}