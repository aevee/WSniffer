using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WSniffer
{
    class Packet
    {
        IPAddress source;
        int sourcePort;
        IPAddress destination;
        int destinationPort;
        int number;
        int time;
        string info;
        int Protocol;
    }
}
