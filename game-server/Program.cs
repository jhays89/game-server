using network_transport_protocol;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_server
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameServer = new GameServerNetworkProtocol(GetTickRateFromConfiguration());
            gameServer.StartListener();
        }

        private static int GetTickRateFromConfiguration()
        {
            return Int32.Parse(ConfigurationManager.AppSettings["ServerTickRate"]);
        }
    }
}
