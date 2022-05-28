using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmSoft.Models
{
   public  class Cuadre
    {

       [Key]
       public int CuadreId { set; get; }

       [Required]
       public DateTime Fecha { set; get;  }

       [Required]
       public decimal ImportePagos { set; get; }

       [Required]
       public decimal ImporteEfectivo { set; get; }

       [Required]
       public decimal ImporteCheque { set; get; }

       [Required]
       public decimal ImporteTarjeta { set; get; }

       [Required]
       public decimal ImporteTransferencia { set; get; }

       [Required]
       public decimal ImporteGastos { set; get; }

       [Required]
       public decimal ImporteDeposito { set; get; }

       public string  Comentario { set; get; }

       public DateTime? FechaIni { set; get; }

       public DateTime? FechaFin { set; get; }

       public virtual ICollection<MovCaja> MovCaja { set; get; }


    }
}
