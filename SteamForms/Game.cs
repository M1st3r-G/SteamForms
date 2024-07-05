using System;

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
}
