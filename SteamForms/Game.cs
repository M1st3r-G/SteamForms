using System;
using System.Collections.Generic;

namespace SteamForms
{
    public class Game
    {
        public int AppId { get; set; }
        public int PlaytimeForever { get; set; }
        public long RtimeLastPlayed { get; set; } // Unix-Timestamp

        public Game(int appID, int Playtime, long lastPlayed)
        {
            AppId = appID;
            PlaytimeForever = Playtime;
            RtimeLastPlayed = lastPlayed;
        }

        public string GetLastPlayedDate() => RtimeLastPlayed == 0 ? "Never" : DateTimeOffset.FromUnixTimeSeconds(RtimeLastPlayed).DateTime.ToString();
        
        public override string ToString() => $"The Game {AppId} was played {PlaytimeForever / 60f:2}h (Last Played: {GetLastPlayedDate()})";
    }

    public class GameComparer : IEqualityComparer<Game>
    {
        public bool Equals(Game x, Game y)
        {
            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the game's ids are equal.
            return x.AppId == y.AppId;
        }

        public int GetHashCode(Game game)
        {
            return (game is null) ? 0 : game.AppId.GetHashCode();
        }
    }
}
