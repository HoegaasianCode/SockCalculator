using System;
using System.Collections.Generic;
using System.Text;

namespace JoeSock
{
    public class SockCalc
    {
        public string _socks;
        public int[] Socks = new int[] {0,0,0};
        
        public SockCalc(string socks)
        {
            _socks = socks; // "CABBACCC"
        }

        public SockCalc CountSocks()
        {
            foreach(var x in _socks)
            {
                if (x == 'A') Socks[0]++;
                if (x == 'B') Socks[1]++;
                if (x == 'C') Socks[2]++;
            }
            return this;
        }

        public int CountPairs()
        {
            int x = 0;
            foreach(var socks in Socks)
            {
                if (socks % 2 == 0) x += socks / 2;
                else x += (socks - 1) / 2;
            }
            return x;
        }
    }
}   
