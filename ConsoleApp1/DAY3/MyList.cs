using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    public class MyList<T>
    {
        int len = 0;
        List<T> list;

        public void Add(T elemnt)
        {
            list.Add(elemnt);
        }
        public T Revome(int ind)
        {
            T ret = list[ind];
            list.RemoveAt(ind);

            return ret;
        }
        public bool Contains(T element)
        {
            foreach (T elemnt in list)
            {
                if (elemnt.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            list.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            list.RemoveAt(index);
        }

        public T find(int index)
        {
            return list[index];
        }

        public void PrintAll()
        {
            foreach (T elemnt in list)
            {
                Console.Write(elemnt + " ");
            }
            Console.WriteLine(" ");
        }
         
        public MyList(int l)
        {
            len = l;
            list = new List<T>(l);
        }
    }
}
