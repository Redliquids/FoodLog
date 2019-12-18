using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.IO;
using System.Data.SQLite;

namespace FoodLog.DBLogic
{
    public class PostsDBManager
    {
        public static string conString = "Data Source=C:\\FoodLogDB\\FoodLogDB.db";

        public static void SetupDB()
        {
            // If DB Directory doesn't exist, Create it.
            if (!Directory.Exists("C:\\FoodLogDB"))
            {
                Directory.CreateDirectory("C:\\FoodLogDB");
            }

            if (!File.Exists("C:\\FoodLogDB\\FoodLogDB.db"))
            {
                SQLiteConnection.CreateFile("C:\\FoodLogDB\\FoodLogDB.db");

                using (SQLiteConnection con = new SQLiteConnection(conString))
                {

                }
            }

        }
    }
}
