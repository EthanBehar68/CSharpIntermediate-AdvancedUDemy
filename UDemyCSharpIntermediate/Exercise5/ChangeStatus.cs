﻿using System;

namespace UDemyCSharpIntermediate
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("ChangeStatus is executing...");
        }
    }
}
