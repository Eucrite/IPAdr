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

         string country = getUserCountry(ip);
         lblLocation.Text += country;
      }

      /** Function for getting user ip address                    **/
      private string getUserIp()
      {
         /** stores the ip content from the web into a string     **/
         string myIp = new WebClient().DownloadString("http://checkip.dyndns.org");
         /** for loop to cut the front                            **/
         for (int i=0; i < myIp.Length; i++)
         {
            if (myIp[i]=='A' && myIp.Substring(i, 7)=="Address")
            {
               myIp = myIp.Substring(i+9, myIp.Length-i-9);
               /** for loop to cut the back                       **/
               for (int j=0; j<myIp.Length; j++)
               {
                  if(myIp[j] == '<')
                  {
                     myIp = myIp.Substring(0, j);
                     break;
                  }
               }
               break;
            }
         }
         return myIp;
      }

      private string getUserCountry(string ip)
      {
         string country = new WebClient().DownloadString("http://www.ip2nation.com/");
         int size = country.IndexOf("IP: " + ip);
         country = country.Substring(size, country.Length-size);
         size = country.IndexOf('>');
         country = country.Substring(size, country.Length - size);


         size = country.IndexOf('<');
         country = country.Substring(1, size-1);
         return country;
      }
   }
}
