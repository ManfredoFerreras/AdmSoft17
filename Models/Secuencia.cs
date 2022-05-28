using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmSoft.Models
{
    public class Secuencia
    {
        [Key]
        public int SecuenciaId { set; get; }

        [Required]
        public string SecCodigo { set; get; }

        public int SecValue { set; get; }
    }
}
