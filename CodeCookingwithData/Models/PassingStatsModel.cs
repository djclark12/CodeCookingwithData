using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeCookingwithData.Models
{
    public class PassingStatsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string PlayerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateTime { get; set; }
        public string Team { get; set; }
        public bool IsAway { get; set; }
        public string OppTeam { get; set; }
        public string Result { get; set; }
        public int GameNum { get; set; }
        public int Week { get; set; }
        public string DayOfWeek { get; set; }
        public int PassCmp { get; set; }
        public int PassAtt { get; set; }
        public decimal CmpPercent { get; set; }
        public int PassYds { get; set; }
        public int PassTds { get; set; }
        public int Interceptions { get; set; }
        public decimal Rating { get; set; }
        public decimal PassYdsperAtt { get; set; }
        public decimal PassAdjYdsperAtt { get; set; }
    }
}