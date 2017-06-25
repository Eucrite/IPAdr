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

namespace IpAdr
{
   public partial class frmIpAdr : Form
   {
      public frmIpAdr()
      {
         /**********************************************************/
         /** IMPORTANT                                            **/
         /**********************************************************/
         InitializeComponent();
      }

      private void frmIpAdr_Load(object sender, EventArgs e)
      {
         /** call function to get user ip                         **/
         string ip = getUserIp();
         /** append ip to label IP                                **/
         lblIP.Text += ip;

         /** call function to get user country                    **/
         string country = getUserCountry(ip);
         /** append ip to label country                           **/
         lblLocation.Text += country;
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
         string country = new WebClient().DownloadString("http://www.ip2nation.com/");
         /** size holds first index of ip address                 **/
         int size = country.IndexOf("IP: " + ip);
         /** substring to cut off everything infront of ip        **/
         /** necessary due to multiple areas with ip on site      **/
         country = country.Substring(size, country.Length-size);


         /** size holds first index of country name               **/
         size = country.IndexOf('>');
         /** substring cuts off everything infront of country     **/
         country = country.Substring(size, country.Length - size);

         /** size holds index immediately after the country name  **/
         size = country.IndexOf('<');
         /** substring to cut everything after country            **/
         country = country.Substring(1, size-1);

         return country;
      }
   }
}
