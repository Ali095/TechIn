﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tech_In.Models.Model;

namespace Tech_In.Models.ViewModels.ProfileViewModels
{
    public class CompleteProfileVM
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "First Name ")]
        public string FirstName { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //AspNetUsers
        public string UserID { get; set; }

        public byte[] CVImage { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Date of Birth Visibility")]
        public Boolean DOBVisibility { get; set; }

        public Gender Gender { get; set; }

        public int CityId { get; set; }
        public int CountryId { get; set; }

    }
}