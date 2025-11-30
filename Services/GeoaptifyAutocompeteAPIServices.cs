using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Services
{
    public class GeoaptifyAutocompeteAPIServices
    {
        private readonly string apiKey = "953cbdb1392e47c9845e09578bd41c6d";

        /// <summary>
        /// Calls Geoapify API and returns a dictionary of formatted address + coordinates.
        /// </summary>
        public async Task<Dictionary<string, (double lat, double lon)>> GetSuggestionsAsync(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new Dictionary<string, (double lat, double lon)>();

            string query = Uri.EscapeDataString(input);
            string url = $"https://api.geoapify.com/v1/geocode/autocomplete?text={query}&filter=countrycode:ph&format=json&apiKey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    JObject json = JObject.Parse(response);
                    var results = json["results"];

                    var data = new Dictionary<string, (double lat, double lon)>();

                    foreach (var r in results)
                    {
                        string formatted = r["formatted"].ToString();
                        double lat = (double)r["lat"];
                        double lon = (double)r["lon"];

                        data[formatted] = (lat, lon);
                    }

                    return data;
                }
                catch
                {
                    return new Dictionary<string, (double lat, double lon)>();
                }
            }
        }

        /// <summary>
        /// Helper: Updates a TextBox autocomplete with suggestions.
        /// </summary>
        public void ApplyAutoComplete(TextBox textBox, Dictionary<string, (double lat, double lon)> suggestionData)
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            foreach (var key in suggestionData.Keys)
                autoComplete.Add(key);

            // ✅ Compare old vs new suggestions
            bool changed = true;
            if (textBox.AutoCompleteCustomSource != null &&
                textBox.AutoCompleteCustomSource.Count == autoComplete.Count)
            {
                changed = false;
                for (int i = 0; i < autoComplete.Count; i++)
                {
                    if (textBox.AutoCompleteCustomSource[i] != autoComplete[i])
                    {
                        changed = true;
                        break;
                    }
                }
            }

            if (changed)
            {
                textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox.AutoCompleteCustomSource = autoComplete;

                // ✅ Trick: Reset text to refresh dropdown
                string current = textBox.Text;
                textBox.Text = "";
                textBox.Text = current;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

    }
}
