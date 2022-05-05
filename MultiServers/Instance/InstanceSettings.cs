using System;


namespace MultiServers
{
    public class InstanceSettings
    {
        private String jarFile;
        private String xmx;
        private String xms;
        private String ipAddress;
        private String serverPort;
        private bool onlineMode;
        private bool pvp;
        private int maxPlayers;
        private int difficulty;
        private bool allowFlight;
        private bool enableCommandBlock;
        public InstanceSettings setJarFile(String jarFile)
        {
            this.jarFile = jarFile;
            return this;
        }
        public String getJarFile()
        {
            return this.jarFile;
        }
        public InstanceSettings setXmx(String xmx)
        {
            this.xmx = xmx;
            return this;
        }
        public String getXmx()
        {
            return this.xmx;
        }
        public InstanceSettings setXms(String xms)
        {
            this.xms = xms;
            return this;
        }
        public String getXms()
        {
            return this.xms;
        }
        public InstanceSettings setIpAddress(String ipAddress)
        {
            this.ipAddress = ipAddress;
            return this;
        }
        public String getIpAddress()
        {
            return this.ipAddress;
        }
        public InstanceSettings setServerPort(String serverPort)
        {
            this.serverPort = serverPort;
            return this;
        }
        public String getServerPort()
        {
            return this.serverPort;
        }
        public InstanceSettings setOnlineMode(bool onlineMode)
        {
            this.onlineMode = onlineMode;
            return this;
        }
        public bool getOnlineMode()
        {
            return this.onlineMode;
        }
        public InstanceSettings setPvp(bool pvp)
        {
            this.pvp = pvp;
            return this;
        }
        public bool getPvp()
        {
            return this.pvp;
        }
        public InstanceSettings setMaxPlayers(int maxPlayers)
        {
            this.maxPlayers = maxPlayers;
            return this;
        }
        public int getMaxPlayers()
        {
            return this.maxPlayers;
        }
        public InstanceSettings setDifficulty(int difficulty)
        {
            this.difficulty = difficulty;
            return this;
        }
        public int getDifficulty()
        {
            return this.difficulty;
        }
        public InstanceSettings setAllowFlight(bool allowFlight)
        {
            this.allowFlight = allowFlight;
            return this;
        }
        public bool getAllowFlight()
        {
            return this.allowFlight;
        }
        public InstanceSettings setEnableCommandBlock(bool enableCommandBlock)
        {
            this.enableCommandBlock = enableCommandBlock;
            return this;
        }
        public bool getEnableCommandBlock()
        {
            return this.enableCommandBlock;
        }



    }
}
