using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmSoft.Models
{
    public class Pagos
    {
        [Key]
        public int PagoId { set; get; }

        [Required]
        public DateTime Fecha { set; get; }

        [Required]
        public int Recibo { set; get; }

        [Required]
        public TipoPago Tipo { set; get; }

        public decimal Monto { set; get; }

        public string Nombre { set; get;  }

        public string Comentario { set; get; }

         [Required]
        public bool Anulado { set; get; }

        public ICollection<PagosRecibos> PagosRecibos { set; get; }

    }


   public enum TipoPago
   {
       Efectivo,
       Cheque,
       Transferencia,
       Tarjeta
   }
}
