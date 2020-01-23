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
    [Microsoft.AspNetCore.Mvc.Route("api/sites")]
    [ApiController]
    public class DailySitesController : ControllerBase
    {
        private readonly HttpRequest request;
        private ISiteService SiteService;

        public DailySitesController(ISiteService service)
        {
            this.SiteService = service;
        }

        [ResponseType(typeof(IEnumerable<LoadCounterSiteDTO>))]
        [HttpGet("{JobId}")]
        public IActionResult GetDailySites(int JobId)
        {
            try
            {
                IEnumerable<LoadCounterSiteDTO> responseList = this.SiteService.GetDailyJobSites(JobId);

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
