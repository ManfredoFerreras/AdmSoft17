using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmSoft.Models
{
    public class Recibos
    {
        [Key]
        [Display(Name="Recibo Id")]
        public int ReciboId { set; get; }

        [Required]
        public DateTime Fecha { set; get; }

        [Required]
        [MaxLength(6)]
        public string Periodo { set; get; }

        [Required]
        public string Concepto { set; get; }

        [Required]
        public decimal Importe { set; get; }

        [Required]
        public decimal ImportePagado { set; get; }

        [Required]
        public bool Pago { set; get; }

        [Required]
        public int AptoId { set; get; }

        public string Comentario { set; get; }

        public bool Anulado { set; get; }

        public virtual Aptos Aptos { set; get; }

    
    }
}
