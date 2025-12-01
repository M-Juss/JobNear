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
            var data = new Dictionary<string, (double lat, double lon)>();

            if (string.IsNullOrWhiteSpace(input))
                return data;

            string query = Uri.EscapeDataString(input);

            string url =
                $"https://api.geoapify.com/v1/geocode/autocomplete?text={query}&filter=countrycode:ph&apiKey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    JObject json = JObject.Parse(response);

                    var features = json["features"] as JArray;
                    if (features == null || features.Count == 0)
                        return data;

                    foreach (var f in features)
                    {
                        var props = f["properties"];
                        if (props == null) continue;

                        string formatted = props["formatted"]?.ToString();
                        double lat = props["lat"]?.ToObject<double>() ?? 0;
                        double lon = props["lon"]?.ToObject<double>() ?? 0;

                        if (!string.IsNullOrEmpty(formatted))
                            data[formatted] = (lat, lon);
                    }
                }
                catch
                {
                    return data;
                }
            }

            return data;
        }

        public void ApplyAutoComplete(TextBox textBox, Dictionary<string, (double lat, double lon)> suggestionData)
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            foreach (var key in suggestionData.Keys)
                autoComplete.Add(key);

            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = autoComplete;

            string current = textBox.Text;
            textBox.Text = "";
            textBox.Text = current;
            textBox.SelectionStart = textBox.Text.Length;
        }
    }
}
