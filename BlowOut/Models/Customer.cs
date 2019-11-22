using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int customerID { get; set; }
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        [Required]
        public String firstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        [Required]
        public String lastName { get; set; }
        [Display(Name = "Address Line 1")]
        [StringLength(50, ErrorMessage = "Cannot exceed 30 characters")]
        public String address1 { get; set; }
        [Display(Name = "Address Line 2")]
        [StringLength(15, ErrorMessage = "Cannot exceed 15 characters")]
        public String address2 { get; set; }
        [Display(Name = "City")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        public String city { get; set; }
        [Display(Name = "State")]
        [StringLength(15, ErrorMessage = "Cannot exceed 15 characters")]
        public String state { get; set; }
        [Display(Name = "Zipcode")]
        [StringLength(5, ErrorMessage = "Cannot exceed 5 characters")]
        public String zip { get; set; }
        [Display(Name = "Email Address")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        public String email { get; set; }
        [Display(Name = "Phone Number")]
        public string phone { get; set; }
    }
}