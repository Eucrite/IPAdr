/*******************************************************************/
/**   PROGRAM: Form1.cs(Change name after)                        **/
/**                                                               **/
/**   Program Creation: Tom Yang                                  **/
/**   DATE: 6/24/2017                                             **/
/**   PURPOSE:                                                    **/
/*******************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.Net.Sockets;


namespace IpAdr
{
   public partial class frmIpAdr : Form
   {
      RootObject list;
      public frmIpAdr()
      {
         /**********************************************************/
         /** IMPORTANT                                            **/
         /**********************************************************/
         InitializeComponent();
      }

      private void frmIpAdr_Load(object sender, EventArgs e)
      {

         ShowActiveTcpConnections();

         /** call function to get user ip                         **/
         string ip = getUserIp();
         /** append ip to label IP                                **/
         lblIP.Text += ip;

         /** call function to get user country                    **/
         string country = getUserCountry(ip);
         /** append ip to label country                           **/
         lblLocation.Text += country;

         lblLocalIp.Text += LocalIPAddress();
      }

      /** Function for getting user ip address                    **/
      private string getUserIp()
      {
         /** stores the ip content from the web into a string     **/
         string myIp = new WebClient().DownloadString("http://checkip.dyndns.org");

         /** cutting front side, size holds first index of ip     **/
         /** address                                              **/
         int size = myIp.IndexOf(": ")+1;
         /** substring to cut off everything in front of ip       **/
         myIp = myIp.Substring(size, myIp.Length - size);

         /** cutting back side, size holds index immediately after**/
         /** ip address                                           **/
         size = myIp.IndexOf('<');
         /** substring to cut off everything behind ip address    **/
         myIp = myIp.Substring(1, size - 1);

         return myIp;
         /** for loop to cut the front                            **/
         
      }

      private string getUserCountry(string ip)
      {
         /** stores the country info from the web into a string   **/
         string country = new WebClient().DownloadString("https://ipapi.co/"+ip+"/json/");
         /** size holds first index of ip address                 **/
        
         list = JsonConvert.DeserializeObject<RootObject>(country);
         country = list.country_name;
         return country;
      }
      /*************************************************************/
      /** Source:https://stackoverflow.com/questions/13806435/how **/
      /** -can-i-get-all-the-the-active-tcp-connections-using-net **/
      /** -framework-no-unmana                                    **/
      /*************************************************************/
      private void ShowActiveTcpConnections()
      {
         this.dgvIpAdr.Rows.Clear();
         /**dataGridView1.Refresh();**/
         IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
         TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();
         foreach (TcpConnectionInformation c in connections)
         {
            Console.WriteLine("{0} <==> {1}",
                              c.LocalEndPoint.ToString(),
                              c.RemoteEndPoint.ToString());

            string ipAd = c.RemoteEndPoint.ToString();
            if(ipAd.Substring(0,3) == "198")
            {
               continue;
            }
            ipAd = ipAd.Substring(0, ipAd.IndexOf(':'));
            string country = getUserCountry(ipAd);

            /** We will revisit this **/
            if(list.country == "null")
            {
               continue;
            }

            var request = WebRequest.Create("http://www.geognos.com/api/en/countries/flag/"+list.country+".png");

            var response = request.GetResponse();
            var stream = response.GetResponseStream();
            this.dgvIpAdr.Rows.Add(Bitmap.FromStream(stream), country, ipAd);
            
         }
      }

      private void btnRefresh_Click(object sender, EventArgs e)
      {
         ShowActiveTcpConnections();
      }

      private string LocalIPAddress()
      {
         string localIP;
         using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
         {
            socket.Connect("8.8.8.8", 65530);
            IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
            localIP = endPoint.Address.ToString();
         }
         return localIP;
      }
   }
}

public class RootObject
{
   public string ip { get; set; }
   public string city { get; set; }
   public string region { get; set; }
   public string country { get; set; }
   public string country_name { get; set; }
   public string postal { get; set; }
   public double latitude { get; set; }
   public double longitude { get; set; }
   public string timezone { get; set; }
   public string asn { get; set; }
   public string org { get; set; }
}