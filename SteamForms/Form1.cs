using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SteamForms
{
    public partial class WndwNews : Form
    {
        private JArray newsEntrys;
        private int currentDisplay = 0;
        private const int numberOfResults = 5;

        public WndwNews()
        {
            InitializeComponent();
        }
        private void WndwMain_Shown(object sender, EventArgs e)
        {
            ActiveForm.Text = $"Steam News Helper";

            foreach(Game game in WndwMain.games)
            {
                dpdnGame.Items.Add(game);
            }

            dpdnGame.SelectedIndex = 0;
            LoadGameData(WndwMain.games[0].AppId);
        }

        private void LoadGameData(int appId)
        {
            string link = @"http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=" + appId.ToString() + $"&count={numberOfResults}";
            WebRequest webRequest = WebRequest.Create(link);

            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {
                var result = JObject.Parse(reader.ReadToEnd())["appnews"];
                newsEntrys = (JArray)result["newsitems"];
            }

            DisplayNewsElement(numberOfResults - 1);
        }

        private void DisplayNewsElement(int i)
        {
            if (i < 0) i = numberOfResults - 1;
            if (i > numberOfResults - 1) i = 0;

            currentDisplay = i;

            lblTitle.Text = newsEntrys[i]["title"].Value<string>();
            lblAuthor.Text = newsEntrys[i]["author"].Value<string>();
            rtbxMain.Text = newsEntrys[i]["contents"].Value<string>();
            lblDate.Text = DateTimeOffset.FromUnixTimeSeconds(newsEntrys[i]["date"].Value<long>()).DateTime.ToString();

            lblProgress.Text = $"{i + 1}/{numberOfResults}";
        }

        private void btnPrev_Click(object sender, EventArgs e) => 
            DisplayNewsElement(currentDisplay - 1);

        private void btnNext_Click(object sender, EventArgs e) =>
            DisplayNewsElement(currentDisplay + 1);

        private void button1_Click(object sender, EventArgs e) => Close();

        private void dpdnGame_SelectedIndexChanged(object sender, EventArgs e) =>
            LoadGameData(((Game)dpdnGame.Items[dpdnGame.SelectedIndex]).AppId);
    }
}
