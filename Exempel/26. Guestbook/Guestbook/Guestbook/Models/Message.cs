using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Guestbook.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        [Required(ErrorMessage = "Please enter a header")]
        public string Header { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your emailadress")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email adress")]
        public string Email { get; set; }

    }
}

