using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModelsDemo.Models;

namespace ViewModelsDemo.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}

