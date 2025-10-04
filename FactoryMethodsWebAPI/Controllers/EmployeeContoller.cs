using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UOW.Services.ControllerModels;

namespace FactoryMethodsWebAPI.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class EmployeeContoller : ControllerBase
    {

        [HttpGet]
        [Route("GetAllEmployees")]
        public ActionResult<IEnumerable<EmployeeDetailResponse>> GetAllEmployees()
        {
            return Ok(new EmployeeDetailResponse());
        }
    }
}
