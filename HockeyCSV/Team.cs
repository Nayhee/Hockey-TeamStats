using System.Collections.Generic;

namespace HockeyCSV
{
    public class TeamStats
    {
        public string Team { get; set; }
        public int Season { get; set; }
        public int GP { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int OTL { get; set; }
        public int Points { get; set; }
        public decimal PointsPerc { get; set; }
        public int RegulationWins { get; set; }
        public int OTWins { get; set; }
        public int SOWins { get; set; }
        public int GF { get; set; }
        public int GA { get; set; }

        public decimal GFP {get; set;}
        public decimal GAP {get; set;}
        public decimal PPperc { get; set; }
        public decimal PKperc { get; set; }
        public decimal SPG { get; set; }
        public decimal SAG { get; set; }
        public decimal FOWperc { get; set; }

        public override string ToString()
        {
            return $"\"{Team}\",{Season}\",{GP}\",{Wins}\",{Losses}\",{OTL}\",{Points}\",{PointsPerc}\",{RegulationWins}\",{OTWins}\",{SOWins}\",{GFP}\",{GAP}\",{PPperc}\",{PKperc}\",{SPG}\",{SAG}\",{FOWperc}\"";
        }
    }
}