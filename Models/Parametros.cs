using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmSoft.Models
{
    public class Parametros
    {

        [Key]
        [Display(Name = "Id")]
        public int ParametroId { set; get; }

        [Required]
        public string Parametro { set; get; }

        public string Valor { set; get; }

        public bool Activo { set; get; }


    }
}
