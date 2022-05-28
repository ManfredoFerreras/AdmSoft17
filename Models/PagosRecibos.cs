using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AdmSoft.Models
{
    public class PagosRecibos
    {
        [Key]
        public int PagoRecId { set; get; }

        [Required]
        public int PagoId { set; get; }

        [Required]
        public int ReciboId { set; get; }

        public virtual Recibos Recibos { set; get; }

        public virtual Pagos Pagos { set; get; }

        public decimal ImportePagado { set; get; }

    }
}
