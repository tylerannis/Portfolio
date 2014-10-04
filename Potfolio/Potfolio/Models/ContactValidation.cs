using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Potfolio.Models
{
    [MetadataType(typeof(ContactValidation))]
    public partial class ContactMe
    {
    }
    public class ContactValidation
    {
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        
        public Nullable<int> Phone { get; set; }
        [Required]
        public string Comment { get; set; }
    }

    }
