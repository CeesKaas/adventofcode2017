﻿using day13.implementation;
using System;

namespace day13
{
    class Program
    {
        static void Main(string[] args)
        {
            var firewall = new Firewall(input);
            Packet packet = null;
            firewall.FinishedPacket += (sender, p) =>
            {
                if (p == null) return;
                packet = p;
                Console.WriteLine($"packet id {p.Id}: {p.RiskScore}, {p.Hit}");
            };

            firewall.InjectPacket(new Packet() { Id = 0 });
            //int limiter = 10;
            int packetCount = 0;
            while (packet == null || packet.RiskScore > 0 || packet.Hit > 0)
            {
                firewall.Tick();
                firewall.InjectPacket(new Packet() { Id = ++packetCount });
            }

            Console.Read();
        }
        const string input = @"0: 4
1: 2
2: 3
4: 5
6: 6
8: 4
10: 8
12: 6
14: 6
16: 8
18: 8
20: 6
22: 8
24: 9
26: 8
28: 8
30: 12
32: 12
34: 10
36: 12
38: 12
40: 10
42: 12
44: 12
46: 12
48: 12
50: 12
52: 14
54: 14
56: 12
58: 14
60: 14
62: 14
64: 17
66: 14
70: 14
72: 14
74: 14
76: 14
78: 18
82: 14
88: 18
90: 14";
    }
}
