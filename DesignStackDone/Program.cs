using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStack
{
    public class Stack
    {
        public ArrayList StackList = new ArrayList();
        public object? LastObject { get; set; }
        public void Push(object obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new InvalidOperationException("It's a NULL.");
                }
                else
                {
                    StackList.Add(obj);
                }
            }
            catch (InvalidOperationException)
            {

                throw;
            }
        }
        public void GetObject()
        {
            StackList.Remove(LastObject);
        }
        public object? Pop()
        {
            if (StackList.Count != 0)
            {
                LastObject = StackList[StackList.Count - 1];
                GetObject();
            }
            else
            {
                throw new InvalidOperationException("Can't remove anything.");
            }
            return LastObject;
        }
        public void Clear()
        {
            StackList.Clear();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
