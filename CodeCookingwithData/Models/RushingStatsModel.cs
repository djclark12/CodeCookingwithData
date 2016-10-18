using System;
using System.ComponentModel.DataAnnotations;

namespace CodeCookingwithData.Models
{
    public class RushingStatsModel
    {
        [Key]
        public int Id { get; set; }

        public string PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public DateTime DateTime { get; set; }
        public string Team { get; set; }
        public bool IsAway { get; set; }
        public string OppTeam { get; set; }
        public string Result { get; set; }
        public int GameNum { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int RushAtt { get; set; }
        public int RushYds { get; set; }
        public decimal RushYdsperAtt { get; set; }
        public int RushTds { get; set; }
    }
}