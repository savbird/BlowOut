using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int instrumentID { get; set; }
        [Display(Name = "Instrument Description")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        [Required]
        public String instrumentDescription { get; set; }
        [Display(Name = "Type (New or Used)")]
        [StringLength(1, ErrorMessage = "Cannot exceed 1 character")]
        [Required]
        public String type { get; set; }
        [Display(Name = "Price")]
        [Required]
        public int price { get; set; }
        [Display(Name = "Customer")]
        public int customerID { get; set; }
    }
}