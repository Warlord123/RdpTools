﻿using System;
using System.Data;
using System.Collections.Generic;
namespace RdpCreator
{

    class TServerAtribute
    {
        public int ID { get; set; }
        public string Name { get; set; }


        override public String ToString()
        {
            return Name;
        }

        public TServerAtribute(int aID, string aName)
        {
            ID = aID;
            Name = aName;
        }

       
    }

    class TServer
    {
        public int ID { get; set; }
        public string IP { get; set; }
        public string Name { get; set; }
        public string RdpName { get; set; }
        public bool   Domain { get; set; }
        public List<int> Attributes { get; set; }

        public TServer(int aID,string aIP,string aName,string aRdpName,bool aDomain)
        {
            ID = aID;
            IP = aIP;
            Name = aName;
            RdpName = aRdpName;
            Domain = aDomain;
            Attributes = new List<int>();
        }

        override public String ToString()
        {
            return String.Format("{0}[{1}]",Name,IP);
        }
    }

    static class Data
    {
        public static List<TServerAtribute> Attributes;
        public static Dictionary<int, TServer> Servers;
    }


}