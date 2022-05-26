using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServers.InstanceManagement
{
    public class SettingsManager
    {
        private string path;
        public SettingsManager(string path)
        {
            this.path = path;
        }
        public static InstanceSettings readInstanceSettings(String path)
        {
            InstanceSettings instanceSettings = new InstanceSettings();
            try
            {
                foreach (var line in File.ReadAllLines(path + "\\server.properties"))
                {
                    if (line.Contains("server-ip="))
                    {
                        instanceSettings.setIpAddress(line.Replace("server-ip=", ""));
                    }
                    else if (line.Contains("server-port="))
                    {
                        instanceSettings.setServerPort(line.Replace("server-port=", ""));
                    }
                    else if (line.Contains("query.port="))
                    {
                        instanceSettings.setServerPort(line.Replace("query.port=", ""));
                    }
                    else if (line.Contains("online-mode="))
                    {
                        instanceSettings.setOnlineMode(bool.Parse(line.Replace("online-mode=", "")));
                    }
                    else if (line.Contains("pvp="))
                    {
                        instanceSettings.setPvp(bool.Parse(line.Replace("pvp=", "")));
                    }
                    else if (line.Contains("max-players="))
                    {
                        instanceSettings.setMaxPlayers(int.Parse(line.Replace("max-players=", "")));
                    }
                    else if (line.Contains("difficulty="))
                    {
                        instanceSettings.setDifficulty(int.Parse(line.Replace("difficulty=", "")));
                    }
                    else if (line.Contains("allow-flight="))
                    {
                        instanceSettings.setAllowFlight(bool.Parse(line.Replace("allow-flight=", "")));
                    }
                    else if (line.Contains("enable-command-block="))
                    {
                        instanceSettings.setEnableCommandBlock(bool.Parse(line.Replace("enable-command-block=", "")));
                    }
                    else
                    {
                        instanceSettings.addOtherSettings(line);
                    }
                }
            }
            catch
            {

            }
            try
            {
                foreach (var line in File.ReadAllLines(path + "\\Instance.info"))
                {
                    if (line.Contains("server-jar="))
                    {
                        instanceSettings.setJarFile(line.Replace("server-jar=", ""));
                    }
                    if (line.Contains("xmx="))
                    {
                        instanceSettings.setXmx(line.Replace("xmx=", ""));
                    }
                    if (line.Contains("xms="))
                    {
                        instanceSettings.setXms(line.Replace("xms=", ""));
                    }
                    if (line.Contains("server-name="))
                    {
                        instanceSettings.setServerName(line.Replace("server-name=", ""));
                    }
                    if (line.Contains("server-version="))
                    {
                        instanceSettings.setServerVersion(line.Replace("server-version=", ""));
                    }
                }
            }
            catch
            {
                
            }
            return instanceSettings;
        }
        public static void saveSettings(String path, InstanceSettings instanceSettings)
        {
            
            try
            {
                String filename = path + "\\server.properties";
                
                File.WriteAllText(filename, "server-ip=" + instanceSettings.getIpAddress() + "\n"
                    + "server-port=" + instanceSettings.getServerPort() + "\n"
                    + "online-mode=" + instanceSettings.getOnlineMode().ToString().ToLower() + "\n"
                    + "pvp=" + instanceSettings.getPvp().ToString().ToLower() + "\n"
                    + "max-players=" + instanceSettings.getMaxPlayers() + "\n"
                    + "difficulty=" + instanceSettings.getDifficulty() + "\n"
                    + "allow-flight=" + instanceSettings.getAllowFlight().ToString().ToLower() + "\n"
                    + "enable-command-block=" + instanceSettings.getEnableCommandBlock().ToString().ToLower() + "\n"
                );
                File.AppendAllLines(filename, instanceSettings.getOtherSettings());
            }
            catch
            {
            }
        }
        public static void saveInfo(String path, InstanceSettings instanceSettings)
        {
            try
            {
                String filename = path + "\\Instance.info";
                File.WriteAllText(filename,
                    "server-name=" + instanceSettings.getServerName() + "\n"
                    + "server-version=" + instanceSettings.getServerVersion() + "\n"
                    + "xmx=" + instanceSettings.getXmx() + "\n"
                    + "xms=" + instanceSettings.getXms() + "\n"
                    + "server-jar=" + instanceSettings.getJarFile()
                );
            }
            catch
            {
            }
        }
    }
}
