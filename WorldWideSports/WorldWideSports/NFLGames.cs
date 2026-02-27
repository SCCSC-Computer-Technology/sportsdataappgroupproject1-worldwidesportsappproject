using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WorldWideSports
{
    public class NFLGames
    {
        public string GameId { get; set; }
        public string Season { get; set; }
        public byte Week { get; set; }
        public DateTime Gameday { get; set; }
        public TimeSpan Gametime { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public string Stadium { get; set; }

        //default constructor
        public NFLGames(string gameId, string season, byte week, DateTime gameday, TimeSpan gametime, string awayTeam, string homeTeam, string stadium)
        {
            GameId = gameId;
            Season = season;
            Week = week;
            Gameday = gameday;
            Gametime = gametime;
            AwayTeam = awayTeam;
            HomeTeam = homeTeam;
            Stadium = stadium;
        }
        //the ToString method is used to display the game information in a readable format
        public override string ToString()
        {
            return $"Week {Week} | {Gameday:MM/dd/yyyy} {Gametime:hh\\:mm}\n" +
                   $"{AwayTeam} vs {HomeTeam}\n" +
                   $"Stadium: {Stadium}\n" +
                   $"------------------------";
        }
    }
}
