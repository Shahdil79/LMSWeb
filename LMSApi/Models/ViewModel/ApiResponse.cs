using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSApi.Models.ViewModel
{
    public enum StatusCode
    {
        Success = 0,
        Failed = 1,
        Error = 2

    }
    public class ApiResponse
    {
        public StatusCode StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public object Response { get; set; }
    }
}