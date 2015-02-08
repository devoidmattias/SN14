using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModelsDemo.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public Guid ProductId { get; set; }

        [DisplayName("Produktnamn")]
        public string Name { get; set; }
        [DisplayName("Beskrivning")]
        public string Description { get; set; }

        [DisplayName("Pris")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
        
        [DisplayName("Kategori")]
        public string Category { get; set; }

        [DisplayName("Leverantör")]
        public string Supplier { get; set; }
    }
}

