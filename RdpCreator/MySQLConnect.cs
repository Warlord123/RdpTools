using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RdpCreator.Properties;
using System.Reflection;

namespace RdpCreator
{



    using TPropertyMapper = List<TPropertyMapping>;

    public static class MySQLData
    {
        private static MySqlConnection _conn;
        private static MySqlCommand _command;

        public static bool Connected { get; private set; }

     
        private static String ConnectionString
        {
            get
            {
                return Settings.Default.ConnectionString;

            }
        }

        public static String Esc(String s)
        {
            return String.Format("'{0}'", MySqlHelper.EscapeString(s));
        }

        public static void Connect()
        {
            _conn = new MySqlConnection(ConnectionString);
            _conn.Open();
            Connected = true;
        }
        public static void Close()
        {
            if (Connected)
                _conn.Close();
            Connected = false;
        }
        
        public static void RunSQL(string query)
        {
            _command = new MySqlCommand(query, _conn);
            _command.ExecuteNonQuery();


        }


        public static void TestConnect()
        {
            try
            {
                _conn = new MySqlConnection(ConnectionString);
                _conn.Open();
                _conn.Close();
                Connected = true;
            }
            catch
            {
                Connected = false;
            }
        }


        static List<T> LoadList<T>(String Query) where T: new()
        {
            _command = new MySqlCommand(Query, _conn);

            //Создаем новый список результатов
             List<T> Result = new List<T>();

            if (Connected)

                using (MySqlDataReader reader = _command.ExecuteReader())
                {
                    //Создаем отображение полей в свойства.
                    TPropertyMapper M = ObjectLoader.Test(typeof(T), reader);

                    while (reader.Read())
                    {
                        T A = new T();
                        Result.Add(A);
                        ObjectLoader.Read(A, M, reader);
                    }
                }
            return Result;
        }

        public static void LoadData()
        {
            Connect(); //Соединяемся с сервером БД.
            Data.Servers = LoadList<TServer>(Settings.Default.ServerNames);
            List<TServerAttributes> Attr = LoadList<TServerAttributes>(Settings.Default.ServerAttributes);
            Attr.ForEach(delegate(TServerAttributes A) { Data.Servers.Find(S => S.ID == A.ServerID).Attributes.Add(A.AttributeID); });
            Data.Attributes = LoadList<TServerAtribute>(Settings.Default.AttributeQuery);
            Data.SpecialGroups = LoadList<TLocalGroup>("SELECT ServerID , ID , Name , Description FROM SpecialGroup;");
            Close(); //Отключаемся от сервера.
        }

    }
}
