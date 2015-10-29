using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebPageResponseWindow;

namespace GameChangerConnector
{
    public class DataLoader
    {
        static protected DataLoader m_instance = new DataLoader();

        protected DataLoader() { }

        static public void LoadPlayer()
        {
            m_instance.loadPlayer();
        }

        virtual protected void loadPlayer()
        {
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create(@"https://gc.com/t/fall-2015/scv-bandits-9u-55d391646d3bfb0021125b4d/roster");

            // If required by the server, set the credentials.
            ICredentials credentials = new NetworkCredential(@"paul_brosche@hotmail.com", @"tkmiller");
            request.Credentials = credentials;

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Display the status.
            Console.WriteLine(response.StatusDescription);

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            // Display the content.
            // Console.WriteLine(responseFromServer);
            // MessageBox.Show(responseFromServer);
            WebPageResponseWindow.MainWindow webpageWindow = new MainWindow()
            {
                Text = responseFromServer
            };

            webpageWindow.Show();

            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
