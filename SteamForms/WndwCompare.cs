using Newtonsoft.Json.Linq;
using System;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class WndwCompare : Form
    {
        JArray Friends;
        public WndwCompare()
        {
            InitializeComponent();
        }

        private void WndwCompare_Load(object sender, EventArgs e)
        {
            GetFriendIDs();
            AdjustDropDown();
            AdjustName();
        }

        private void GetFriendIDs()
        {
            string linkForIds = @"http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=" + WndwSettings.CurrentSettings.ApiKey + "&steamid=" + WndwSettings.CurrentSettings.PlayerID.ToString() + "&relationship=friend";
            WebRequest webRequest = WebRequest.Create(linkForIds);
            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {

                Friends = (JArray)JObject.Parse(reader.ReadToEnd())["friendslist"]["friends"];
            }
        }

        private void AdjustDropDown()
        {
            string ids = Friends.Aggregate("", (s, token) => s + token["steamid"].Value<string>() + ",");
            string linkForNames = @"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + WndwSettings.CurrentSettings.ApiKey + "&steamids=" + ids;

            WebRequest webRequestForNames = WebRequest.Create(linkForNames);
            using (WebResponse responseForNames = webRequestForNames.GetResponse())
            using (Stream contentForNames = responseForNames.GetResponseStream())
            using (StreamReader reader = new StreamReader(contentForNames))
            {
                var Accounts = JObject.Parse(reader.ReadToEnd())["response"]["players"];

                foreach (JObject Account in Accounts)
                {
                    string realName = Account["realname"] == null ? "privat" : Account["realname"].Value<string>();

                    dpdnFriends.Items.Add($"{Account["personaname"].Value<string>()} ({realName})");
                }
            }
        }

        private void AdjustName()
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
            }
        }
    }
}
