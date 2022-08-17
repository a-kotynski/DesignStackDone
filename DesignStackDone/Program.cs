using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStack
{
    public class Stack : Object
    {
        //public List<object>? StackList { get; set; }
        public ArrayList StackList = new ArrayList();
        public object Object { get; set; }
        public void Push(object obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new InvalidOperationException("You can not push \"nothing\" to the Stack");
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
        public object Pop()
        {
            //try
            //{
            //    return StackList[StackList.Count - 1];
            //    //StackList.RemoveAt(StackList.Count - 1);
            //}
            //catch (InvalidOperationException)
            //{

            //    throw;
            //}
            if (StackList.Count != 0)
            {
                Object = StackList[StackList.Count - 1];
                StackList.Remove(Object);
            }
            else
            {
                throw new InvalidOperationException("Can't remove anything.");
            }
            return Object;
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
