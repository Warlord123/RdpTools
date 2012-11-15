using System;
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

        public TServerAtribute()
        {}

       
    }

    class TServer
    {
        public int ID { get; set; }
        public string IP { get; set; }
        public string Name { get; set; }
        public string RdpName { get; set; }
        public bool   Domain { get; set; }
        public List<int> Attributes { get; set; }

        public TServer()
        {
            Attributes = new List<int>();
        }

        override public String ToString()
        {
            return String.Format("{0}[{1}]",Name,IP);
        }
    }

    class TLocalGroup
    {
         public int ServerID { get; set; }
         public int ID { get; set; }
         public string Name { get; set; }
         public string Description { get; set; }
   
    }

    static class Data
    {
        public static List<TServerAtribute> Attributes;
        public static Dictionary<int, TServer> Servers;
        public static List<TLocalGroup> SpecialGroups;
    }


}