using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MantenimientoDeEquipos.Models.Dto
{
    public class Computador
    {

        public int Id_Computador { get; set; }
        public int Id_Funcionario { get; set; }
        public int Id_TipoComputador{ get; set; }

        [StringLength(50)]
        [Display(Name = "Serial")]
        [Required]
        public string Serial { get; set; }

        [StringLength(60)]
        [Display(Name = "Ciudad")]
        [Required]
        public string Ciudad { get; set; }

        [StringLength(60)]
        [Display(Name = "Marca")]
        [Required]
        public string Marca { get; set; }

        [StringLength(60)]
        [Display(Name = "Modelo")]
        [Required]
        public string Modelo { get; set; }

        [StringLength(60)]
        [Display(Name = "Procesador")]
        [Required]
        public string Procesador { get; set; }

        [StringLength(60)]
        [Display(Name = "MemoriaRAM")]
        [Required]
        public string MemoriaRam { get; set; }

        [StringLength(60)]
        [Display(Name = "Disco Duro")]
        [Required]
        public string DiscoDuro { get; set; }

        [StringLength(60)]
        [Display(Name = "Sistema Operativo")]
        [Required]
        public string SistemaOperativo { get; set; }

        [StringLength(60)]
        [Display(Name = "Estado")]
        [Required]
        public bool Estado { get; set; }

        /*Ayudas*/

        [Display(Name = "Nombre del funcionario")]
        public string nombreFuncionario { get; set; }

        [Display(Name = "Tipo de computador")]
        public string TipoComputador { get; set; }

    }
}