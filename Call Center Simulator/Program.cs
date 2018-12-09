using System;
using System.Threading;

namespace Call_Center_Simulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Consultant jamesBond = new Consultant("James Bond", "007");
            CallCenter center = new CallCenter(jamesBond);
            
            center.enqueueACall("1234");
            center.enqueueACall("5678");
            center.enqueueACall("9101");
            center.enqueueACall("2345");
            center.enqueueACall("6789");
            center.enqueueACall("1012");

            int takenCallsCount = 0;
            
            while (center.areAcceptingCalls())
            {
                takenCallsCount++;
                if (takenCallsCount % 3 == 0)
                    jamesBond.takeABreak();
                center.takeupACall();
            }
        }
    }
}