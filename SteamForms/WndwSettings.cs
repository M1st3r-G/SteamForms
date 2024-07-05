using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace SteamForms
{
    public partial class WndwSettings : Form
    {
        public const string saveFilePath = "saveFile.json";
        public static Settings CurrentSettings = null;

        public static void Init()
        {
            if (!File.Exists(saveFilePath)) new WndwSettings().ShowDialog();
            CurrentSettings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(saveFilePath));
        }

        public WndwSettings()
        {
            InitializeComponent();

            if (File.Exists(saveFilePath))
            {
                tbxApi.Text = CurrentSettings.ApiKey;
                tbxID.Text = CurrentSettings.PlayerID.ToString();
            }
        }

        private void WndwSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbxApi.Text.Length != 32 ||
                !long.TryParse(tbxID.Text, out _) ||
                tbxID.Text.Length != 17)
            {
                lblError.Visible = true;

                e.Cancel = true;   
                return;
            }

            File.WriteAllText(saveFilePath, JsonConvert.SerializeObject(new Settings(tbxApi.Text, long.Parse(tbxID.Text))));
        }
        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        public class Settings
        {
            public string ApiKey { get; set; }
            public long PlayerID { get; set; }

            public Settings(string key, long id)
            {
                ApiKey = key;
                PlayerID = id;
            }
        }
    }
}
