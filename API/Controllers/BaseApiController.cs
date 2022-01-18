using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[controller] => when access the api link controller will be translated into any controller class we have and we want to access 
    // url/api/activities will forward us to the => ActivitiesController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}