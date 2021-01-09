using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkgraphApi.Data
{
    public class Graph
    {
        public Nodelist[] nodeList { get; set; }
        public Edgelist[] edgeList { get; set; }
        public Graphbounds graphBounds { get; set; }
        public bool isGrouped { get; set; }
    }

    public class Graphbounds
    {
        public int x { get; set; }
        public int y { get; set; }
        public float w { get; set; }
        public float h { get; set; }
    }

    public class Nodelist
    {
        public Tag tag { get; set; }
        public Layout layout { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string ip { get; set; }
        public bool enabled { get; set; }
        public int type { get; set; }
        public float load { get; set; }
        public int id { get; set; }
    }

    public class Layout
    {
        public float x { get; set; }
        public float y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Edgelist
    {
        public Tag1 tag { get; set; }
        public int source { get; set; }
        public int target { get; set; }
        public Sourceport sourcePort { get; set; }
        public Targetport targetPort { get; set; }
        public object[] bends { get; set; }
    }

    public class Tag1
    {
        public Source source { get; set; }
        public Target target { get; set; }
        public float load { get; set; }
        public object hasForwardPacket { get; set; }
        public object hasBackwardPacket { get; set; }
        public int id { get; set; }
    }

    public class Source
    {
        public string name { get; set; }
        public string ip { get; set; }
        public bool enabled { get; set; }
        public int type { get; set; }
        public float load { get; set; }
        public int id { get; set; }
    }

    public class Target
    {
        public string name { get; set; }
        public string ip { get; set; }
        public bool enabled { get; set; }
        public int type { get; set; }
        public float load { get; set; }
        public int id { get; set; }
    }

    public class Sourceport
    {
        public float x { get; set; }
        public float y { get; set; }
    }

    public class Targetport
    {
        public float x { get; set; }
        public float y { get; set; }
    }
}
