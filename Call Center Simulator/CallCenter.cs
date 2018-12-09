using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Call_Center_Simulator
{
    public class CallCenter
    {
        private Queue<IncomingCall> calls;
        private Consultant activeConsultant;
        private Random random;
        
        public CallCenter(Consultant activeConsultant)
        {
            this.activeConsultant = activeConsultant;
            calls = new Queue<IncomingCall>();
            random = new Random();
        }

        internal void takeupACall()
        {
            IncomingCall call = calls.Peek();
            Console.WriteLine("Agent {0} is taking up call with id: #{1}", activeConsultant.name, call.callID);
            call.Start();
            Thread.Sleep(random.Next(1000, 10000));
            Console.WriteLine();
            Console.WriteLine();
            completeACall();
        }

        internal void enqueueACall(string callID)
        {
            IncomingCall call = new IncomingCall(callID);
            calls.Enqueue(call);
        }
        
        private void completeACall()
        {
            calls.Dequeue().End();
        }
        
        internal bool areAcceptingCalls()
        {
            return calls.Count > 0;
        }
    }
}