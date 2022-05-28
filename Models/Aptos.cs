using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AdmSoft.Models
{
    public class Aptos
    {
        [Key]
        [Display(Name="Id")]
        public int AptoId { set; get; }

        [Required]
        [MaxLength(10)]
        public string AptoCode { set; get; }

        public string AptoContact { set; get; }
        public string AptoDoc { set; get; }
        public string AptoEmail { set; get; }
        public string AptoPhone {set; get;}

        [Required]
        public bool isRented { set; get; }

        public decimal Cuota { set; get; }

        public decimal Deuda { set; get; }

        [MaxLength(500)]
        public string Comment { set; get; }

        
        public bool Activo { set; get; }



    }
}
