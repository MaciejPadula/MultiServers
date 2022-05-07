using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServers.InstanceManagement
{
    internal class Server
    {
        private String jarFile;
        private String xmx;
        private String xms;
        private String path;
        Process serverProcess = new Process();
        StreamWriter consoleStreamWriter = null;
        public event EventHandler<DataReadEventArgs> DataRead;

        public Server(string path, string jarFile, string xmx, string xms)
        {
            this.path = path;
            this.jarFile = jarFile;
            this.xmx = xmx;
            this.xms = xms;
        }
        public Server setJarFile(String jarFile)
        {
            this.jarFile = jarFile;
            return this;
        }
        public Server setXMX(String xmx)
        {
            this.xmx = xmx;
            return this;
        }
        public Server setXMS(String xms)
        {
            this.xms = xms;
            return this;
        }
        public void runServer()
        {
            //serverProcess.Kill();
            serverProcess = new Process();
            serverProcess.StartInfo.CreateNoWindow = true;
            serverProcess.StartInfo.UseShellExecute = false;

            serverProcess.StartInfo.FileName = "java";
            serverProcess.StartInfo.Arguments = "-jar -Xms" + this.xms + "M -Xmx" + xmx + "M " + jarFile + " nogui";

            serverProcess.StartInfo.RedirectStandardInput = true;
            serverProcess.StartInfo.RedirectStandardOutput = true;
            serverProcess.StartInfo.RedirectStandardError = true;

            serverProcess.OutputDataReceived += new DataReceivedEventHandler(datarecived);
            serverProcess.ErrorDataReceived += new DataReceivedEventHandler(datarecived);

            serverProcess.Start();
            consoleStreamWriter = serverProcess.StandardInput;
            serverProcess.BeginOutputReadLine();
            serverProcess.BeginErrorReadLine();
        }
        public void killServer()
        {
            //this.sendCommand("stop");
            this.serverProcess.Kill();
        }
        void datarecived(object sender, DataReceivedEventArgs e)
        {            
            DataRead?.Invoke(this, new DataReadEventArgs(e.Data + "\r\n"));
        }
        public void sendCommand(String command)
        {
            if(consoleStreamWriter != null)
            {
                consoleStreamWriter.WriteLine(command);
            }
        }
    }
    public class DataReadEventArgs : EventArgs
    {
        private String message;
        public DataReadEventArgs(string message)
        {
            this.message = message;
        }
        public String getMessage()
        {
            return this.message;
        }
    }
}
