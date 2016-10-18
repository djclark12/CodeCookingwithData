using System;

namespace CodeCookingwithData.Models
{
    public class ReceiverStatsModel
    {
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
        public int Week { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int Targets { get; set; }
        public int Receptions { get; set; }
        public int RecYds { get; set; }
        public decimal YdsperRec { get; set; }
        public int RecTds { get; set; }
        public decimal CtchPercent { get; set; }
        public decimal YdsperTgt { get; set; }
    }
}