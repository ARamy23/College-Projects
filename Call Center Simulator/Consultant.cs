using System;
using System.Threading;

namespace Call_Center_Simulator
{
    public struct Consultant
    {
        internal string name;
        private string id;

        public Consultant(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        internal void takeABreak()
        {
            Console.WriteLine("Agent {0} is taking a break", name);
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}