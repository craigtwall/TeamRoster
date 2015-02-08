using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TeamRoster.Models
{
    public class Team
    {
       
        public int ID { get; set; }

        [DisplayName("Team Name")]
        public string Name { get; set; }
        public string City { get; set; }

        // I want to reference the players on each team.
        // 1 team can have many players
        public virtual ICollection<Player> Players { get; set; }
    }
}