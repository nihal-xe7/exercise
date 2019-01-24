using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise.Models
{
    public class MemberShip
    {
        [Key]
        public int Id { get; set; }

        public bool IsSubscribed { set; get; }

        public int SignUpFee { set; get; }
        public int Discount { set; get; }

        public string AcountType { get; set; }

        

        
    }
}