using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TIYSports.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public int LeagueId { get; set; }

        public int TeamId { get; set; }

        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }


        public string HomeTeamImg { get; set; }
        public string AwayTeamImg { get; set; }


        public string Status { get; set; }

        public Game() { }
        public Game(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.SportId = (int)reader["SportId"];
            this.LeagueId = (int)reader["LeagueId"];

            this.TeamId = (int)reader["TeamId"];

            this.HomeTeam = reader["HomeTeam"]?.ToString();
            this.AwayTeam = reader["AwayTeam"]?.ToString();

            this.HomeTeamScore = (int)reader["HomeTeamScore"];
            this.AwayTeamScore = (int)reader["AwayTeamScore"];

            this.HomeTeamImg = reader["HomeTeamImg"]?.ToString();
            this.AwayTeamImg = reader["AwayTeamImg"]?.ToString();
        }

    }
}