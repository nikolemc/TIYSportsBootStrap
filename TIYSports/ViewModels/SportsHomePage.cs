using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TIYSports.ViewModels
{
    public class SportsHomePage
    {

        //Jumbotron & Carousel Sport Images, Panel Row Sports, Sports Table Title
        public List<TIYSports.Models.SportTypes> Sports { get; set; }

        //Sports Table
        public IEnumerable<TIYSports.Models.Teams> Team { get; set; }

        //Sports Table
        public IEnumerable<TIYSports.Models.Leagues> League { get; set; }

        
        //Panel New Features
        public string HeaderTitle { get; set; }
        public string PanelBodyText { get; set; }

        //Alert Facebook
        public string AlertBodyText { get; set; }

        //Panel List
        public string PanelTitle { get; set; }
        public string TitleTeamCount { get; set; }
        
   }
}