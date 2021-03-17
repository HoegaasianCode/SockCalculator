    using System;

namespace JoeSock
{
    class Program
    {
        // https://edabit.com/challenge/C6wN5vGodWvWL7ZaK
        // SOLVED
        // How's the performance on this one?
        // First time I ever used algebra in "real life"

        static void Main(string[] args)
        {
            var socks = new SockCalc("CABBACCC");
            var countedSocks = socks.CountSocks();
            var countedSockPairs = countedSocks.CountPairs();
            Console.WriteLine(countedSockPairs);
        }
    }
}
