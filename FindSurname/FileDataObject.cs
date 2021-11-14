using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSurname
{
    public class FileDataObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string>();
            var cs = "Host=localhost;Username=postgres;Password=2358;Database=Testing";
            var connection = new NpgsqlConnection(cs);
            connection.Open();
            string sql = "SELECT * FROM users";
            var command = new NpgsqlCommand(sql, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }
    }
}