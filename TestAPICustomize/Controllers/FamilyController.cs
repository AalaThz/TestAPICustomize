using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPICustomize.Models;

namespace TestAPICustomize.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FamilyController : ControllerBase
    {
        [HttpPost("FamilyMembers")]
        public ActionResult<ApiResponse> GetFamilyMembers([FromQuery] string userId)
        {
            var response = new ApiResponse
            {
                Success = true,
                Message = "OK",
                Data = new List<FamilyMember>
                {
                    new FamilyMember
                    {
                        Id = Guid.NewGuid(),
                        UserName = "exampleUser",
                        Name = "John",
                        LName = "Doe",
                        FamilyMemberTypeId = 1
                    }
                }
            };

            return Ok(response);
        }
    }
}
