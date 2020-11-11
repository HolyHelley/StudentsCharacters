using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace StudentCharacter
{
    static class Sqlite
    {
        public static SQLiteConnection SetConnection()
        {
            string dbFileName = @"db/characters.db";
            return new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;"); 
        }
    }
}
