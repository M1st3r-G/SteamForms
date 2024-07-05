using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.LinkLabel;

namespace SteamForms
{
    public partial class WndwNews : Form
    {
        private JArray newsEntrys;
        private int currentDisplay = 0;
        private readonly int gameId;
        private const int numberOfResults = 5;

        public WndwNews(int pGameId)
        {
            InitializeComponent();
            gameId = pGameId;
        }
        private void WndwMain_Shown(object sender, EventArgs e)
        {
            string link = @"https://store.steampowered.com/api/appdetails?appids=" + gameId;
            WebRequest webRequest = WebRequest.Create(link);
            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {
                JToken gameInfo = JObject.Parse(reader.ReadToEnd())[gameId.ToString()];
                if ((bool)gameInfo["success"]) ActiveForm.Text = $"Steam Updates for {gameInfo["data"]["name"]}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string link = @"http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=" + gameId.ToString() + $"&count={numberOfResults}";
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            DisplayNewsElement(currentDisplay - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplayNewsElement(currentDisplay + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
