using System;

namespace UDemyCSharpIntermediate
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("SendEmail is executing...");
        }
    }
}
