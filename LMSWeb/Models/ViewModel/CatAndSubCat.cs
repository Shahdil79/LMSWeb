using LMSService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSWeb.Models.ViewModel
{
    public class CatAndSubCat
    {
        public List<Category> Category { get; set; }
        public List<Category> SubCategory { get; set; }
    }
}