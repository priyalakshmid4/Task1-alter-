using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1_alter_.Models
{
    public class Namenv
    {
        public int Id { get; set; }
        [Display(Name="Enter the Name")]
        [Required(AllowEmptyStrings =false,ErrorMessage = "Name is Required")]
        public string name1 { get; set; }
        [Display(Name = "Enter the PhoneNo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "PhoneNo is Required")]
        public int phoneno { get; set; }
        [Display(Name = "Enter the age")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "age is Required")]
        public int age { get; set; }
    }
}