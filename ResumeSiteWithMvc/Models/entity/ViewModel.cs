using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResumeSiteWithMvc.Models.entity;
namespace ResumeSiteWithMvc.Models.entity
{
    public class ViewModel
    {
        public List<tblProgramlamaDilleri> programlamaDilleri { get; set; }
        public List<tblFramework> frameworkler { get; set; }
        public List<tblVeriTabani> VeriTabaniYonetimSistemleri { get; set; }
        public List<tblIde> Ideler{ get; set; }
    }
}