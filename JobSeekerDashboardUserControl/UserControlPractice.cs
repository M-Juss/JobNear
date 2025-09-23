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
        public UserControlPractice()
        {
            InitializeComponent();
        }

        private void UserControlPractice_Load(object sender, EventArgs e)
        {

        }

        private Dictionary<string, (double lat, double lon)> suggestionData = new Dictionary<string, (double lat, double lon)>();
        private async void address_input_TextChanged(object sender, EventArgs e)
        {
            if (address_input.Text.Length < 1)
            {
                address_listbox.Visible = false;
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
                    address_listbox.Items.Clear();

                    foreach (var r in results)
                    {
                        string formatted = r["formatted"].ToString();
                        double lat = (double)r["lat"];
                        double lon = (double)r["lon"];

                        suggestionData[formatted] = (lat, lon);
                        address_listbox.Items.Add(formatted);
                    }

                    address_listbox.Visible = address_listbox.Items.Count > 0;
                }
                catch
                {
                    address_listbox.Visible = false;
                }
            }

        }

        private void address_listbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (address_listbox.SelectedItem != null)
            {
                string selected = address_listbox.SelectedItem.ToString(); // ✅ define selected
                address_input.Text = selected;
                address_listbox.Visible = false;

                if (suggestionData.ContainsKey(selected))
                {
                    var coords = suggestionData[selected];
                    lat_label.Text = $"Lat: {coords.lat}";
                    lng_label.Text = $"Lon: {coords.lon}";
                }
            }
        }

        private void address_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
