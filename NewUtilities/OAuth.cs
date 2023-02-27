using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;

namespace NewUtilities
{
    public class OAuth
    {
        public string GetToken(string username, string password, string clientId, string grantType)
        {
            string result = "";

            string data = $"username={username}&password={password}&client_id={clientId}&grant_type={grantType}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = client.PostAsync("https://thorium.disruptorbeam.com/oauth2/token", new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded")).Result)
                    {
                        using (HttpContent content = res.Content)
                        {
                            result = content.ReadAsStringAsync().Result;

                            JObject o = JObject.Parse(result);

                            result = o["access_token"].ToString();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                result = "";
            }

            return result;
        }
    }
}
