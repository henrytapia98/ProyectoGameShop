using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameShopBlazor.Models
{
    public class DisplaySalesModel
    {
        public string Game_Category { get; set; }

        public string Brand_Name { get; set; }

        public string Product_Category { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name is too long")]
        [MinLength(3, ErrorMessage = "Name is too short.")]
        public string Product_Name { get; set; }

        [Required]
        [MinLength(0, ErrorMessage = "Price is invalid.")]
        public string Price { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Nombre is too long")]
        [MinLength(3, ErrorMessage ="Nombre is to short")]
        public string First_Name { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Apellido is too long")]
        [MinLength(3, ErrorMessage = "Apellido is to short")]
        public string Last_Name { get; set; }

        [Required]
        [MinLength(0, ErrorMessage ="La cantidad no puede ser 0")]
        public string Quantity { get; set; }
    }
}
