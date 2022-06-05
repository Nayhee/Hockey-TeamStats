using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;


namespace HockeyCSV
{
    public class DataLoader
    {
        private static string _dataFilename = "data.csv";
        public static List<TeamStats> GetTeamStats()
        {
            using(TextReader textReader = new StreamReader(_dataFilename))
            {
                using(CsvReader csv = new CsvReader(textReader, CultureInfo.CurrentCulture))
                {
                    csv.Context.RegisterClassMap<ShowMap>();
                    return csv.GetRecords<TeamStats>().ToList();
                }
            }
        }

        class ShowMap : ClassMap<TeamStats>
        {
            public ShowMap()
            {
                Map(m => m.Team);
                Map(m => m.Season);
                Map(m => m.GP);
                Map(m => m.Wins);
                Map(m => m.Losses);
                Map(m => m.OTL);
                Map(m => m.Points);
                Map(m => m.PointsPerc);
                Map(m => m.RegulationWins);
                Map(m => m.OTWins);
                Map(m => m.SOWins);
                Map(m => m.GF);
                Map(m => m.GA);
                Map(m => m.PPperc);
                Map(m => m.SPG);
                Map(m => m.SAG);
                Map(m => m.FOWperc);
            }
        }
    }
}