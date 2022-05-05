using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServers
{
    public class SettingsManager
    {
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
                    if (line.Contains("server-port="))
                    {
                        instanceSettings.setServerPort(line.Replace("server-port=", ""));
                    }
                    if (line.Contains("online-mode="))
                    {
                        instanceSettings.setOnlineMode(bool.Parse(line.Replace("online-mode=", "")));
                    }
                    if (line.Contains("pvp="))
                    {
                        instanceSettings.setPvp(bool.Parse(line.Replace("pvp=", "")));
                    }
                    if (line.Contains("max-players="))
                    {
                        instanceSettings.setMaxPlayers(int.Parse(line.Replace("max-players=", "")));
                    }
                    if (line.Contains("difficulty="))
                    {
                        instanceSettings.setDifficulty(int.Parse(line.Replace("difficulty=", "")));
                    }
                    if (line.Contains("allow-flight="))
                    {
                        instanceSettings.setAllowFlight(bool.Parse(line.Replace("allow-flight=", "")));
                    }
                    if (line.Contains("enable-command-block="))
                    {
                        instanceSettings.setEnableCommandBlock(bool.Parse(line.Replace("enable-command-block=", "")));
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
                }
            }
            catch
            {
                
            }
            return instanceSettings;
        }
    }
}
