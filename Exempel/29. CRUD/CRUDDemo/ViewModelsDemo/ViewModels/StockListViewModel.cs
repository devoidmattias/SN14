using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ViewModelsDemo.ViewModels
{
    public class StockListViewModel
    {
        [Key]
        public Guid ProductId { get; set; }

        [DisplayName("Produktnamn")]
        public string Name { get; set; }
        
        [DisplayName("Kategori")]
        public string Category { get; set; }

        [DisplayName("Leverantör")]
        public string Supplier { get; set; }

        [DisplayName("Lagersaldo")]
        public int StockCount { get; set; }

        [DisplayName("Utpris")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SalesPrice { get; set; }

        [DisplayName("Inpris")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PurchasePrice { get; set; }

        [DisplayName("Marginal")]
        [DisplayFormat(DataFormatString = "{0:P}", ApplyFormatInEditMode = true)]
        public double Margin { get; set; }
    }
}
