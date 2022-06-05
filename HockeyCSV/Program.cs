using System;
using System.Collections.Generic;
using System.Linq;

namespace HockeyCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamStats> teamStats = DataLoader.GetTeamStats();

            // Print("Team List: ", TeamNames(teamStats));
            Print("Top 5 - Face-Off Percentage", FaceOffPerc(teamStats));
            Print("Top 5 - Regulation Wins", RegulationWins(teamStats));
            Print("Top 5 - Over-Time Wins", OTW(teamStats));
            Print("Top 5 - Over-Time Losses", OTL(teamStats));
            Print("Top 5 - Shout-Out Wins", SOW(teamStats));

        }

        //1) Team List
        static List<string> TeamNames(List<TeamStats> stats)
        {
            return stats.Select(s => s.Team).ToList();
        }
        static List<string> FaceOffPerc(List<TeamStats> stats)
        {
            return stats.OrderByDescending(s => s.FOWperc).Select(s => $"{s.Team} - {s.FOWperc}%").Take(5).ToList();
        }
        //Ranked by Face Off Percentage.
        static List<string> RegulationWins(List<TeamStats> stats)
        {
            return stats.OrderByDescending(s => s.RegulationWins).Select(s => $"{s.Team} - {s.RegulationWins} Regulation Wins").Take(5).ToList();
        }
        static List<string> OTW(List<TeamStats> stats)
        {
            return stats.OrderByDescending(s => s.OTWins).Select(s => $"{s.Team} - {s.OTWins} OT Wins").Take(5).ToList();
        }
        static List<string> OTL(List<TeamStats> stats)
        {
            return stats.OrderByDescending(s => s.OTL).Select(s => $"{s.Team} - {s.OTL} OT Losses").Take(5).ToList();
        }
        static List<string> SOW(List<TeamStats> stats)
        {
            return stats.OrderByDescending(s => s.SOWins).Select(s => $"{s.Team} - {s.SOWins} SO Wins").Take(5).ToList();
        }






        static void Print(string title, List<TeamStats> stats)
        {
            PrintHeaderText(title);
            foreach (TeamStats stat in stats)
            {
                Console.WriteLine(stats);
            }

            Console.WriteLine();
        }

        static void Print(string title, List<string> strings)
        {
            PrintHeaderText(title);
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();
        }


        static void Print(string title, TeamStats stats)
        {
            PrintHeaderText(title);
            Console.WriteLine(stats);
            Console.WriteLine();
        }

        static void Print(string title, string str)
        {
            PrintHeaderText(title);
            Console.WriteLine(str);
            Console.WriteLine();
        }

        static void Print(string title, int number)
        {
            PrintHeaderText(title);
            Console.WriteLine(number);
            Console.WriteLine();
        }

        static void Print(string title, double number)
        {
            PrintHeaderText(title);
            Console.WriteLine(number);
            Console.WriteLine();
        }

        static void PrintHeaderText(string title)
        {
            Console.WriteLine("============================================");
            Console.WriteLine(title);
            Console.WriteLine("--------------------------------------------");
        }

    }
}
