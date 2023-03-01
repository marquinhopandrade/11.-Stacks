using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();
            if (stack.Count > 0)
            {
                stack.Pop();
            }
            //add elements to the stack using Push()
            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);

            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());           
            stack.Push(4);
            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack (using peek) is : {0}", stack.Peek());
            while (stack.Count > 0)
            {
                //remove items from a stack e nos usamos o popedItem para armazenar o valor que foi retirado da pilha
                int popedItem = stack.Pop();
                Console.WriteLine("Poped item: {0}", popedItem);
                //print the stack count
                Console.WriteLine("Current stack count is : {0}", stack.Count);
            }
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            //defining a new stack of int
            Stack<int> myStack = new Stack<int>();
            foreach (int number in numbers)
            {
                //print it
                Console.WriteLine(number + " ");
                //push it into our stack(add)
                myStack.Push(number);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Reverse array:");       
            //usando o stack.Pop()

            while (myStack.Count > 0)
            {
                //Pop it and store it in a variable
                int number = myStack.Pop();
                //print the value we popped
                Console.WriteLine(number + " ");
                //poderia ser tambem apenas Console.WriteLine(myStack.Pop())
            }
;

        }
    }
}
