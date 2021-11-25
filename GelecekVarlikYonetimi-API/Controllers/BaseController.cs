using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GelecekVarlikYonetimi_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        //public override BadRequestResult BadRequest()
        //{
        //    return base.BadRequest();   
        //}
    }
}
