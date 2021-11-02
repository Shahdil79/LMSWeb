using LMSApi.Models.ViewModel;
using LMSService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LMSApi.Controllers
{
    [RoutePrefix("api/Book")]
    public class BookController : ApiController
    {
        BookService service = new BookService();
        [Route("GetBooks")]
        public ApiResponse GetBooks()
        {
            var books = service.GetBooks();
            return new ApiResponse { StatusCode = 0, StatusMessage = "Success", Response = books };
        }
    }
}
