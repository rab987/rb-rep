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
    [Microsoft.AspNetCore.Mvc.Route("api/comments")]
    [ApiController]
    public class DailyCommentsController : ControllerBase
    {
        private readonly HttpRequest request;
        private ICommentsService CommentsService;

        public DailyCommentsController(ICommentsService service)
        {
            this.CommentsService = service;
        }

        [ResponseType(typeof(IEnumerable<LoadCounterCommentDTO>))]
        [HttpGet("{JobId}")]
        public IActionResult GetDailyComments(int JobId)
        {
            try
            {
                IEnumerable<LoadCounterCommentDTO> responseList = this.CommentsService.GetDailyJobComments(JobId);

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
