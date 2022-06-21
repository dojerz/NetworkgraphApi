using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkgraphApi.Data
{
    public class Graph
    {
        // Node-ok listája
        public node[] nodelist { get; set; }
        // Nodeok-ok közötti kapcsolatok listája
        public nodeconnection[] connectionlist { get; set; }
        // Node-ok portjainak a listája
        public nwnodeport[] portlist { get; set; }
        public bounds bounds { get; set; }
    }

    public class bounds
    {
        public int x { get; set; }
        public int y { get; set; }
        public float w { get; set; }
        public float h { get; set; }
    }

    public class node
    {
        // Node belső azonosító
        public string nodeid { get; set; }
        // Node név
        public string name { get; set; }
        // IP cím
        public string ip { get; set; }
        // Hardware típus
        public string type { get; set; }
    }
    public class nodeconnection
    {
        // Kapcsolat belső azonosító
        public string connectionid { get; set; }
        // Egyik node belső azonosító
        public string startnodeid { get; set; }
        // Másik node belső azonosító
        public string endnodeid { get; set; }
        // Kiindulási port azonosító
        public string startportid { get; set; }
        // Vége port azonosító
        public string endportid { get; set; }
        // Kapcsolat leírás
        public string description { get; set; }
        // Sávszél
        public string bandwidth { get; set; }
        public string duplexity { get; set; }
        public string media { get; set; }
        public string subnet { get; set; }
        public string other_1 { get; set; }
        public string other_2 { get; set; }
        public string other_3 { get; set; }
        public string other_4 { get; set; }
        public string other_5 { get; set; }
        public string other_6 { get; set; }
        public string other_7 { get; set; }
        public string other_8 { get; set; }
        public string other_9 { get; set; }
        public string other_10 { get; set; }
    }

    public class nwnodeport
    {
        // Port azonosító pl. P1,P2,P3..
        public string portid { get; set; }
        // A portot trtalmazó node belső azonosítója
        public string parentnodeid { get; set; }
        public string portadminstatus { get; set; }
        // Port működése: UP,DOWN, egyéb
        public string portstatus { get; set; }
        // Port pozíciója a node-on, N,W,S,E - s1,s2,s3,s4 analógiára
        public string portposition { get; set; }
        // Port megjegyzés
        public string portdescription { get; set; }
        //Port egyéb adat
        public string portdata { get; set; }
        public string portip { get; set; }
        public string portmac { get; set; }
        public string portvlan { get; set; }
        public string other_1 { get; set; }
        public string other_2 { get; set; }
        public string other_3 { get; set; }
        public string other_4 { get; set; }
        public string other_5 { get; set; }
        public string other_6 { get; set; }
        public string other_7 { get; set; }
        public string other_8 { get; set; }
        public string other_9 { get; set; }
        public string other_10 { get; set; }
    }
}
