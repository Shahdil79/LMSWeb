using LMSService;
using LMSWeb.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMSWeb.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService service = new CategoryService();
        // GET: Category
        public ActionResult Index()
        {
            CatAndSubCat model = new CatAndSubCat();
            model.Category = service.GetCategoryBySubCat(0);
            model.SubCategory = service.GetSubCategoryByCat(1);
            return View(model);
        }

        public JsonResult FillCategory(int Id)
        {
            var category = service.GetCategoryBySubCat(Id);
            return Json(category,JsonRequestBehavior.AllowGet);
        }
        public JsonResult FillSubCategory(int Id)
        {
            var subCategory = service.GetSubCategoryByCat(Id);
            return Json(subCategory, JsonRequestBehavior.AllowGet);
        }
    }
}