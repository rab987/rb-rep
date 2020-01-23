using DTApiLoadCounter.Domain.Services;
using DTApiLoadCounter.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace DTApiLoadCounter.WebApi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/drivers")]
    [ApiController]
    public class DailyJobDriversController : ControllerBase
    {
        private readonly HttpRequest request;
        private IDailyJobDriversService DailyJobDriversService;

        public DailyJobDriversController(IDailyJobDriversService service)
        {
            this.DailyJobDriversService = service;
        }

        [ResponseType(typeof(IEnumerable<LoadCounterDriverDTO>))]
        [HttpGet("{JobId}")]
        public IActionResult GetDailyJobDrivers(int JobId)
        {
            try
            {
                 IEnumerable<LoadCounterDriverDTO> responseList = this.DailyJobDriversService.GetDailyJobDrivers(JobId);

                if (responseList == null)
                {
                    return new DTApiContentActionResult(new Exception("No Drivers Found!"), HttpStatusCode.NotFound, "", responseList, Request);
                }
                else
                {
                    return new DTApiContentActionResult(null, HttpStatusCode.OK, "", responseList, request);
                }
            }
            catch (Exception e)
            {
                return new DTApiContentActionResult(e, HttpStatusCode.BadRequest, "", null, Request);
            }

        }
    }
}
