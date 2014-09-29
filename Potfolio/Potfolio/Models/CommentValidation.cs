using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Potfolio.Models
{
    [MetadataType(typeof(CommentValidation))]
    public class CommentValidation
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public Int32 PhoneNumber { get; set; }
        [Required]
        public string Comment1 { get; set; }
    }
}