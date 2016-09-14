using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubNubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            PubNubSub pSub = new PubNubSub();
            pSub.initialize();

            Console.ReadLine();
        }
    }
}
