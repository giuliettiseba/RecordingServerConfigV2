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
    class TestsHelper
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

        internal bool EstablishedConections(string port)
        {

            bool isAvailable = true;
            // Evaluate current system tcp connections. This is the same information provided
            // by the netstat command line application, just in .Net strongly-typed object
            // form.  We will look through the list, and if our port we would like to use
            // in our TcpClient is occupied, we will set isAvailable to false.

            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == int.Parse(port))
                {
                    isAvailable = false;
                    break;
                }
            }

            return isAvailable;


        }

        internal String CheckPort(string ip, string port)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(ip, int.Parse(port));
                    return "Endpoint found at IP: " + ip + " Port: " + port;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return e.Message;
                }
            }

        }








        internal string ReadHTTP(string authorizationServerAddress)
        {
            HttpWebRequest request = WebRequest.Create(authorizationServerAddress) as HttpWebRequest;


            try
            {
                //request.Accept = "application/xrds+xml";  
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                WebHeaderCollection header = response.Headers;

                var encoding = ASCIIEncoding.ASCII;
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    string responseText = reader.ReadToEnd();
                    return header + " - " + responseText;
                }

            }
            catch (Exception r)
            {
                return r.Message;
            }
        }









        internal string ReadIDPResponse(string authorizationServerAddress)
        {

            /// Just seek the 401, nothing else. 
            /// Kestrel Web Server. 
            authorizationServerAddress += "/connect/token";
            try
            {
                using (WebClient client = new WebClient())
                {
                    System.Collections.Specialized.NameValueCollection postData =
                        new System.Collections.Specialized.NameValueCollection()
                       {
              { "grant_type",  "windows_auth"},
              { "scope", "write:client" },
              { "client_id", "winauthclient" }
                       };
                    Encoding.UTF8.GetString(client.UploadValues(authorizationServerAddress, postData));
                }
                return "";
            }
            catch (Exception e)
            {
                if (e.Message == "The remote server returned an error: (401) Unauthorized.")
                    return "IDP server online";
                else

                    return e.Message;
            }


        }
    }
}
