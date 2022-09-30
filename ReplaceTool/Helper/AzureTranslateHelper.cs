using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTool.Helper
{
    public class AzureTranslateHelper
    {
        
        public static async Task<string[]> AzureTranaslte(string input, string[] langs)
        {
            string host = "https://api.cognitive.microsofttranslator.com";
            //string[] langs = { "zh-cn", "en", "es", "it", "pl", "nl", "pt", "fr", "de" };
            langs = langs.Select(lang => "&to=" + lang).ToArray();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string route = "/translate?api-version=3.0" + string.Join("", langs);
            string subscriptionKey = "f1e8571ed5044dc38937e553720086a8";
            object[] body = new object[] { new { Text = input } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage())
                {
                    string APP_REGION = "westeurope";
                    request.Method = HttpMethod.Post;
                    request.RequestUri = new Uri(host + route);
                    request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                    request.Headers.Add("Ocp-Apim-Subscription-Region", APP_REGION);
                    // Send the request and get response.

                    HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                    // Read response as a string.
                    string result = await response.Content.ReadAsStringAsync();
                    TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(result);
                    // Iterate over the deserialized results.
                    var res = deserializedOutput.First().Translations.Select(u => u.Text).ToArray();

                    return res;
                }
            }
        }

        public class TranslateItem
        {
            public string lang { get; set; }
            public string key { get; set; }
            public string value { get; set; }

        }

        public class TranslationResult
        {
            public DetectedLanguage DetectedLanguage { get; set; }
            public TextResult SourceText { get; set; }
            public Translation[] Translations { get; set; }
        }
        public class DetectedLanguage
        {
            public string Language { get; set; }
            public float Score { get; set; }
        }
        public class TextResult
        {
            public string Text { get; set; }
            public string Script { get; set; }
        }
        public class Translation
        {
            public string Text { get; set; }
            public TextResult Transliteration { get; set; }
            public string To { get; set; }
            public Alignment Alignment { get; set; }
            public SentenceLength SentLen { get; set; }
        }

        public class Alignment
        {
            public string Proj { get; set; }
        }

        public class SentenceLength
        {
            public int[] SrcSentLen { get; set; }
            public int[] TransSentLen { get; set; }
        }
    }
}
