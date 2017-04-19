using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace TIYSports.Models
{
    public class Leagues
    {
        public int Id { get; set; }
        public string League { get; set; }

        public Leagues() { }
        public Leagues(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.League = reader["League"]?.ToString();
        }

    }
}