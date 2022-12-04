using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballLep.Models
{
    public class Match
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchID { get; set; }
        public String TeamName1 { get; set; }
        public String Teamname2 { get; set; }
        public String StatusTeam {get; set;}
        public String WinningTeam { get; set; }
    }
}