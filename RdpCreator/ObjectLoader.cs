using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace RdpCreator
{

    using TPropertyMapper = List<TPropertyMapping>;
    class TPropertyMapping
    {
        public String FieldName;
        public int FieldNum;
        public PropertyInfo PInfo;
        public TPropertyMapping(){}


    }




    static class ObjectLoader
    {
        public static TPropertyMapper Test(Type ObjType, MySqlDataReader reader)
        {

            TPropertyMapper MappedFields = new TPropertyMapper();
            //Create fields list
            for (int i = 0; i < reader.FieldCount; i++)
            {
                 String fname=reader.GetName(i);

                 PropertyInfo f = ObjType.GetProperty(fname);
                 if (f != null)
                 {
                     MappedFields.Add(new TPropertyMapping { FieldName = fname, FieldNum = i, PInfo = f });

                 }
                 else
                 {
                     Debug.WriteLine("Field '{0}' not mapped to property of type '{1}'", fname,ObjType.ToString());
                 }

            }
            Debug.WriteLine("Mapped {0} of {1} properties  type '{2}'", MappedFields.Count, ObjType.GetProperties().Length, ObjType.ToString());
            return MappedFields;

        }

        public static void Read( object O,TPropertyMapper M,MySqlDataReader reader)
        {
            foreach (TPropertyMapping Map in M)
            {
                if (!reader.IsDBNull(Map.FieldNum))
                    Map.PInfo.SetValue(O, Convert.ChangeType(reader[Map.FieldName], Map.PInfo.PropertyType), null);
            }
        }
    }
}
