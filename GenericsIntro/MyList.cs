using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] İtems;
        //constructor newlwdiğimiz zaman bu alt satır çalışacak
        public MyList()
        {
            İtems = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArry = İtems;
            İtems = new T[İtems.Length+1];
            for (int i = 0; i < tempArry.Length; i++)
            {
                İtems[i] = tempArry[i];
            }

            İtems[İtems.Length - 1] = item;
        }
    }
}
