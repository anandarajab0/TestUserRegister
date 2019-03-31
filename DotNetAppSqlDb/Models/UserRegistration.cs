using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
   
    public class UserRegistration
    {
        [Display(Name = "No")]
        public int ID { get; set; }

        [Required]
        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid Name")]
        [Display(Name = "Name")]
        public string Description { get; set; }

        [Required]
        //[RegularExpression("^([A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,3})$", ErrorMessage = "Invalid Email")]        
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }

        [Display(Name = "Selected Days")]
        [Required]
        public string SelectedDays { get; set; }
        

        [Display(Name = "Add request")]
        public string AddRequest { get; set; }

        [Display(Name = "Date Registration")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        

    }


}