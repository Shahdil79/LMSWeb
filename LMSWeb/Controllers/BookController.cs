using LMSService;
using LMSService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMSWeb.Controllers
{
    public class BookController : Controller
    {
        BookService service = new BookService();
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetBooksByLinq()
        {
            var model = service.GetBooks();
            return View(model);
        }
        public ActionResult GetBooksBySP()
        {
            var model = service.GetBooksBySP();
            return View(model);
        }
    }
}