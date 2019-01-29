using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using Microsoft.Ajax.Utilities;

namespace Exercise.Models
{
    public class RegisterModel
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(12)] 
        public string Password { set; get; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string DOB { get; set; }

        public string AccountType { get; set; }

        public int Discount { get; set; }

        [Required]
        public int SignUpFee { set; get; }
        [Required]
        public bool IsSubscribed { get; set; }
    }
}