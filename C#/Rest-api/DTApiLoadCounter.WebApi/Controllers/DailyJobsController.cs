using DTApiLoadCounter.Domain.Services;
using DTApiLoadCounter.DTO;
using DTApiLoadCounter.WebApi.Payloads;
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
    [Microsoft.AspNetCore.Mvc.Route("api/LoadCounter/GetDailyJob")]
    [ApiController]
    public class DailyJobsController : ControllerBase
    {
        private readonly HttpRequest request;
        private IDailyJobService DailyJobService;
        private LoadCounterDailyJobDTO response;
        private IEnumerable<LoadCounterDailyJobDTO> responseList;

        public DailyJobsController(IDailyJobService service)
        {
            this.DailyJobService = service;
        }

        [Produces("application/json")]
        [ResponseType(typeof(LoadCounterDailyJobDTO))]
        [HttpGet("{DailyJobId}")]
        public IActionResult GetDailyJobs(int DailyJobId)
        {
            try
            {
               LoadCounterDailyJobDTO responseList = this.DailyJobService.GetDailyJobs(DailyJobId);

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

        [Produces("application/json")]
        [ResponseType(typeof(LoadCounterDailyJobDTO))]
        [HttpGet("test/{DailyJobId}")]
        public IActionResult TestGetDailyJobs(int DailyJobId)
        {
            try
            {
                LoadCounterDailyJobDTO responseList = new LoadCounterDailyJobDTO();
                responseList.DailyJobId = "123";
                responseList.JobName = "TestJob";
                responseList.LoadCounterFirstName = "Joe";
                responseList.LoadCounterLastName = "Testman";
                responseList.LoadCounterUsername = "JTestman";
                responseList.PMFirstName = "PMJoe";
                responseList.PMLastName = "PMTest";
                responseList.LoadCounterId = "4567";
                responseList.DivisionId = "678768";
                responseList.DivisionName = "TestDivision";


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

        [Produces("application/json")]
        [ResponseType(typeof(LoadCounterDailyJobDTO))]
        [HttpPost]
        public IActionResult PostDailyJobs([FromBody] string CompanyId, int DailyJobId)
        {
            try
            {
                LoadCounterDailyJobDTO responseList = this.DailyJobService.GetDailyJobs(DailyJobId);

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
