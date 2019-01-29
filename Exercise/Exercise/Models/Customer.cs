using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Exercise.Models
{
    public class Customer
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(12)]
        public string Password { set; get; }

        public int MemberShipID { get; set; }

        public string DOB { get; set; }

        [NotMapped]
        public List<Customer> customers
        {
            set;
            get;
        }

        [ForeignKey("MemberShipID")]
        public virtual MemberShip MemberShip { get; set; }
    }
}