using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Linq2
{
    public class Player
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Team { get; set; }
    }

   
    class Program
    {
        static List<Player> GetPlayes()
        {
            List<Player> players = new List<Player>()
            {
                new Player(){Name="Denis Shapovalov",Country="Canada"},
                new Player(){Name="Milos Raonic",Country="Canada"},
                new Player(){Name="Vasek Pospisil",Country="Canada"},

                new Player(){Name="John Isner",Country="USA"},
                new Player(){Name="Sam Querrey",Country="USA"},
                new Player(){Name="Steve Johnson",Country="USA"},
                new Player(){Name="Bradley Klahn",Country="USA"},

                new Player(){Name="Ramkumar Ramanathan",Country="India"},
                new Player(){Name="Prajnesh Gunneswaran",Country="India"},
                new Player(){Name="Yuki Bhambri",Country="India"},

                new Player(){Name="Nick Kyrgios",Country="Australia"},
                new Player(){Name="John Millman",Country="Australia"},
                new Player(){Name="Matthew Ebden",Country="Australia"},
                new Player(){Name="Alex de Minaur",Country="Australia"},
                new Player(){Name="Jason Kubler",Country="Australia"},

                new Player(){Name="Roger Federer",Country="Switzerland"},
                new Player(){Name="Henri Laaksonen",Country="Switzerland"},
                new Player(){Name="Adrian Bodmer",Country="Switzerland"},
                new Player(){Name="Yann Marti",Country="Switzerland"},
                new Player(){Name="Stan Wawrinka",Country="Switzerland"},

                new Player(){Name="Gonzalo Lama",Country="Chile"},
                new Player(){Name="Victor Nunez",Country="Chile"},
                new Player(){Name="Esteban Bruna",Country="Chile"},
                 new Player(){Name="Christian Garin",Country="Chile"},
            };
            return players;

        }

        static void PrintPossibleMatches(List<Player>TeamA, List<Player> TeamB)
        {
            Console.WriteLine("Team A : " + string.Join(",", TeamA.Select(x => x.Name + " (" + x.Country + ")")));
            Console.WriteLine("Team B : " + string.Join(",", TeamB.Select(x => x.Name + " (" + x.Country + ")")));
            Console.WriteLine();
            Console.WriteLine("Possible Tennis Matches");
            Console.WriteLine();
            TeamA.ForEach(item1 =>
            {
                TeamB.ForEach(item2 => {
                    if (item1.Country != item2.Country)
                    {
                        Console.WriteLine(item1.Name + "(A)" + "(" + item1.Country + ")" + " vs " + item2.Name + "(B)" + "(" + item2.Country + ")");
                    }

                });
                Console.WriteLine();

            });
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            var players = GetPlayes();
          
            var shuffledPlayers = players.OrderBy(a => Guid.NewGuid()).ToList();
            var halfWay = shuffledPlayers.Count / 2;
            var TeamA = shuffledPlayers.Take(halfWay).ToList();      
            var TeamB = shuffledPlayers.Skip(halfWay).ToList();
            PrintPossibleMatches(TeamA, TeamB);                   

        }
    }
}
