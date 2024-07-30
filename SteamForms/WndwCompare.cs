using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class WndwCompare : Form
    {
        Dictionary<string, long> Friends;
        Game[] sharedGames; // PlayTime is From Friends
        int currendSharedGameIdx = 0;

        #region SetUp

        public WndwCompare()
        {
            Friends = new Dictionary<string, long>();
            InitializeComponent();
        }

        private void WndwCompare_Load(object sender, EventArgs e)
        {
            GetFriendIDs();
            AdjustOwnProfile();
            AdjustDropdown();
        }

        private void GetFriendIDs()
        {
            JArray JFriends;

            string linkForIds = @"http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=" + WndwSettings.CurrentSettings.ApiKey + "&steamid=" + WndwSettings.CurrentSettings.PlayerID.ToString() + "&relationship=friend";
            WebRequest webRequest = WebRequest.Create(linkForIds);
            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {
                JFriends = (JArray)JObject.Parse(reader.ReadToEnd())["friendslist"]["friends"];
            }

            GenerateFriends(JFriends);
        }

        private void GenerateFriends(JArray JFriends)
        {
            string ids = JFriends.Aggregate("", (s, token) => s + token["steamid"].Value<string>() + ",");
            string linkForNames = @"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + WndwSettings.CurrentSettings.ApiKey + "&steamids=" + ids;

            WebRequest webRequestForNames = WebRequest.Create(linkForNames);
            using (WebResponse responseForNames = webRequestForNames.GetResponse())
            using (Stream contentForNames = responseForNames.GetResponseStream())
            using (StreamReader reader = new StreamReader(contentForNames))
            {
                JToken Accounts = JObject.Parse(reader.ReadToEnd())["response"]["players"];

                foreach (JObject Account in Accounts)
                {
                    long steamId = (long)Account["steamid"];
                    string realName = Account["realname"] == null ? "privat" : Account["realname"].Value<string>();
                    string name = $"{Account["personaname"].Value<string>()} ({realName})";

                    Friends.Add(name, steamId);
                }
            }
        }

        private void AdjustOwnProfile()
        {
            string linkForNames = @"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + WndwSettings.CurrentSettings.ApiKey + "&steamids=" + WndwSettings.CurrentSettings.PlayerID;

            WebRequest webRequestForNames = WebRequest.Create(linkForNames);
            using (WebResponse responseForNames = webRequestForNames.GetResponse())
            using (Stream contentForNames = responseForNames.GetResponseStream())
            using (StreamReader reader = new StreamReader(contentForNames))
            {
                JToken Account = JObject.Parse(reader.ReadToEnd())["response"]["players"][0];
                string realName = Account["realname"] == null ? "privat" : Account["realname"].Value<string>();
                tbxMyself.Text = ($"{Account["personaname"].Value<string>()} ({realName})");
                imgUser1.ImageLocation = Account["avatarfull"].ToString();

                tbxNumberUser1.Text = WndwMain.games.Length.ToString();
            }
        }

        private void AdjustDropdown()
        {
            foreach(string name in Friends.Keys) dpdnFriends.Items.Add(name);
        }

        #endregion

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void dpdnFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            long friendId = Friends[dpdnFriends.Items[dpdnFriends.SelectedIndex].ToString()];
            string linkForPFP = @"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + WndwSettings.CurrentSettings.ApiKey + "&steamids=" + friendId;

            WebRequest webRequestForNames = WebRequest.Create(linkForPFP);
            using (WebResponse responseForNames = webRequestForNames.GetResponse())
            using (Stream contentForNames = responseForNames.GetResponseStream())
            using (StreamReader reader = new StreamReader(contentForNames))
            {
                imgUser2.ImageLocation = JObject.Parse(reader.ReadToEnd())["response"]["players"][0]["avatarfull"].ToString();
            }

            UpdateSharedGames(friendId);
        }

        private void UpdateSharedGames(long friendId)
        {
            string otherGames = "http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=" + WndwSettings.CurrentSettings.ApiKey + "&steamid=" + friendId + "&format=json";

            WebRequest webRequest = WebRequest.Create(otherGames);

            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {
                string strContent = reader.ReadToEnd();
                JObject jresponse = (JObject)JObject.Parse(strContent)["response"];
                JArray gamesAsJArray = (JArray)jresponse["games"];
                Game[] friendGames = (from JToken item in gamesAsJArray
                         select new Game((int)item["appid"], (int)item["playtime_forever"], 0)).ToArray();

                tbxNumberUser2.Text = friendGames.Length.ToString();
                sharedGames = friendGames.Where(g => WndwMain.games.Contains(g, new GameComparer())).ToArray(); 
            }

            tbxShared.Text = sharedGames.Length.ToString();

            DisplaySharedGame(0);
        }

        private void DisplaySharedGame(int direction)
        {
            if (direction > 0) currendSharedGameIdx++;
            else if (direction < 0) currendSharedGameIdx--;
            else if (direction == 0) currendSharedGameIdx = 0;

            if (sharedGames is null || sharedGames.Length == 0)
            {
                lblError.Text = "Please Select a Friend with shared Games";
                return;
            }
            if (currendSharedGameIdx >= sharedGames.Length) currendSharedGameIdx = 0;
            else if (currendSharedGameIdx < 0) currendSharedGameIdx = sharedGames.Length - 1;

            Game gameWFTime = sharedGames[currendSharedGameIdx];
            int playTimeOwn = WndwMain.games.FirstOrDefault(g=>g.AppId == gameWFTime.AppId).PlaytimeForever;

            if (!UpdateGameData(gameWFTime.AppId))
            {
                DisplaySharedGame(direction);
                return;
            }

            lblPlaytimeOwn.Text = $"{playTimeOwn / 60f:F2}h";
            lblPlaytimeFriend.Text = $"{gameWFTime.PlaytimeForever / 60f:F2}h";

            (int done, int all) userStats  = UpdateAchievements(gameWFTime.AppId, WndwSettings.CurrentSettings.PlayerID);
            (int done, int all) friedStats = UpdateAchievements(gameWFTime.AppId, Friends[dpdnFriends.Items[dpdnFriends.SelectedIndex].ToString()]);

            lblAchievmentUser1.Text =  $"{userStats.done} / {userStats.all}";
            lblAchievmentUser2.Text = $"{friedStats.done} / {friedStats.all}";

            if (friedStats != (0, 0)) lblError.Text = "";
        }

        private bool UpdateGameData(int gameID)
        {
            string link = @"https://store.steampowered.com/api/appdetails?appids=" + gameID;
            WebRequest webRequest = WebRequest.Create(link);

            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {
                string strContent = reader.ReadToEnd();
                JObject jresponse = JObject.Parse(strContent);
                JObject gameInfo = (JObject)jresponse[gameID.ToString()];
                if (!(bool)gameInfo["success"])
                {
                    return false;
                }
                JObject data = (JObject)gameInfo["data"];

                tbxGameName.Text = (string)data["name"];
                string imgLink = (string)data["header_image"];
                picGame.ImageLocation = imgLink;
            }

            lblCurrent.Text = $"{currendSharedGameIdx + 1}/{sharedGames.Length}";

            return true;
        }

        private (int done, int all) UpdateAchievements(int gameID, long userID)
        {
            string link = @"https://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v0001/?appid=" + gameID + "&key=" + WndwSettings.CurrentSettings.ApiKey + "&steamid=" + userID;
            Console.WriteLine(link);

            WebRequest webRequest = WebRequest.Create(link);
            try
            {
                using (WebResponse response = webRequest.GetResponse())
                using (Stream content = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(content))
                {
                    string strContent = reader.ReadToEnd();
                    JObject jresponse = (JObject)JObject.Parse(strContent)["playerstats"];

                    if (!(bool)jresponse["success"]) { }
                    JArray JAchievements = (JArray)jresponse["achievements"];
                    if(JAchievements is null)
                    {
                        lblError.Text = "Game is scuffed";
                        return (0, 0);
                    }
                    int done;
                    int all = done = 0;

                    foreach (JToken data in JAchievements)
                    {
                        if ((int)data["achieved"] == 1) done++;
                        all++;
                    }

                    return (done, all);
                }
            }
            catch (WebException ex)
            {
                if (ex.Status != WebExceptionStatus.ProtocolError) throw ex;

                HttpWebResponse response = ex.Response as HttpWebResponse ?? throw ex;
                switch ((int)response.StatusCode)
                {
                    case 400:
                        lblError.Text = "Game has no Stats";
                        break;
                    case 403:
                        lblError.Text = "PlayerProfile is private";
                        break;
                    default:
                        throw ex;
                }
            }

            return (0, 0);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            DisplaySharedGame(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplaySharedGame(1);
        }
    }
}
