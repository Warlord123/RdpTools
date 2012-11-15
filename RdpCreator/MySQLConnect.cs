﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RdpCreator.Properties;


namespace RdpCreator
{




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

         static void LoadAttributeList()
        {
        
            //Загружаем список серверов для опроса
            _command = new MySqlCommand(Settings.Default.AttributeQuery, _conn);
            Data.Attributes = new List<TServerAtribute>();

            
            if (Connected)
    
                using (MySqlDataReader reader = _command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Data.Attributes.Add(new TServerAtribute (Int32.Parse( reader[0].ToString()),reader[1].ToString()));

                    }
                }
  
            

        }

         static void LoadServerList()
        {
            
            //Загружаем список серверов для опроса
            _command = new MySqlCommand(Settings.Default.ServerNames, _conn);
            Data.Servers = new Dictionary<int, TServer>();


            if (Connected)
            {
                using (MySqlDataReader reader = _command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int ID = int.Parse(reader[0].ToString());
                        bool f = reader.IsDBNull(4) ? false : reader.GetInt32(4)!=0;
                        Data.Servers.Add(ID, new TServer(ID, reader[1].ToString(),
                            reader[2].ToString()
                            ,reader[3].ToString()
                            ,f));

                    }
                }

                _command = new MySqlCommand(Settings.Default.ServerAttributes, _conn);
                using (MySqlDataReader reader = _command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int ID = int.Parse(reader[0].ToString());
                        int AttrubuteID = int.Parse(reader[1].ToString());
                        Data.Servers[ID].Attributes.Add(AttrubuteID);
                    }
                }

            }

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

        public static void LoadData()
        {
            Connect(); //Соединяемся с сервером БД.
            LoadAttributeList();
            LoadServerList();
            Close(); //Отключаемся от сервера.
        }

    }
}