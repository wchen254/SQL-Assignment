using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    public class MyStack<T>
    {
        int len;
        T[] stack;
        int top = -1;
        public int Count()
        {
            return top+1;
        }

        public T Pop()
        {
            T ret = stack[top];
            if (top >= 0)
            {
                top--;
                return ret;
            }
            else
            {
                Console.WriteLine("empty stack");
                return default(T);
            }
        }

        public void Push(T item)
        {
            if (top == len-1)
            {
                Console.WriteLine("over flow");
            }
            else
            {
                top++;
                stack[top] = item;
            }
        }

        public MyStack(int l)
        {
            len = l;
            stack = new T[len];
        }
    }
}
