using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkgraphApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopoJsonController : ControllerBase
    {
        [EnableCors]
        public string Get(string id)
        {
            //string[] inpParts = id.Split('_');


            if (id == "23")
            {
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\base.json");
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\u_cgap1_871_2.json");
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\cgapsw1_3560_2mod.json");
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\cgap1_871_2.json");

                var content = System.IO.File.ReadAllText(@"c:\Projects\MobileGap\CausalGap\NwGraph\NetworkgraphApi\Data\DECEND\05417T8601_2.json");
                return content;
            }
            else if (id == "11")
            {
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\cgapsw1_3560_1.json");
                var content = System.IO.File.ReadAllText(@"c:\Projects\MobileGap\CausalGap\NwGraph\NetworkgraphApi\Data\DECEND\05001G31_1.json");
                //
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\u_cgap1_871_1.json");
                //var content = System.IO.File.ReadAllText(@"c:\Projects\MobileGap\CausalGap\NwGraph\NetworkgraphApi\Data\DEC\cgap1_871_1.json");
                //var content = System.IO.File.ReadAllText(@"c:\Projects\MobileGap\CausalGap\NwGraph\NetworkgraphApi\Data\DECEND\cgapsw2_3560_1.json");
                return content;
            }
            else if(id == "33")
            {
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\response_3.json");
                var content = System.IO.File.ReadAllText(@"c:\Projects\MobileGap\CausalGap\NwGraph\NetworkgraphApi\Data\DECEND\09001A11_3.json");
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\cgapsw1_3560_3.json");
                return content;
            }
            else
            {
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\response_5connection.json");
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\u_cgap1_871_2.json");
                //var content = System.IO.File.ReadAllText(@"C:\Projects\GAP\CasualGap\NwGraph\NetworkgraphApi\Data\Topologiai_rajzolas_1-es_terjedelem.json");
                var content = System.IO.File.ReadAllText(@"c:\Projects\MobileGap\CausalGap\NwGraph\NetworkgraphApi\Data\DEC\cgap1_871_2.json");
                return content;
            }

        }
    }
}
