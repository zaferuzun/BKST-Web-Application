using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace Proje1.WebApi
{
    public static class ServiceAuthorization
    {

        static string jsonToken;
        public static string Token
        {
            get
            {
                if (string.IsNullOrEmpty(jsonToken))
                    jsonToken = GetToken();
                return jsonToken;


            }
        }

        public static string URL { get { return "http://testbkst.tarbil.gov.tr/Service/"; } }
        //Servis Kullanıcı adı ve şifresi bakanlık tarafından verilecektir.
        public static string UserName { get { return "TestUser"; } }
        public static string Password { get { return "TestPass@"; } }
        static string GetToken()
        {

            var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>( "grant_type", "password" ),
                        new KeyValuePair<string, string>( "username", UserName ),
                        new KeyValuePair<string, string> ( "Password", Password )
                    };
            var content = new FormUrlEncodedContent(pairs);
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            using (var client = new HttpClient())
            {
                var response = client.PostAsync(URL + "Token", content).Result;
                Console.WriteLine(content);
                string a = response.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(a);
                return json["access_token"].ToString();
            }
        }

    }
}