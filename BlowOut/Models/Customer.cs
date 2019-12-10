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
        public int Client_ID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        [Required]
        public string First_Name { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        [Required]
        public string Last_Name { get; set; }

        [Display(Name = "Address Line 1")]
        [StringLength(50, ErrorMessage = "Cannot exceed 30 characters")]
        public string Address_1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(15, ErrorMessage = "Cannot exceed 15 characters")]
        public string Address_2 { get; set; }

        [Display(Name = "City")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        public string City { get; set; }

        [Display(Name = "State")]
        [StringLength(15, ErrorMessage = "Cannot exceed 15 characters")]
        public string State { get; set; }

        [Display(Name = "Zipcode")]
        [StringLength(5, ErrorMessage = "Cannot exceed 5 characters")]
        public string Zipcode { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^[0-9]{0,15}$", ErrorMessage = "Phone number should contain only numbers")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        public string Phone { get; set; }
    }
}