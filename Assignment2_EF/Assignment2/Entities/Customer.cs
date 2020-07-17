using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public string Cid { get; set; }
        public string Cname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
