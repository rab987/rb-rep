using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DTApiLoadCounter.WebApi
{
    public class DataResult
    {
        public Exception Exception { get; set; }
        public object Data { get; set; }
    }
    public class DTApiContentActionResult : IActionResult
    {
        private readonly int statusCode;
        DataResult _result = new DataResult();
        object _data;
        private readonly HttpRequest _request;

        public DTApiContentActionResult(Exception ex, HttpStatusCode statusCode, string responseMessage, object data, HttpRequest request)
        {
            this.statusCode = (int)statusCode;
            this._request = request;
            _result.Data = data;
            _result.Exception = ex;

        }
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(_result.Exception ?? _result.Data)
            {
                StatusCode = _result.Exception != null
                    ? statusCode
                    : StatusCodes.Status200OK
            };
            await objectResult.ExecuteResultAsync(context);
        }
        public int StatusCode
        {
            get
            {
                return this.statusCode;
            }
        }
    }
}
