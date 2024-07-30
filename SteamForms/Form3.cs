using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;

namespace SteamForms
{
    public partial class WndwMain : Form
    {
        public static Game[] games;

        private string ApiKey => WndwSettings.CurrentSettings.ApiKey;
        private long PlayerID => WndwSettings.CurrentSettings.PlayerID;

        public WndwMain()
        {
            InitializeComponent();
        }

        private void syncLibrary()
        {
            string link = @"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=" + ApiKey + "&steamid=" + PlayerID.ToString() + "&format=json";
            WebRequest webRequest = WebRequest.Create(link);

            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {
                string strContent = reader.ReadToEnd();
                JObject jresponse = (JObject)JObject.Parse(strContent)["response"];
                JArray gamesAsJArray = (JArray)jresponse["games"];
                games = (from JToken item in gamesAsJArray
                         select new Game((int)item["appid"], (int)item["playtime_forever"], (long)item["rtime_last_played"])).ToArray();
            }
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            Hide();
            new WndwLibrary().ShowDialog();
            Show();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            Hide();
            new WndwNews().ShowDialog();
            Show();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Hide();
            new WndwCompare().ShowDialog();
            Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new WndwSettings().ShowDialog();
        }

        private void WndwMain_Shown(object sender, EventArgs e)
        {
            WndwSettings.Init();
            Console.WriteLine(WndwSettings.CurrentSettings);
            syncLibrary();
        }
    }
}