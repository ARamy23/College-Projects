using System;

namespace Call_Center_Simulator
{
    public struct IncomingCall
    {
        internal string callID;
        private string callDuration;
        private DateTime callStartTime;
        private DateTime callEndTime;

        public IncomingCall(string callID)
        {
            this.callID = callID;
            callDuration = "";
            callStartTime = new DateTime();
            callEndTime = new DateTime();
        }

        internal void Start()
        {
            callStartTime = DateTime.Now;
            Console.WriteLine("#{0} has started at {1}", callID, callStartTime.ToString());
        }

        internal void End()
        {   
            callEndTime = DateTime.Now;
            Console.WriteLine("{0} has ended at {1}", callID, callEndTime.ToString());
            callDuration = callEndTime.Subtract(callStartTime).Seconds.ToString();
            Console.WriteLine("Call took {0} seconds", callDuration);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}