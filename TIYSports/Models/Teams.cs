using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TIYSports.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public string Team { get; set; }
        public string TeamExtraInfo { get; set; }
        public string LogoImg { get; set; }


        public Teams() { }
        public Teams(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Team = reader["Team"]?.ToString();
            this.LogoImg = reader["LogoImg"]?.ToString();
            this.TeamExtraInfo = reader["TeamExtraInfo"]?.ToString();
        }
    }
}