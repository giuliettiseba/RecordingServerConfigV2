using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace RecordingServerConfigV2
{
    internal class TestsHelper
    {

        internal string CheckEndPoint(string port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint tcpi in tcpConnInfoArray)
            {
                if (tcpi.Port == int.Parse(port))
                {
                    return "Edpoint found at port: " + port;
                }
            }
            return "No endpoint found at port: " + port;
        }

        internal string[] GetDate(string msWebApiAddress)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://" + msWebApiAddress);
                request.Date = DateTime.Now;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string[] ret = { request.Headers.Get("Date"), response.Headers.Get("Date") };
                    return ret;
                }
            }
            catch (Exception e)
            {
                string[] ret = { e.Message, e.Message };
                return ret;
            }

        }

        internal async Task<string> CheckPortAsync(string ip, string port)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    await tcpClient.ConnectAsync(ip, int.Parse(port));
                    if (tcpClient.Connected) return "Endpoint found at IP: " + ip + " Port: " + port;
                    else return "Timeout: " + ip + " Port: " + port;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return e.Message;
                }
            }

        }



        private static readonly HttpClient client = new HttpClient();

        internal async Task<List<KeyValuePair<String, String>>> ReadIDPResponseAsync(string authorizationServerAddress)
        {
            List<KeyValuePair<String, String>> output = new List<KeyValuePair<string, string>>();


            try
            {
                var response = await client.GetStringAsync(authorizationServerAddress + "/.well-known/openid-configuration");

                IDPresponse openidConfiguration = JsonConvert.DeserializeObject<IDPresponse>(response);
                var response2 = await client.GetStringAsync(authorizationServerAddress + "/.well-known/openid-configuration/jwks");
                JwksRoot jwks = JsonConvert.DeserializeObject<JwksRoot>(response2);

                output.Add(new KeyValuePair<String, String>("IDP Server", openidConfiguration.issuer));
                output.Add(new KeyValuePair<String, String>("jwks_uri", openidConfiguration.jwks_uri));
                output.Add(new KeyValuePair<String, String>("authorization_endpoint", openidConfiguration.authorization_endpoint));
                output.Add(new KeyValuePair<String, String>("token_endpoint", openidConfiguration.token_endpoint));
                output.Add(new KeyValuePair<String, String>("userinfo_endpoint", openidConfiguration.userinfo_endpoint));
                output.Add(new KeyValuePair<String, String>("end_session_endpoint", openidConfiguration.end_session_endpoint));
                output.Add(new KeyValuePair<String, String>("check_session_iframe", openidConfiguration.check_session_iframe));
                output.Add(new KeyValuePair<String, String>("revocation_endpoint", openidConfiguration.revocation_endpoint));
                output.Add(new KeyValuePair<String, String>("introspection_endpoint", openidConfiguration.introspection_endpoint));
                output.Add(new KeyValuePair<String, String>("frontchannel_logout_supported", openidConfiguration.frontchannel_logout_supported.ToString()));
                output.Add(new KeyValuePair<String, String>("frontchannel_logout_session_supported", openidConfiguration.frontchannel_logout_session_supported.ToString()));
                output.Add(new KeyValuePair<String, String>("backchannel_logout_supported", openidConfiguration.backchannel_logout_supported.ToString()));
                output.Add(new KeyValuePair<String, String>("backchannel_logout_session_supported", openidConfiguration.backchannel_logout_session_supported.ToString()));



            }
            catch (Exception e)
            {
                output.Add(new KeyValuePair<String, String>("IDP Server: ", e.Message));
            }

            return output;


        }


        public class IDPresponse
        {
            public string issuer { get; set; }
            public string jwks_uri { get; set; }
            public string authorization_endpoint { get; set; }
            public string token_endpoint { get; set; }
            public string userinfo_endpoint { get; set; }
            public string end_session_endpoint { get; set; }
            public string check_session_iframe { get; set; }
            public string revocation_endpoint { get; set; }
            public string introspection_endpoint { get; set; }
            public bool frontchannel_logout_supported { get; set; }
            public bool frontchannel_logout_session_supported { get; set; }
            public bool backchannel_logout_supported { get; set; }
            public bool backchannel_logout_session_supported { get; set; }
            public List<string> scopes_supported { get; set; }
            public List<object> claims_supported { get; set; }
            public List<string> grant_types_supported { get; set; }
            public List<string> response_types_supported { get; set; }
            public List<string> response_modes_supported { get; set; }
            public List<string> token_endpoint_auth_methods_supported { get; set; }
            public List<string> subject_types_supported { get; set; }
            public List<string> id_token_signing_alg_values_supported { get; set; }
            public List<string> code_challenge_methods_supported { get; set; }
        }


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class JwksKey
        {
            public string kty { get; set; }
            public string use { get; set; }
            public string kid { get; set; }
            public string e { get; set; }
            public string n { get; set; }
            public string alg { get; set; }
        }

        public class JwksRoot
        {
            public List<JwksKey> keys { get; set; }
        }
    }

}

