using System;

namespace CSharpIntermediateUDemy
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("SendEmail is executing...");
        }
    }
}
