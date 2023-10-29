using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApiQ1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCandidateInfo()
        {
            var candidateInfo = new
            {
                name = "test",
                phone = "test"
            };
            return Ok(candidateInfo);
        }
    }
}
