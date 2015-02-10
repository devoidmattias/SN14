using Demo.App_Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Models
{
    public class Appointment 
    {
        public int Id { get; set; }

        [DisplayName("Namn")]
        [Required(ErrorMessage = "Namn måste anges (3-20 tkn)")]
        [StringLength(20, MinimumLength=3)]
        [Remote("ValidateName","Appointment")]
        public string ClientName { get; set; }

        [DisplayName("Datum")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Datum måste anges")]
        public DateTime Date { get; set; }
       
        public bool TermsAccepted { get; set; }

        public int DaysUntilAppointment
        {
            get
            {
                return (Date - DateTime.Today).Days;
            }
        }    
    }
}