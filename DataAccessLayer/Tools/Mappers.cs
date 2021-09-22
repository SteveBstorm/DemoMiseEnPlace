using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tools
{
    public static class Mappers
    {
        internal static Movie MovieConverter(SqlDataReader reader)
        {
            return new Movie
            {
                Id = (int)reader["Id"],
                IsFavorite = (bool)reader["IsFavorite"],
                Title = reader["Title"].ToString()
            };
        }

        internal static Actor ActorConverter(SqlDataReader reader)
        {
            return new Actor
            {
                Id = (int)reader["Id"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
            };
        }
    }
}
