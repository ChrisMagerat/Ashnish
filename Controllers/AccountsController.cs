using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ashnish.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public string[] GetStrings()
        {
            string[] stringNames = { "String1", "String2", "String3" };
            return stringNames;
        }

    }
}
