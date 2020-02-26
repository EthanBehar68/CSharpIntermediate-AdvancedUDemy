using System;

namespace CSharpIntermediateUDemy
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("ChangeStatus is executing...");
        }
    }
}
