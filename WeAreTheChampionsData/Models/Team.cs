using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsData
{
    [Table("Teams")]
    public class Team
    {
        public Team()
        {
            Colors = new HashSet<Color>();
            Players = new HashSet<Player>();
            HomeMatches = new HashSet<Match>();
            AwayMatches = new HashSet<Match>();
        }
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string TeamName { get; set; }

        public virtual ICollection<Color> Colors { get; set; } 
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Match> HomeMatches { get; set; }
        public virtual ICollection<Match> AwayMatches { get; set; }

    }
}
