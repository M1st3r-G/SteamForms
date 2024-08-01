using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace SteamForms
{
    public partial class WndwLibrary : Form
    {
        private enum FunctionType
        {
            Oldie, Random, Shame, Top
        }

        Random rnd = new Random();

        FunctionType currentFunctionType;

        Game[] currentOptions;
        int currentIndex;

        public WndwLibrary()
        {
            InitializeComponent();
            SetRandomOldieGameToDisplay();
        }

        #region Methods

        private void SetRandomGameToDisplay()
        {
            currentOptions = WndwMain.games.Select(x => (x, rnd.Next())).OrderBy(tuple => tuple.Item2).Select(tuple => tuple.Item1).ToArray();
            currentIndex = 0;
            SetGameToDisplay(currentOptions[currentIndex]);
        }

        private void SetRandomShameGameToDisplay()
        {
            currentOptions = WndwMain.games.Where(g => g.RtimeLastPlayed == 0).Select(x => (x, rnd.Next())).OrderBy(tuple => tuple.Item2).Select(tuple => tuple.Item1).ToArray();
            currentIndex = 0;
            SetGameToDisplay(currentOptions[currentIndex]);
        }

        private void SetRandomOldieGameToDisplay(int minPlayTime = 120, long minPlayOffset = 15721200)
        {
            long currentUnix = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            currentOptions = WndwMain.games.Where(g => g.PlaytimeForever > minPlayTime && currentUnix - g.RtimeLastPlayed > minPlayOffset).Select(x => (x, rnd.Next())).OrderBy(tuple => tuple.Item2).Select(tuple => tuple.Item1).ToArray();
            
            currentIndex = 0;
            SetGameToDisplay(currentOptions[currentIndex]);
        }

        private void SetTopGameToDisplay() // int amount = 15
        {
            currentOptions = WndwMain.games.OrderByDescending(game => game.PlaytimeForever).ToArray(); //.Take(amount)

            currentIndex = 0;
            SetGameToDisplay(currentOptions[currentIndex]);
        }

        private void SetGameToDisplay(Game game)
        {
            string link = @"https://store.steampowered.com/api/appdetails?appids=" + game.AppId;
            WebRequest webRequest = WebRequest.Create(link);

            using (WebResponse response = webRequest.GetResponse())
            using (Stream content = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(content))
            {
                string strContent = reader.ReadToEnd();
                JObject jresponse = JObject.Parse(strContent);
                JObject gameInfo = (JObject)jresponse[game.AppId.ToString()];
                if (!(bool)gameInfo["success"]) {
                    btnNext_Click(null, null);
                    return;
                }
                JObject data = (JObject)gameInfo["data"];

                lblPlaytime.Text = $"{(game.PlaytimeForever / 60f):F2}h";
                lblLastPlayed.Text = game.GetLastPlayedDate();

                tbxGameName.Text = (string)data["name"];
                tbxDesc.Text = (string)data["short_description"];
                string imgLink = (string)data["header_image"];
                picGame.ImageLocation = imgLink;
            }

            lblCurrent.Text = $"{currentIndex + 1}/{currentOptions.Length}";
        }

        #endregion

        #region Buttons
        private void rbShame_Click(object sender, EventArgs e)
        {
            if (currentFunctionType == FunctionType.Shame) return;
            currentFunctionType = FunctionType.Shame;
            SetRandomShameGameToDisplay();
        }

        private void rbRandom_Click(object sender, EventArgs e)
        {
            if (currentFunctionType == FunctionType.Random) return;
            currentFunctionType = FunctionType.Random;
            SetRandomGameToDisplay();
        }

        private void rbOld_Click(object sender, EventArgs e)
        {
            if (currentFunctionType == FunctionType.Oldie) return;
            currentFunctionType = FunctionType.Oldie;
            SetRandomOldieGameToDisplay();
        }

        private void rbTop_CheckedChanged(object sender, EventArgs e)
        {
            if (currentFunctionType == FunctionType.Top) return;
            currentFunctionType = FunctionType.Top;
            SetTopGameToDisplay();
        }

        #endregion

        private void btnSteam_Click(object sender, EventArgs e)
        {
            int currentId = currentOptions[currentIndex].AppId;
            if (currentId < 0) return;
            Process.Start($"steam://nav/games/details/{currentId}");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex == currentOptions.Length) currentIndex = 0;

            SetGameToDisplay(currentOptions[currentIndex]);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = currentOptions.Length - 1;

            SetGameToDisplay(currentOptions[currentIndex]);
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();
    }
}
