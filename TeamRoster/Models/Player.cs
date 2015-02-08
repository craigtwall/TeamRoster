using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TeamRoster.Models
{
    public enum Position
    {
        Catcher, Pitcher,
        FirstBase, SecondBase, Shortstop, ThirdBase,
        LeftField, CenterField, RightField
    }

    public enum BattingSide
    {
        Left, Right
    }

    public class Player
    {
        public int ID { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        public int Age { get; set; }

        [DisplayName("Number")]
        public int PlayerNumber { get; set; }
        
        // The player's team
    
        public int TeamID { get; set; }

        public Position Position { get; set; }
        public BattingSide Hits { get; set; }

        // Navigation Property. Each player can only be on 1 team
        public virtual Team Team { get; set; }

    }
}