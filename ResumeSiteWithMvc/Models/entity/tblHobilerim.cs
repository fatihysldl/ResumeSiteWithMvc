//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResumeSiteWithMvc.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblHobilerim
    {
        public int ıd { get; set; }
        
        
        [Required(ErrorMessage = "Lürfen Bu Alanı Doldurunuz..")]
        public string hobi { get; set; }

    }
}
