using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetworkgraphApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [EnableCors]
        public string Get(string refnode, string scope)
        {
            var content = System.IO.File.ReadAllText(@"c:\Projects\MobileGap\CausalGap\NwGraph\NetworkgraphApi\Data\NEGY\" + refnode+ "_" + scope + ".json");
            return content;
        }
    }
}
