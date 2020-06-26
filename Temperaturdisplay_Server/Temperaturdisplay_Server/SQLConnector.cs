using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Temperaturdisplay_Server
{
    class SQLConnector
    {
        private static string _connectionString; // "server=;user=;port=;password=;"
        private static MySqlConnection _conn;

        /// <summary>
        /// Fordert den Nutzer auf Daten einzugeben und erzeugt aus diesen den ConnectionString für die Datenbank.
        /// Form "server=;user=;port=;password=;"
        /// </summary>
        public static void makeConnectionString()
        {
            string server, uid, pwd, port;

            // Server-IP
            Console.Write("Geben Sie die Server-IP ein: ");
            do
            {
                server = Console.ReadLine();
                if (!Regex.IsMatch(server, @"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"))
                {
                    Console.Write("Bitte eine gültige IP eingeben: ");
                }
            }
            while (!Regex.IsMatch(server, @"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"));

            // Port
            Console.Write("Geben Sie den Port ein: ");
            do
            {
                port = Console.ReadLine();
                if (!Regex.IsMatch(port, @"^\d+$"))
                {
                    Console.Write("Bitte einen gültigen Port eingeben: ");
                }
            }
            while (!Regex.IsMatch(port, @"^\d+$"));

            // Benutzernamen
            Console.Write("Geben Sie nun Ihren Benutzernamen ein: ");
            uid = Console.ReadLine();

            // Passwort
            Console.Write("Geben Sie das Passwort von {0} ein: ", uid);
            pwd = Console.ReadLine();

            _connectionString = "server=" + server + ";user=" + uid + ";port=" + port + ";password=" + pwd + ";";
        }

        /// <summary>
        /// Erstellt die Datenbank temperaturlogger und die Tabelle temperatur (temp_ID, temperatur, datum, zeit)
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void setupDB()
        {
            Console.Write("Sollen eventuell bereits vorhandene Datenbanken gelöscht werden? (y / N) ");
            if(Console.ReadLine().ToLower().Equals("y"))
            {
                runNonQuery("drop database `temperaturlogger`");
            }
            runNonQuery("CREATE DATABASE IF NOT EXISTS `temperaturlogger`");
            runNonQuery("use `temperaturlogger`");
            runNonQuery("CREATE TABLE IF NOT EXISTS `temperatur`" +
                "(" +
                "temp_ID INTEGER PRIMARY KEY AUTO_INCREMENT NOT NULL, " +
                "temperatur float NOT NULL, " +
                "datum date NOT NULL," +
                "zeit time NOT NULL);");

        }

        /// <summary>
        /// Fügt die übergebene Temperatur und das aktuelle Datum sowie die Uhrzeit der Datenbank hinzu
        /// </summary>
        /// <param name="temp"></param>
        /// <exception cref="Exception"></exception>
        public static void insertToDB(string temp)
        {
            runNonQuery("INSERT INTO `temperatur` (temperatur, datum, zeit) VALUES (" + temp + ", CURDATE(), CURTIME());");
        }



        /// <summary>
        /// Stellt eine Verbindung mit der Datenbank her
        /// </summary>
        /// <exception cref="MySqlException"></exception>
        public static void connectToDB()
        {
            _conn = new MySqlConnection(_connectionString);
            _conn.Open();
        }

        private static void runNonQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
        }

        public static ArrayList runQueryAllData(string query)
        {
            ArrayList data = new ArrayList();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    data.Add(dataReader.GetString("temp_ID") + ";" + dataReader.GetString("temperatur") + ";" + dataReader.GetString("datum") + ";" + dataReader.GetString("zeit"));
                }
                dataReader.Close();
            }
            catch (Exception) { }
            return data;
        }
    }
}
