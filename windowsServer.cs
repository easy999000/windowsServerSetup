using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setup
{
    public class windowsServer
    {
        public void run(char i)
        {
            string s2 = Environment.Version.ToString();
             
            string serversPath1 = System.Configuration.ConfigurationManager.AppSettings["serversPath1"];
             
            if (i== '2')
            {
                serversPath1 = "/u " + serversPath1;
            }
            string appPath = System.IO.Path.Combine("InstallUtil.exe ");
            Process pro = new Process();
            pro.StartInfo.FileName = appPath; 

            pro.StartInfo.Arguments = serversPath1;

            pro.StartInfo.UseShellExecute = false;
            bool b1 = pro.Start();

        }
    }
}
