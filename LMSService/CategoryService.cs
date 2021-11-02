using LMSService.Context;
using LMSService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSService
{
    public class CategoryService
    {
        LibraryContext context = new LibraryContext();
        public List<Category> GetCategoryBySubCat(int subCatId)
        {
            List<Category> lstCategory = new List<Category>();
            if (subCatId != 0)
            {
                int CatId = context.Categories.Where(x => x.categoryId == subCatId).FirstOrDefault().parentId;
                lstCategory = context.Categories.Where(x => x.categoryId == CatId).ToList();
            }
            else
            {
                lstCategory = context.Categories.Where(x => x.parentId == 0).ToList();
            }
            return lstCategory;
        }
        public List<Category> GetSubCategoryByCat(int catId)
        {
            List<Category> lstSubCategory = new List<Category>();
            if (catId != 0)
            {
                lstSubCategory = context.Categories.Where(x => x.parentId == catId).ToList();
            }
            else
            {
                lstSubCategory = context.Categories.Where(x => x.parentId != 0).ToList();
            }
            return lstSubCategory;
        }
    }
}
