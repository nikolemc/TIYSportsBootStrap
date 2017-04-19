using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TIYSports.Models
{
    public class SportTypes
    {
        public int Id { get; set; }
        public string Sport { get; set; }
        public string SportImg { get; set; }

        public SportTypes() { }
        public SportTypes(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Sport = reader["Sport"]?.ToString();
            this.SportImg = reader["Sport"]?.ToString();
        }
    }
}