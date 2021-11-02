using LMSWeb.Models.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LMSWeb.Controllers
{
    public class ExternalController : Controller
    {
        // GET: External
        public ActionResult GetExternalApi()
        {
            ExternalApi model= new ExternalApi();
            using (var httpClient = new HttpClient())
            {
                var apiUrl = ("https://catfact.ninja/fact");

                httpClient.BaseAddress = new Uri(apiUrl);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    model = JsonConvert.DeserializeObject<ExternalApi>(data);
                }
            };

            return View(model);
        }
    }
}