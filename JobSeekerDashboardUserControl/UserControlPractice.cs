using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class UserControlPractice : UserControl
    {
        private Timer debounceTimer;
        private Dictionary<string, (double lat, double lon)> suggestionData = new Dictionary<string, (double lat, double lon)>();
        public UserControlPractice()
        {
            InitializeComponent();

            debounceTimer = new Timer();
            debounceTimer.Interval = 300; // 3 seconds
            debounceTimer.Tick += DebounceTimer_Tick;
        }

        private void UserControlPractice_Load(object sender, EventArgs e)
        {

        }

        private async void address_input_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();

            // ✅ Check if the typed text matches a suggestion
            if (suggestionData.ContainsKey(address_input.Text))
            {
                var coords = suggestionData[address_input.Text];
                lat_label.Text = $"Lat: {coords.lat}";
                lng_label.Text = $"Lon: {coords.lon}";
            }
        }

        private async void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();

            if (address_input.Text.Length < 1)
            {
                address_input.AutoCompleteCustomSource = null;
                return;
            }

            string apiKey = "953cbdb1392e47c9845e09578bd41c6d";
            string query = Uri.EscapeDataString(address_input.Text);
            string url = $"https://api.geoapify.com/v1/geocode/autocomplete?text={query}&filter=countrycode:ph&format=json&apiKey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    JObject json = JObject.Parse(response);
                    var results = json["results"];

                    suggestionData.Clear();
                    AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

                    foreach (var r in results)
                    {
                        string formatted = r["formatted"].ToString();
                        double lat = (double)r["lat"];
                        double lon = (double)r["lon"];

                        suggestionData[formatted] = (lat, lon);
                        autoComplete.Add(formatted);
                    }

                    // ✅ Compare new results with old ones
                    bool changed = true;
                    if (address_input.AutoCompleteCustomSource != null &&
                        address_input.AutoCompleteCustomSource.Count == autoComplete.Count)
                    {
                        changed = false;
                        for (int i = 0; i < autoComplete.Count; i++)
                        {
                            if (address_input.AutoCompleteCustomSource[i] != autoComplete[i])
                            {
                                changed = true;
                                break;
                            }
                        }
                    }

                    if (changed)
                    {
                        address_input.AutoCompleteMode = AutoCompleteMode.Suggest;
                        address_input.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        address_input.AutoCompleteCustomSource = autoComplete;

                        // ✅ Force dropdown refresh
                        string current = address_input.Text;
                        address_input.Text = "";
                        address_input.Text = current;
                        address_input.SelectionStart = address_input.Text.Length;
                    }
                }
                catch
                {
                    address_input.AutoCompleteCustomSource = null;
                }
            }
        }


    }
}
