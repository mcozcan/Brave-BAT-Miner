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
    
        public partial class Form1 : Form
    {
 
       public int stop = 1;
        public int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();

            int stop = 1;
            timer1.Interval = 4200;
            timer1.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            while (stop>0)
            {
            
                for(int i = 0; i<999; i++)
                {
                    //        string myFavoritesPath =
                    //  Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

                    //  MyProcess myProcess = new MyProcess();

                    //  myProcess.OpenWithStartInfo();
                    // Thread.Sleep(10000);
                    // myProcess.OpenWithStartInfo();
                    ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe");
                    startInfo.Arguments = "https://brave.com/talk/";
                    startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    Process.Start(startInfo);


                    Thread.Sleep(20000);

                    string processName = "brave"; // Kapatmak İstediğimiz Program
                    Process[] processes = Process.GetProcesses();// Tüm Çalışan Programlar
                    foreach (Process process in processes)
                    {
                        if (process.ProcessName == processName)
                        {
                            process.Kill();

                        }
                        


                    }

                    Thread.Sleep(400000);

                    ProcessStartInfo startInfo2 = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe");
                    startInfo2.Arguments = "https://www.binance.com/tr/markets";
                    startInfo2.WindowStyle = ProcessWindowStyle.Minimized;
                    Process.Start(startInfo);


                    Thread.Sleep(20000);

                    string processName2 = "brave"; // Kapatmak İstediğimiz Program
                    Process[] processes2 = Process.GetProcesses();// Tüm Çalışan Programlar
                    foreach (Process process2 in processes2)
                    {
                        if (process2.ProcessName == processName2)
                        {
                            process2.Kill();

                        }


                    }

                    Thread.Sleep(400000);

                    ProcessStartInfo startInfo3 = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe");
                    startInfo3.Arguments = "https://cakedefi.com/mobile-app/?utm_source=brave&utm_medium=braveSI&utm_campaign=braveSI2Jun22/";
                    startInfo3.WindowStyle = ProcessWindowStyle.Minimized;
                    Process.Start(startInfo);


                    Thread.Sleep(20000);

                    string processName3 = "brave"; // Kapatmak İstediğimiz Program
                    Process[] processes3 = Process.GetProcesses();// Tüm Çalışan Programlar
                    foreach (Process process3 in processes3)
                    {
                        if (process3.ProcessName == processName3)
                        {
                            process3.Kill();

                        }


                    }

                    Thread.Sleep(400000);

                    ProcessStartInfo startInfo4 = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe");
                    startInfo4.Arguments = "https://basicattentiontoken.org/";
                    startInfo4.WindowStyle = ProcessWindowStyle.Minimized;
                    Process.Start(startInfo);


                    Thread.Sleep(20000);

                    string processName4 = "brave"; // Kapatmak İstediğimiz Program
                    Process[] processes4 = Process.GetProcesses();// Tüm Çalışan Programlar
                    foreach (Process process4 in processes4)
                    {
                        if (process4.ProcessName == processName4)
                        {
                            process4.Kill();

                        }


                    }

                    Thread.Sleep(400000);


                    ProcessStartInfo startInfo5 = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe");
                    startInfo5.Arguments = "https://talk.brave.com/";
                    startInfo5.WindowStyle = ProcessWindowStyle.Minimized;
                    Process.Start(startInfo);


                    Thread.Sleep(20000);

                    string processName5 = "brave"; // Kapatmak İstediğimiz Program
                    Process[] processes5 = Process.GetProcesses();// Tüm Çalışan Programlar
                    foreach (Process process5 in processes5)
                    {
                        if (process5.ProcessName == processName5)
                        {
                            process5.Kill();

                        }


                    }

                    Thread.Sleep(400000);



                    /*
                    var psi = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,

                        FileName = "https://brave.com/talk/",

                  
                  
                };

         
                    
                 
                    
                    Process.Start(psi);


                    

                                  Thread.Sleep(420000);

                                  var psi2 = new ProcessStartInfo
                                                      {
                                      UseShellExecute = true,
                                      FileName = "https://www.binance.com/tr/markets",
                                     
                                      CreateNoWindow = true,
                                      WindowStyle = ProcessWindowStyle.Hidden,
                                   



                                  };
                                                      Process.Start(psi2);

                                  Thread.Sleep(420000);
                                  var psi3 = new ProcessStartInfo
                                                      {
                                                          FileName = "https://brave.com/talk/",
                                                          UseShellExecute = true,
                                                      };
                                                      Process.Start(psi3);

                                  Thread.Sleep(420000);
                                  var psi4 = new ProcessStartInfo
                                                      {
                                                          FileName = "https://basicattentiontoken.org/",
                                                          UseShellExecute = true,
                                                      };
                                                      Process.Start(psi4);

                                  Thread.Sleep(420000);
                                  var psi5 = new ProcessStartInfo
                                                      {
                                                          FileName = "https://talk.brave.com/",
                                                          UseShellExecute = true,
                                                      };
                                                      Process.Start(psi5);

                                  

                         */

                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();

            timer1.Enabled = false;
            stop = -1;
            Thread.Sleep(3000);
            Environment.Exit(0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            timer2.Interval = 1000;
            timer2.Enabled = true;


            // Process.Start(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
           

            label26.Text = DateTime.Now.ToShortTimeString();
            label27.Text = DateTime.Now.ToLongDateString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
                 var psi = new ProcessStartInfo
            {
                FileName = "https://linktr.ee/mcozcan",
                UseShellExecute = true,
            };
            Process.Start(psi);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            while(c == 0)
            {
               
                c++;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }

}