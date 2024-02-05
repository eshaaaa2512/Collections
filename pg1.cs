﻿using System;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Count());

            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Pop();
            stack1.Push(4);
            stack1.Push(5);
            Console.WriteLine(stack1.Count);
            Console.WriteLine(stack1.Peek());


            //Various operations for stack are 
            //Push()
            //Pop()
            //Peek

        }
    }
}