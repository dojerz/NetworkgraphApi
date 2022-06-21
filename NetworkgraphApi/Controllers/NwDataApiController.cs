using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetworkgraphApi.Data;

namespace NetworkgraphApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NwDataApiController : ControllerBase
    {
        [HttpGet("{scope}/{density}")]
        public Data.Graph Get(int scope, string density)
        {
            Graph testgraph = new Graph();

            //Node[] nodes = new Node[] { };
            List<node> nodes = new List<node>();
            List<nodeconnection> edges = new List<nodeconnection>();
            List<nwnodeport> ports = new List<nwnodeport>();

            int connectionCounter = 0;

            for (int i = 0; i < scope; i++)
            {
                if (i == 0)
                {
                    node node = new node()
                    {
                        nodeid = "R",
                        name = "teszt" + i,
                        ip = "192.168.1." + i * 21,
                        type = "886" + (2 * i)
                    };
                    nodes.Add(node);
                }
                if (i == 1)
                {
                    node node = new node()
                    {
                        nodeid = "A",
                        name = "teszt" + i,
                        ip = "192.168.1." + i * 21,
                        type = "886" + (2 * i)
                    };
                    nodes.Add(node);
                }
                if (i == 2)
                {
                    node node = new node()
                    {
                        nodeid = "B",
                        name = "teszt" + i,
                        ip = "192.168.1." + i * 21,
                        type = "886" + (2 * i)
                    };
                    nodes.Add(node);
                }

            }

            foreach (var node in nodes)
            {


                string stat = "ON";
                for (int i = 0; i < 5; i++)
                {
                    if (i % 2 == 1)
                    {
                        stat = "OFF";
                    }
                    else
                    {
                        stat = "ON";
                    }
                    ports.Add(new nwnodeport()
                    {
                        parentnodeid = node.nodeid,
                        portid = "P" + (i + 1),
                        portposition = "E",
                        portstatus = stat,
                        portdescription = "desc",
                        portdata = "Fe0/4"
                    });
                }
                for (int i = 0; i < 3; i++)
                {
                    if (i % 2 == 1)
                    {
                        stat = "OFF";
                    }
                    else
                    {
                        stat = "ON";
                    }
                    ports.Add(new nwnodeport()
                    {
                        parentnodeid = node.nodeid,
                        portid = "P" + (i + 1),
                        portposition = "W",
                        portstatus = stat,
                        portdescription = "desc",
                        portdata = "Fe0/4"
                    });
                }
                for (int i = 0; i < 3; i++)
                {
                    if (i % 2 == 1)
                    {
                        stat = "OFF";
                    }
                    else
                    {
                        stat = "ON";
                    }
                    ports.Add(new nwnodeport()
                    {
                        parentnodeid = node.nodeid,
                        portid = "P" + (i + 1),
                        portposition = "N",
                        portstatus = stat,
                        portdescription = "desc",
                        portdata = "Fe0/4"
                    });
                }
                for (int i = 0; i < 5; i++)
                {
                    if (i % 2 == 1)
                    {
                        stat = "OFF";
                    }
                    else
                    {
                        stat = "ON";
                    }
                    ports.Add(new nwnodeport()
                    {
                        parentnodeid = node.nodeid,
                        portid = "P" + (i + 1),
                        portposition = "S",
                        portstatus = stat,
                        portdescription = "desc",
                        portdata = "Fe0/4"
                    });
                }

            }

            foreach (var node in nodes)
            {
                int edgeCount = 1;
                var rng = new Random();

                if (density == "S")
                {
                    edgeCount += rng.Next(0, 2);
                }
                else if (density == "M")
                {
                    edgeCount += rng.Next(2, 5);
                }
                else if (density == "L")
                {
                    edgeCount += rng.Next(4, 10);
                }
                var nextNode = nodes.Where(i => i != node);

                foreach (var nNode in nextNode)
                {
                    for (int i = 0; i < edgeCount; i++)
                    {
                        nodeconnection edge = new nodeconnection()
                        {
                            connectionid = connectionCounter.ToString(),
                            endportid = ports.Where(i => i.parentnodeid == nNode.nodeid).First().portid,
                            startportid = ports.Where(i => i.parentnodeid == node.nodeid).Last().portid,
                            startnodeid = nNode.nodeid,
                            endnodeid = node.nodeid,
                            bandwidth = "10G",
                            description = nNode.name.GetHashCode().ToString(),
                            subnet = "192.168.1.100/24"
                        };
                        edges.Add(edge);
                        connectionCounter++;
                    }
                }
            }




                testgraph.connectionlist = edges.ToArray();
            testgraph.nodelist = nodes.ToArray();
            testgraph.portlist = ports.ToArray();

            return testgraph;
        }
    }
}
