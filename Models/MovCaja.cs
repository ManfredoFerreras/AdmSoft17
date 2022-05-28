using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AdmSoft.Models
{
    public class MovCaja
    {
        [Key]
        public int MovcajaId { set; get; }

        [Required]
        public DateTime Fecha { set; get; }

        [Required]
        public TipoMovcaja Tipo { set; get; }

        [Required]
        public TipoPago TipoPago { set; get; }

        [Required]
        public int Recibo { set; get; }

        [Required]
        public decimal Importe { set; get; }

        [Required]
        public string Concepto { set; get; }

        public string Comentario { set; get; }

        [Required]
        public int CuadreId { set; get; }

        public virtual Cuadre Cuadre { set;   get; }

    }


    public enum TipoMovcaja
    {
        Pago,
        Gasto,
    }

}
