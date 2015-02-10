using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudDemo.Models
{

    public class Product
    {
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "Namn måste anges")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Namnet måste vara 3-50 tkn")]
        [DisplayName("Namn")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Beskrivning måste anges")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Beskrivning måste vara 3-200 tkn")]
        [DisplayName("Beskrivning")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pris måste anges")]
        [DisplayName("Pris")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Leverantörens namn måste anges")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Leverantörens namn måste vara 2-50 tkn")]
        [DisplayName("Leverantör")]
        public string Supplier { get; set; }


        public Product()
        {
            ProductId = Guid.NewGuid();
        }
    }
}



