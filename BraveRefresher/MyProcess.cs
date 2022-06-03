using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.ComponentModel;
namespace BraveRefresher
{
  internal class MyProcess
    {
 
    
        public void OpenWithStartInfo()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe");
            Process p = new Process();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            Process.Start(startInfo);
            startInfo.Arguments = "www.northwindtraders.com";
            Process.Start(startInfo);
        }


    }
}
