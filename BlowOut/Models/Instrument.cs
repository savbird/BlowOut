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
        public int Instrument_ID { get; set; }
        [Display(Name = "Instrument Description")]
        [StringLength(30, ErrorMessage = "Cannot exceed 30 characters")]
        [Required]
        public String Instrument_Description { get; set; }
        [Display(Name = "Type (New or Used)")]
        [StringLength(5, ErrorMessage = "Cannot exceed 1 character")]
        [Required]
        public String Type { get; set; }
        [Display(Name = "Price")]
        [Required]
        public int Price { get; set; }
        [Display(Name = "Customer")]
        public int? Client_ID { get; set; }
    }
}