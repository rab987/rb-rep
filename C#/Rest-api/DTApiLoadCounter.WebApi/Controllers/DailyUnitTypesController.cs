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
    [Microsoft.AspNetCore.Mvc.Route("api/unittypes")]
    [ApiController]
    public class DailyUnitTypesController : ControllerBase
    {
        private readonly HttpRequest request;
        private IUnitTypeService UnitTypeService;

        public DailyUnitTypesController(IUnitTypeService service)
        {
            this.UnitTypeService = service;
        }

        [ResponseType(typeof(IEnumerable<LoadCounterUnitTypeDTO>))]
        [HttpGet("{JobId}")]
        public IActionResult GetDailyUnitTypes(int JobId)
        {
            try
            {
                IEnumerable<LoadCounterUnitTypeDTO> responseList = this.UnitTypeService.GetDailyJobUnitTypes(JobId);

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
