using netowrk_transport_protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_server
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameServer = new GameServerNetworkProtocol();
            gameServer.StartListener();
        }
    }
}
