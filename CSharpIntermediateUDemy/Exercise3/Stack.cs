using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediateUDemy
{
    class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push (object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Cannot Push null value on the stack.");
            }

            _stack.Add(obj);
        }

        public object Pop()
        {
            if(_stack.Count == 0)
            {
                throw new InvalidOperationException("Cannot Pop when stack is empty.");
            }

            var lastIndex = _stack.Count - 1;
            var obj = _stack[lastIndex];
            _stack.RemoveAt(lastIndex);
            return obj;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
