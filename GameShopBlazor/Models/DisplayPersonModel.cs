using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameShopBlazor.Models
{
    public class DisplayPersonModel
    {
        public string Game_Category { get; set; }
        [Required]
        public string Brand_Name { get; set; }
        [Required]
        public string Product_Category { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name is too long")]
        [MinLength(3, ErrorMessage = "Name is too short.")]
        public string Product_Name { get; set; }

        [Required]
        [MinLength(0, ErrorMessage = "Price is invalid.")]
        public string Price { get; set; }
    }
}
