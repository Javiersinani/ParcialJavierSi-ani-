using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1.Models
{
    public class Crud
    {
        [Key]
        [StringLength(99999, MinimumLength = 1, ErrorMessage = "Ingresar nombres entre 1 a 99999 caracteres")]
        public int ProductID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Ingresar nombres entre 3 a 30 caracteres")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public float Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }

    }
}